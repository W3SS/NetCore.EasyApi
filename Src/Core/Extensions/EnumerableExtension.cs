using System;
using System.Collections;
using System.Collections.Generic;

namespace NetCore.EasyApi.Core.Extensions
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            if (action == null)
            {
                throw new InvalidOperationException("The action of [ForEach] cannot be null!");
            }
            
            if (list == null)
            {
                return null;
            }

            foreach (var item in list)
            {
                action(item);
            }

            return list;
        }
    }
}