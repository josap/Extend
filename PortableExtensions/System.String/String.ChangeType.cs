﻿#region Using

using System;
using System.Globalization;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="string" />.
    /// </summary>
    public static partial class StringEx
    {
        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to
        ///     the specified object.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <exception cref="OverflowException">value represents a number that is out of the range of conversionType.</exception>
        /// <exception cref="FormatException">value is not in a format recognized by conversionType.</exception>
        /// <exception cref="InvalidCastException">
        ///     This conversion is not supported. -or-value is null and conversionType is
        ///     a value type.-or-value does not implement the System.IConvertible interface.
        /// </exception>
        /// <param name="value">An object that implements the System.IConvertible interface.</param>
        /// <param name="type">The type of object to return.</param>
        /// <returns>
        ///     An object whose type is conversionType and whose value is equivalent to value.-or-A
        ///     null reference (Nothing in Visual Basic), if value is null and conversionType
        ///     is not a value type.
        /// </returns>
        public static Object ChangeType( this String value, Type type )
        {
            return value.ChangeType( type, CultureInfo.InvariantCulture );
        }

        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to
        ///     the specified object.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <exception cref="OverflowException">value represents a number that is out of the range of conversionType.</exception>
        /// <exception cref="FormatException">value is not in a format recognized by conversionType.</exception>
        /// <exception cref="InvalidCastException">
        ///     This conversion is not supported. -or-value is null and conversionType is
        ///     a value type.-or-value does not implement the System.IConvertible interface.
        /// </exception>
        /// <param name="value">An object that implements the System.IConvertible interface.</param>
        /// <param name="type">The type of object to return.</param>
        /// <param name="formatProvider"> An object that supplies culture-specific formatting information.</param>
        /// <returns>
        ///     An object whose type is conversionType and whose value is equivalent to value.-or-A
        ///     null reference (Nothing in Visual Basic), if value is null and conversionType
        ///     is not a value type.
        /// </returns>
        public static Object ChangeType( this String value, Type type, IFormatProvider formatProvider )
        {
            type.ThrowIfNull( () => type );

            return Convert.ChangeType( value, type, formatProvider );
        }
    }
}