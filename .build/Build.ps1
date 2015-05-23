<#
Main build script
#>
properties { 
    $srcDir = "$root\.Src\"
    $nuget = "$root\.Tools\NuGet\nuget.exe"
    $nunit = "$root\.Tools\NUnit\nunit-console.exe"
    $git = "git"
    $msBuild = "MSBuild"
    $buildConfiguration = "Release"
    $msBuildTargets = "Clean;Rebuild"
    $msBuildVerbosity = "minimal"
    $treatWarningsAsErrors = $true
    $binDir = "bin"
    $outputDirectory = "$root\Output"
}
$root = Resolve-Path ..

# Load additional scripts
."$root\.Build\Projects.ps1"
."$root\.Build\BuildHelpers.ps1"

# Get projects to build
$allProjects = Get-Projects

# Default task
Task default -Depends Clean, RestorePackages, Build, CopyBuildOutput, Test

# Cleans the output directory
Task Clean {
    Write-Host "Clean repository" -fore Magenta
    
    ExecInDir $root {
        exec { &$git clean -xdf  } "Git clean failed"
    }
}

# Restores all NuGet packages
Task RestorePackages {
    Write-Host "Restore NuGet packages" -fore Magenta

    # For each project with enabled NuGet restore
    foreach($project in $allProjects | where { $_.RestoreNuGetPackages } ) {
        $projectPath = [System.IO.Path]::Combine($srcDir, $project.Name)
        exec {
            &$nuget restore $projectPath
        } "NuGet restore failed for: '$projectPath'"
    }
}

# Build all projects
task Build {
    Write-Host "Build projects" -fore Magenta

    # For each project
    foreach($project in $allProjects) {
        $projectPath = [System.IO.Path]::Combine($srcDir, $project.Name)
        $outDir = $project.OutputDirectory
        exec {
            &$msBuild $projectPath "/t:$msBuildTargets" "/p:Configuration=$buildConfiguration" "/p:Platform=Any CPU" "/verbosity:$msBuildVerbosity" "/p:TreatWarningsAsErrors=$treatWarningsAsErrors" "/p:OutputPath=$binDir\$buildConfiguration\$outDir\"
        } "Failed to build: '$projectPath'"
    }
}

# Run all unit tests
task CopyBuildOutput {
    Write-Host "Copy build output" -fore Magenta

    # Create output directory if not exists
    if(!(Test-Path -Path $outputDirectory )) {
        New-Item -ItemType directory -Path $outputDirectory | Out-Null
    }

    # Copy each build output to the output directory
    foreach($project in $allProjects) {
        $buildOutput = [System.IO.Path]::Combine($srcDir, $project.ProjectDirectory, $binDir, $buildConfiguration, $project.OutputDirectory)
        Copy-Item $buildOutput $outputDirectory -Recurse -Force
    }
}

# Run all unit tests
task Test {
    Write-Host "Run unit tests" -fore Magenta
    
    # For each project
    foreach($project in $allProjects | where { $_.TestRunner -ne $null } ) {

        $buildOutput = [System.IO.Path]::Combine($srcDir, $project.TestDirectory, $binDir, $buildConfiguration, $project.OutputDirectory, $project.TestProjectName) + ".dll"
        Write-Host $buildOutput
        
        switch ($project.TestRunner) { 
            "NUnit" { RunNUnitTest $project $buildOutput } 
            default { throw "Test-runner '{0}' is not supported" -f $project.TestRunner }
        }
    }
}

# Run NUnit tests for the given project
function RunNUnitTest($project, $testDll) {
    Write-Host "Run NUnit tests: '$testDll'"
    exec { 
        &$nunit $testDll | Out-Null 
    } "Running NUnit tests '$testDll' failed"

}