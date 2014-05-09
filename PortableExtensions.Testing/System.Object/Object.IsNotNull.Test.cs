﻿#region Using

using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class ObjectExTest
    {
        [TestCase]
        public void IsNotNullTestCase()
        {
            var value = RandomValueEx.GetRandomString();
            var actual = value.IsNotNull();

            Assert.IsTrue( actual );

            value = null;
            actual = value.IsNotNull();

            Assert.IsFalse( actual );
        }
    }
}