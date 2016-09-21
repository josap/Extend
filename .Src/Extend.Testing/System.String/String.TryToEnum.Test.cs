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
        public void TryToEnumTest()
        {
            const DayOfWeek expected = DayOfWeek.Monday;
            var actual = DayOfWeek.Saturday;
            var result = StringEx.TryToEnum( expected.ToString(), out actual );

            actual
                .Should()
                .Be( expected );
            result
                .Should()
                .BeTrue();
        }

        [Test]
        public void TryToEnumTestNullCheck()
        {
            var day = DayOfWeek.Saturday;
            var actual = StringEx.TryToEnum( null, out day );

            actual
                .Should()
                .BeFalse();
            day
                .Should()
                .Be( default(DayOfWeek) );
        }
    }
}