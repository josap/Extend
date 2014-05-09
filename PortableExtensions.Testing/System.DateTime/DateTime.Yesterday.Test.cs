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
        public void YesterdayTestCase()
        {
            var dateTime = DateTime.Today;
            var expected = dateTime.AddDays( -1 );
            var actual = dateTime.Yesterday();

            Assert.AreEqual( expected, actual );
        }
    }
}