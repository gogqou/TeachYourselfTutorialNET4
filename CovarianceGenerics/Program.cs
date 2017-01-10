using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] array = { 0, 2, 4, 6, 8 };
            //List<int> list = new List<int>() { 1, 3, 5, 7, 9 };
            //PrintCollection(array);
            //PrintCollection(list);

            string[] array2 = { "hello", "World" };
            List<string> list2 = new List<string>() { "Now", "is", "the", "time" };
            PrintCollection(array2);
            PrintCollection(list2);
            Console.ReadLine();
        }
        public static void PrintCollection(IEnumerable<object> collection)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in collection)
            {
                builder.AppendFormat("{0}", item);
            }
            Console.WriteLine(builder.ToString());
        }

    }
}
