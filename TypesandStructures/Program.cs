using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TypesandStructures
{

    public class Program
    {

        public static void Main()
        {
            /* enum test
            Days days = Days.Sunday;
            Console.WriteLine(days + ": {0}", (long)(days));
            */
            /*
            // flags enumeration test
            Days days = Days.Weekend | Days.Saturday;
            Console.WriteLine(days + ": {0}", (int)(days));
            Console.WriteLine(days.HasFlag(Days.Saturday));
            Console.WriteLine(days.HasFlag(Days.Friday));

            
            */
            //structs exercises with Celsius and Fahrenheit conversion
            Fahrenheit f = new Fahrenheit(100.0f);
            Console.WriteLine("{0} fahrenheit = {1} celsius", f.Degrees, (Celsius)f);

            Celsius c = 32f;
            Console.WriteLine("{0}celsius = {1} fahrenheit", c.Degrees, (Fahrenheit)c);
            Fahrenheit f2 = f + (Fahrenheit)c;
            Console.WriteLine("{0}+{1} ={2} fahrenheit", f.Degrees, (Fahrenheit)c, f2.Degrees);
            Fahrenheit f3 = 100f;
            Console.WriteLine("{0} fahrenheit", f3.Degrees);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

    }

}