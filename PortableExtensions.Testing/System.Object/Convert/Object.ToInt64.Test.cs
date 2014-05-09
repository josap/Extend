﻿#region Using

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class ObjectExTest
    {
        [TestCase]
        public void ToInt64TestCase()
        {
            var expected = (Int64) RandomValueEx.GetRandomInt32();
            var value = expected.ToString();
            var actual = ObjectEx.ToInt64( value );
            Assert.AreEqual( expected, actual );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void ToInt64TestCaseNullCheck()
        {
            ObjectEx.ToInt64( null );
        }

        [TestCase]
        public void ToInt64TestCase1()
        {
            var expected = (Int64) RandomValueEx.GetRandomInt32();
            var value = expected.ToString();
            var actual = ObjectEx.ToInt64( value, CultureInfo.InvariantCulture );
            Assert.AreEqual( expected, actual );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void ToInt64TestCase1NullCheck()
        {
            ObjectEx.ToInt64( null, CultureInfo.InvariantCulture );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void ToInt64TestCase1NullCheck1()
        {
            ObjectEx.ToInt64( "false", null );
        }
    }
}