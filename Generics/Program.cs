using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] intArray = { 5, 3,3,1,25, 1 };
            Console.WriteLine("The minimum is {0}.", Min(intArray));
            Console.ReadLine();
        }
        public static int Min(int[] values)
        {
            Console.WriteLine("Executing Min(int[])");
            int min = values[0];
            foreach (int value in values)
            {
                if (value.CompareTo(min)<0)
                {
                    min = value;
                }
            }
            return min;
        }
        public static object Min(object[] values)
        {
            Console.WriteLine("Executing Min(object[])");
            IComparable min = (IComparable)values[0];
            foreach (object value in values)
            {
                if (((IComparable)value).CompareTo(min)<0)
                {
                    min = (IComparable)value;
                }
            }
            return min;
        }
        public static T Min<T> (T[] values) where T:IComparable<T>
        {
            Console.WriteLine("Executing T Min<T>");
            T min = values[0];
            foreach (T value in values)
            {
                if (value.CompareTo(min)< 0)
                {
                    min = value;
                }

            }
            return min;
        }
    }
}
