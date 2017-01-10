using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintString(null);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            /*
             * the following code leads the exception to print out on console rather than
             * throwing an error dialog
            try
            {
                ThrowsException();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            Console.ReadLine();    
        }

        private static void ThrowsException()
        {
            Console.WriteLine("About to throw an InvalidOperationException");

            throw new InvalidOperationException();
        }
        private static void PrintString(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");

            }
            Console.WriteLine(message);
        }
    }
}
