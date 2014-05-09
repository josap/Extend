﻿#region Using

using System;
using System.IO;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="string" />.
    /// </summary>
    public static partial class StringEx
    {
        /// <summary>
        ///     Gets the extension of the given file.
        /// </summary>
        /// <exception cref="ArgumentNullException">The file name can not be null.</exception>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>The file extension.</returns>
        public static String GetFileExtension( this String fileName )
        {
            fileName.ThrowIfNull( () => fileName );

            return Path.GetExtension( fileName );
        }
    }
}