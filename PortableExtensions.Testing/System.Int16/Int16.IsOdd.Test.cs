﻿#region Using

using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class Int16ExTest
    {
        [TestCase]
        public void IsOddTestCase()
        {
            var value = RandomValueEx.GetRandomInt16();

            var expected = value % 2 != 0;
            var actual = value.IsOdd();
            Assert.AreEqual( expected, actual );
        }
    }
}