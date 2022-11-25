using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new string[] { "a", "c", "b", "h", "t", "v" };

            Array.Sort(p);
            Console.WriteLine("По возрастанию:");
            foreach (var per in p)
                Console.Write($" {per} ");
            Console.WriteLine();

            Console.WriteLine("По убыванию:");
            int[] arr = new int[] { 7, 1, 3, 9, 2 };
            Array.Sort(arr, (x, y) => y.CompareTo(x));
            Console.WriteLine(String.Join(", ", arr));
            Console.WriteLine();

            Console.WriteLine("Объединенный:");
            int[] arr1 = new int[] { 7, 1, 3, 9, 2 };
           int  [] arr2 = new int[] { 8, 1, 6, 9, 2 };
            int[] arr3 = arr1.Concat(arr2).ToArray();

            foreach (var per in arr3)
                Console.Write($" {per} ");


        }
    }
}
