using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dyClawler.Helper
{
    public static class Extension
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> loop)
        {
            foreach (var per in collection)
            {
                loop(per);
            }
        }
        public static void ForEach<T>(this IQueryable<T> collection, Action<T> loop)
        {
            foreach (var per in collection)
            {
                loop(per);
            }
        }
    }
}