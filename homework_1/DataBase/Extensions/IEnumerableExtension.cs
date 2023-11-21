using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Extensions
{
    internal static class IEnumerableExtensions
    {
        public static void PrintColleciton<T>(this IEnumerable<T> sourceCollection)
        {
            Console.WriteLine(Environment.NewLine);
            foreach (var item in sourceCollection)
                Console.WriteLine($"{item}");
        }

        public static void PrintColleciton<T>(this IEnumerable<T> sourceCollection, Func<T, string> function)
        {
            Console.WriteLine(Environment.NewLine);
            foreach (var item in sourceCollection)
                Console.WriteLine(function.Invoke(item));
        }
    }
}

