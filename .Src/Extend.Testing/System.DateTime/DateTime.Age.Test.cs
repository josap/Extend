﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class DateTimeExTest
    {
        [Test]
        public void AgeTest()
        {
            var dateTime = new DateTime( 1980, 1, 1 );
            var expected = DateTime.Now.Year - 1980;
            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );

            dateTime = DateTime.Now.AddYears( -2 )
                               .Add( 1.ToDays() );

            expected = 1;
            actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest1()
        {
            var dateTime = DateTime.Now.AddYears( -2 )
                                   .Add( 1.ToDays() );
            const Int32 expected = 1;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest10()
        {
            var dateTime = DateTime.Now;
            var currentDate = DateTime.Now.AddYears( 2 )
                                      .AddDays( 1 );
            const Int32 expected = 2;

            var actual = dateTime.Age( currentDate );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest11()
        {
            var dateTime = DateTime.Now;
            var currentDate = DateTime.Now.AddYears( 2 )
                                      .AddDays( -1 );
            const Int32 expected = 1;

            var actual = dateTime.Age( currentDate );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest12()
        {
            var dateTime = DateTime.Now;
            var currentDate = DateTime.Now.AddYears( -2 );
            const Int32 expected = -2;

            var actual = dateTime.Age( currentDate );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest13()
        {
            var dateTime = DateTime.Now;
            var currentDate = DateTime.Now.AddYears( -2 )
                                      .AddDays( 1 );
            const Int32 expected = -1;

            var actual = dateTime.Age( currentDate );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest14()
        {
            var dateTime = DateTime.Now;
            var currentDate = DateTime.Now.AddYears( -2 )
                                      .AddMonths( 1 );
            const Int32 expected = -1;

            var actual = dateTime.Age( currentDate );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest15()
        {
            var dateTime = new DateTime( 2014, 10, 31 ).AddYears( 1 )
                                                       .AddMonths( 1 );
            const Int32 expected = -1;

            var actual = dateTime.Age( new DateTime( 2014, 10, 31 ) );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest16()
        {
            var dateTime = new DateTime( 2014, 10, 31 ).AddYears( 1 )
                                                       .AddDays( 1 );
            const Int32 expected = -1;

            var actual = dateTime.Age( new DateTime( 2014, 10, 31 ) );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest17()
        {
            var dateTime = new DateTime( 2015, 10, 31 ).AddYears( 1 )
                                                       .AddMonths( 1 );
            const Int32 expected = -2;

            var actual = dateTime.Age( new DateTime( 2014, 10, 31 ) );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest18()
        {
            var dateTime = new DateTime( 2015, 10, 31 ).AddYears( 1 )
                                                       .AddDays( 1 );
            const Int32 expected = -2;

            var actual = dateTime.Age( new DateTime( 2014, 10, 31 ) );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest2()
        {
            var dateTime = DateTime.Now.AddYears( -1 )
                                   .AddMonths( -3 );
            const Int32 expected = 1;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest3()
        {
            var dateTime = DateTime.Now.AddDays( 1 );
            const Int32 expected = 0;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest4()
        {
            var dateTime = DateTime.Now.AddYears( 3 );
            const Int32 expected = -3;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest5()
        {
            var dateTime = DateTime.Now.AddMonths( 1 );
            const Int32 expected = 0;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest6()
        {
            var dateTime = DateTime.Now;
            const Int32 expected = 0;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest7()
        {
            var dateTime = DateTime.Now.AddYears( 1 )
                                   .AddMonths( 1 );
            const Int32 expected = -1;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest8()
        {
            var dateTime = DateTime.Now.AddYears( 1 )
                                   .AddDays( 1 );
            const Int32 expected = -1;

            var actual = dateTime.Age();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void AgeTest9()
        {
            var dateTime = DateTime.Now;
            var currentDate = DateTime.Now.AddYears( 2 );
            const Int32 expected = 2;

            var actual = dateTime.Age( currentDate );
            Assert.AreEqual( expected, actual );
        }
    }
}