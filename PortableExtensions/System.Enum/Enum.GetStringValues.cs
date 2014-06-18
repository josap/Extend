﻿#region Using

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Enum" />.
    /// </summary>
    public static partial class EnumEx
    {
        /// <summary>
        ///     Gets the values of the specified enumeration as strings.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>All values of the specified enumeration as strings.</returns>
        public static IEnumerable<String> GetStringValues<T>() where T : struct
        {
            return GetValues<T>().Select( x => x.ToString() );
        }
    }
}