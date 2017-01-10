using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //collection initializers
            //don't work with stack or queue, because needs Add method
            List<int> list = new List<int>() { 0, 2, 4, 6, 8 };

            //learning about queues and stacks
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(2);
            stack.Push(4);
            Console.WriteLine("Current top of stack = {0}", stack.Peek());
            stack.Push(6);
            stack.Push(8);
            stack.Push(10);
            Console.WriteLine("Current top of stack = {0}", stack.Pop());
            Console.WriteLine("Current top of stack = {0}", stack.Peek());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(5);
            Console.WriteLine("Current top of queue = {0}", queue.Peek());
            queue.Enqueue(7);
            queue.Enqueue(9);
            queue.Enqueue(11);
            Console.WriteLine("Current top of queue = {0}", queue.Dequeue());
            Console.WriteLine("Current top of queue = {0}", queue.Peek());

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            /*
             * learning about dictionaries and sorted dictionaries
            SortedDictionary<string, double> dictionary = new SortedDictionary<string, double>();
            dictionary.Add("Speed of Light", 2.997924580e+8F);
            dictionary.Add("Gravitational Constant", 6.67428e-11F);
            dictionary.Add("Electron Volt", 1.602e-19);
            foreach (var name in dictionary)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            */

            /*
             * Inherited from Collection<int>
            Int32Collection list = new Int32Collection();
            for (int i = 0; i < 16; i++)
            {
                list.Add(i * 2);
            }
            foreach (int integer in list)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine("Capacity : {0}", list.Count);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            */

            /*
             * Original version of code based on using only List<T>
             * New version more generically looks at the Collection<T> class
             * 
            List<int> list = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                list.Add(i * 2);
            }
            foreach (int integer in list)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine("Capacity : {0}", list.Capacity);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            */
        }
    }
}
