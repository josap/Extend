﻿#region Using

using System;
using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class CollectionTExTest
    {
        [TestCase]
        public void IsNotNullOrEmptyTestCase()
        {
            List<String> list = null;
            Assert.IsFalse( list.IsNotNullOrEmpty() );

            list = new List<String>();
            Assert.IsFalse( list.IsNotNullOrEmpty() );

            list.Add( RandomValueEx.GetRandomString() );
            Assert.IsTrue( list.IsNotNullOrEmpty() );
        }
    }
}