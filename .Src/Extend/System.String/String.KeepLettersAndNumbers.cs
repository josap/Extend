﻿#region Usings

using System;
using System.Linq;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Removes all characters which aren't letters or numbers.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the letters and numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String KeepLettersAndNumbers( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => x.IsNumber() || x.IsLetter() )
                                  .ToArray() );
        }
    }
}