﻿#region Using

using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class CharExTest
    {
        [TestCase]
        public void IsLowerTestCase()
        {
            Assert.IsTrue( 'a'.IsLower() );
            Assert.IsFalse( 'A'.IsLower() );
            Assert.IsFalse( '1'.IsLower() );
        }
    }
}