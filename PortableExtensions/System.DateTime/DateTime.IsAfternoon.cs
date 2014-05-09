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
        ///     Checks whether the given date time value is at afternoon or not.
        /// </summary>
        /// <param name="dateTime">The date time to check.</param>
        /// <returns>Returns true if the date time value is at afternoon, otherwise false.</returns>
        public static Boolean IsAfternoon( this DateTime dateTime )
        {
            return dateTime.TimeOfDay >= new DateTime( 2000, 1, 1, 12, 0, 0 ).TimeOfDay;
        }
    }
}