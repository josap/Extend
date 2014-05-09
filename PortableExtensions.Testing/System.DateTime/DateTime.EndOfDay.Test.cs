﻿#region Using

using System;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class DateTimeExTest
    {
        [TestCase]
        public void EndOfDayTestCase()
        {
            var dateTime = DateTime.Now;
            var expected =
                new DateTime( dateTime.Year, dateTime.Month, dateTime.Day ).AddDays( 1 ).Subtract( 1.ToMilliseconds() );
            var actual = dateTime.EndOfDay();
            Assert.AreEqual( expected, actual );
        }
    }
}