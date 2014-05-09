﻿#region Using

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [TestCase]
        public void TryParsInt16TestCase()
        {
            var expected = RandomValueEx.GetRandomInt16();
            var result = RandomValueEx.GetRandomInt16();
            var actual = expected.ToString( CultureInfo.InvariantCulture ).TryParsInt16( out result );

            Assert.AreEqual( expected, result );
            Assert.IsTrue( actual );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void TryParsInt16TestCaseNullCheck()
        {
            var outValue = RandomValueEx.GetRandomInt16();
            StringEx.TryParsInt16( null, out outValue );
        }

        [TestCase]
        public void TryParsInt16TestCase1()
        {
            var culture = new CultureInfo( "en-US" );
            var expected = RandomValueEx.GetRandomInt16();
            var result = RandomValueEx.GetRandomInt16();
            var actual = expected.ToString( culture ).TryParsInt16( NumberStyles.Any, culture, out result );

            Assert.AreEqual( expected, result );
            Assert.IsTrue( actual );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void TryParsInt16TestCase1NullCheck()
        {
            var outValue = RandomValueEx.GetRandomInt16();
            StringEx.TryParsInt16( null, NumberStyles.Any, CultureInfo.InvariantCulture, out outValue );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void TryParsInt16TestCase1NullCheck1()
        {
            var outValue = RandomValueEx.GetRandomInt16();
            "".TryParsInt16( NumberStyles.Any, null, out outValue );
        }
    }
}