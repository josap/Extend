﻿#region Using

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class DateTimeExTest
    {
        [TestCase]
        public void ToShortTimeStringTestCase()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "t" );
            var actual = dateTime.ToShortTimeString();
            Assert.AreEqual( expected, actual );
        }

        [TestCase]
        public void ToShortTimeStringTestCase1()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "t", DateTimeFormatInfo.CurrentInfo );
            var actual = dateTime.ToShortTimeString( DateTimeFormatInfo.CurrentInfo );
            Assert.AreEqual( expected, actual );
        }

        [TestCase]
        public void ToShortTimeStringTestCase2()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "t", CultureInfo.InvariantCulture );
            var actual = dateTime.ToShortTimeString( CultureInfo.InvariantCulture );
            Assert.AreEqual( expected, actual );
        }
    }
}