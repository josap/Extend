﻿#region Using

using System;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class TimeSpanExTest
    {
        [TestCase]
        public void FPastTestCase()
        {
            var expected = DateTime.Now.Subtract( TimeSpan.FromDays( 1 ) );
            var actual = TimeSpan.FromDays( 1 ).Past();

            Assert.AreEqual( expected.Day, actual.Day );
        }
    }
}