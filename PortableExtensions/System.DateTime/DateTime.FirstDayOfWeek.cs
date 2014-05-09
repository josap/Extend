﻿#region Using

using System;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class DateTimeEx
    {
        /// <summary>
        ///     Returns the first day of the week, represented by the given date time.
        /// </summary>
        /// <param name="week">The week to return the first day of.</param>
        /// <returns>Returns the first day of the week, represented by the given date time.</returns>
        public static DateTime FirstDayOfWeek( this DateTime week )
        {
            return new DateTime( week.Year, week.Month, week.Day ).AddDays( -(Int32) week.DayOfWeek );
        }
    }
}