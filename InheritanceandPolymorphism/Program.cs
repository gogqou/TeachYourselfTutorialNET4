using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Operate();
            Truck t1 = new Truck();
            t1.Operate();
            Motorycle m1 = new Motorycle();
            m1.Operate();
            Vehicle v1 = new Vehicle(3);
            v1.Operate();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
