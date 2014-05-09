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
        public void ToInt16TestCase()
        {
            var expected = RandomValueEx.GetRandomInt16();
            var value = expected.ToString();
            var actual = ObjectEx.ToInt16( value );
            Assert.AreEqual( expected, actual );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void ToInt16TestCaseNullCheck()
        {
            ObjectEx.ToInt16( null );
        }

        [TestCase]
        public void ToInt16TestCase1()
        {
            var expected = RandomValueEx.GetRandomInt16();
            var value = expected.ToString();
            var actual = ObjectEx.ToInt16( value, CultureInfo.InvariantCulture );
            Assert.AreEqual( expected, actual );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void ToInt16TestCase1NullCheck()
        {
            ObjectEx.ToInt16( null, CultureInfo.InvariantCulture );
        }

        [TestCase]
        [ExpectedException( typeof ( ArgumentNullException ) )]
        public void ToInt16TestCase1NullCheck1()
        {
            ObjectEx.ToInt16( "false", null );
        }
    }
}