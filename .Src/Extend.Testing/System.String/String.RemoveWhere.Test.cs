﻿#region Usings

using System;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void RemoveWhereTest()
        {
            var actual = "a1-b2.c3".RemoveWhere( x => x.IsNumber() );
            Assert.AreEqual( "a-b.c", actual );
        }

        [Test]
        public void RemoveWhereTestNullCheck()
        {
            Action test = () => StringEx.RemoveWhere( null, x => false );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void RemoveWhereTestNullCheck1()
        {
            Action test = () => "".RemoveWhere( null );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}