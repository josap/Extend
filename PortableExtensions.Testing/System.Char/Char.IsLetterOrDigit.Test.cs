﻿#region Using

using System.Linq;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class CharExTest
    {
        [TestCase]
        public void IsLetterOrDigitTestCase()
        {
            var range = 0.RangeTo( 9 );
            foreach ( var c in range.Select( x => x.ToChar() ) )
                Assert.IsTrue( c.IsLetterOrDigit() );

            Assert.IsTrue( 'a'.IsLetterOrDigit() );
            Assert.IsTrue( 'A'.IsLetterOrDigit() );
            Assert.IsTrue( 'z'.IsLetterOrDigit() );
            Assert.IsFalse( '-'.IsLetterOrDigit() );
        }
    }
}