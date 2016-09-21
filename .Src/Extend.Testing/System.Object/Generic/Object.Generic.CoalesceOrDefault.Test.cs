﻿#region Usings

using System;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class ObjectExTest
    {
        [Test]
        public void CoalesceOrDefault1Test()
        {
            var expected = RandomValueEx.GetRandomString();
            String s = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => expected.CoalesceOrDefault( s, null, null, "expected", "Test2" );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void CoalesceOrDefaultTest()
        {
            var expected = RandomValueEx.GetRandomString();
            String s = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => ObjectEx.CoalesceOrDefault( null, s, null, null, expected, "Test2" );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void CoalesceOrDefaultTest2()
        {
            var expected = RandomValueEx.GetRandomString();
            String s = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = ObjectEx.CoalesceOrDefault( null, () => s, null, null, expected, "Test2" );

            Assert.AreEqual( expected, actual );

            actual = ObjectEx.CoalesceOrDefault( null, () => expected, null, null );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void CoalesceOrDefaultTest2NullCheck()
        {
            String s = null;
            Func<String> func = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once ExpressionIsAlwaysNull
            Action test = () => s.CoalesceOrDefault( func, null, null );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void CoalesceOrDefaultTest3()
        {
            var expected = RandomValueEx.GetRandomString();
            String s = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = expected.CoalesceOrDefault( () => s, null, null, "Test2" );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void CoalesceOrDefaultTestNullCheck()
        {
            String s = null;
            String s1 = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once ExpressionIsAlwaysNull
            Action test = () => s.CoalesceOrDefault( s1, null, null );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}