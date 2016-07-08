using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomework
{
    internal static class EnumerableExtension
    {
        public static IEnumerable<int> SubTotal<TSource>(this IEnumerable<TSource> source, int groupSize, Func<TSource, int> selector)
        {
            int index = 0;
            while (index <= source.Count())
            {
                yield return source.Skip(index).Take(groupSize).Sum(selector);
                index += groupSize;
            }
        }
    }
}
