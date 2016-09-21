﻿#region Usings

using System;
using System.Collections.Generic;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class CollectionTEx
    {
        /// <summary>
        ///     Adds the given range of values to the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="values">The values to add.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        public static ICollection<T> AddRange<T>( [NotNull] this ICollection<T> collection, [NotNull] params T[] values )
        {
            collection.ThrowIfNull( nameof( collection ) );
            values.ThrowIfNull( nameof( values ) );

            values.ForEach( collection.Add );
            return collection;
        }

        /// <summary>
        ///     Adds the items of the given IEnumerable to the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="enumerable">The IEnumerable containing the items.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        public static ICollection<T> AddRange<T>( [NotNull] this ICollection<T> collection, [NotNull] IEnumerable<T> enumerable )
        {
            collection.ThrowIfNull( nameof( collection ) );
            enumerable.ThrowIfNull( nameof( enumerable ) );

            enumerable.ForEach( collection.Add );
            return collection;
        }
    }
}