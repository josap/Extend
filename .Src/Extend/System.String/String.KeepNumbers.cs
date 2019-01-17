#region Usings

using System;
using System.Linq;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Removes all characters which aren't numbers.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String KeepNumbers( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => x.IsNumber() )
                                  .ToArray() );
        }
        
        /// <summary>
        ///     Removes all characters which aren't numbers with exeptions.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <param name="exceptions">The except string. E.g. ".,"</param>
        /// <returns>A new string containing the exceptions and the numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String KeepNumbersExcept([NotNull] this String str, [NotNull] string exceptions) 
        {
            str.ThrowIfNull(nameof(str));

            return new String(str.ToCharArray()
                                  .Where(x => x.IsNumber() || x.IsIn(exceptions.ToCharArray()))
                                  .ToArray());
        }
    }
}
