﻿#region Usings

using System;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class BooleanExTest
    {
        [Test]
        public void IfTrueTest()
        {
            var actual = String.Empty;

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            false.IfTrue( () => actual = "1", () => actual = "0" );
            Assert.AreEqual( "0", actual );

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            true.IfTrue( () => actual = "1", () => actual = "0" );
            Assert.AreEqual( "1", actual );
        }

        [Test]
        public void IfTrueTest1()
        {
            var actual = String.Empty;

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            false.IfTrue( "test", x => actual = x + "1", x => actual = x + "0" );
            Assert.AreEqual( "test0", actual );

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            true.IfTrue( "test", x => actual = x + "1", x => actual = x + "0" );
            Assert.AreEqual( "test1", actual );
        }

        [Test]
        public void IfTrueTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => true.IfTrue( "", null, x => Assert.Fail() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void IfTrueTest2()
        {
            var actual = String.Empty;

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            false.IfTrue( "test", "P2", ( x, y ) => actual = x + y + "1", ( x, y ) => actual = x + y + "0" );
            Assert.AreEqual( "testP20", actual );

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            true.IfTrue( "test", "P2", ( x, y ) => actual = x + y + "1", ( x, y ) => actual = x + y + "0" );
            Assert.AreEqual( "testP21", actual );
        }

        [Test]
        public void IfTrueTest2NullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => true.IfTrue( "", "", null, ( x, y ) => Assert.Fail() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void IfTrueTest3()
        {
            var actual = String.Empty;

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            false.IfTrue( "test",
                          "P2",
                          "P3",
                          ( x, y, z ) => actual = x + y + z + "1",
                          ( x, y, z ) => actual = x + y + z + "0" );
            Assert.AreEqual( "testP2P30", actual );

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            true.IfTrue( "test",
                         "P2",
                         "P3",
                         ( x, y, z ) => actual = x + y + z + "1",
                         ( x, y, z ) => actual = x + y + z + "0" );
            Assert.AreEqual( "testP2P31", actual );
        }

        [Test]
        public void IfTrueTest3NullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => true.IfTrue( "", "", "", null, ( x, y, z ) => Assert.Fail() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void IfTrueTest4()
        {
            var actual = String.Empty;

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            false.IfTrue( "test",
                          "P2",
                          "P3",
                          "P4",
                          ( x, y, z, a ) => actual = x + y + z + a + "1",
                          ( x, y, z, a ) => actual = x + y + z + a + "0" );
            Assert.AreEqual( "testP2P3P40", actual );

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            true.IfTrue( "test",
                         "P2",
                         "P3",
                         "P4",
                         ( x, y, z, a ) => actual = x + y + z + a + "1",
                         ( x, y, z, a ) => actual = x + y + z + a + "0" );
            Assert.AreEqual( "testP2P3P41", actual );
        }

        [Test]
        public void IfTrueTest4NullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => true.IfTrue( "", "", "", "", null, ( x, y, z, a ) => Assert.Fail() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void IfTrueTestNullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => true.IfTrue( null, Assert.Fail );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}