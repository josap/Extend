﻿#region Usings

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace Extend
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void SaveToDecimalTestCase()
        {
            var expected = new Decimal( RandomValueEx.GetRandomInt32() );
            var actual = expected.ToString( CultureInfo.InvariantCulture )
                                 .SaveToDecimal();

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void SaveToDecimalTestCase1()
        {
            var expected = new Decimal( RandomValueEx.GetRandomInt32() );
            var actual = "InvalidValue".SaveToDecimal( expected );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void SaveToDecimalTestCase2()
        {
            var expected = new Decimal( RandomValueEx.GetRandomInt32() );
            var actual = expected.ToString( CultureInfo.InvariantCulture )
                                 .SaveToDecimal( NumberStyles.Any, CultureInfo.InvariantCulture );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void SaveToDecimalTestCase3()
        {
            var expected = new Decimal( RandomValueEx.GetRandomInt32() );
            var actual = "InvalidValue".SaveToDecimal( NumberStyles.Any, CultureInfo.InvariantCulture, expected );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void SaveToDecimalTestCase4()
        {
            var expected = new Decimal( RandomValueEx.GetRandomInt32() + 0.123 );
            var actual = expected.ToString( CultureInfo.InvariantCulture )
                                 .SaveToDecimal( Decimal.MaxValue );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void SaveToDecimalTestCase5()
        {
            var actual = "InvalidValue".SaveToDecimal();

            Assert.AreEqual( default( Decimal ), actual );
        }

        [Test]
        public void SaveToDecimalTestCase6()
        {
            var expected = new Decimal( RandomValueEx.GetRandomInt32() + 0.1523 );
            var actual = expected.ToString( CultureInfo.InvariantCulture )
                                 .SaveToDecimal( NumberStyles.Any, CultureInfo.InvariantCulture, Decimal.MinValue );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void SaveToDecimalTestCase7()
        {
            var actual = "InvalidValue".SaveToDecimal( NumberStyles.Any, CultureInfo.InvariantCulture );

            Assert.AreEqual( default( Decimal ), actual );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void SaveToDecimalTestCaseNullCheck()
        {
            StringEx.SaveToDecimal( null );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void SaveToDecimalTestCaseNullCheck1()
        {
            "".SaveToDouble( NumberStyles.AllowExponent, null );
        }
    }
}