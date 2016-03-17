﻿#region Usings

using System;

#endregion

namespace Extend
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Int32Ex
    {
        /// <summary>
        ///     Returns a date-time representing the specified day in December
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in December in the specified year.</returns>
        public static DateTime December( this Int32 day, Int32 year ) => new DateTime( year, 12, day );
    }
}