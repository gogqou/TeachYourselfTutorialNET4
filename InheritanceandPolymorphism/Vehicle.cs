using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    public class Vehicle
    {
        private Vehicle() { }
        public Vehicle(int wheels)
        {
            Console.WriteLine("The number of wheels requested is {0}", wheels);
        }
        public virtual void Operate()
        {
            Console.WriteLine("Default");
        }
    }
    public class FourWheeledVehicle : Vehicle
    {
        public FourWheeledVehicle() : base(4) { }
        public sealed override void Operate()
        {
            base.Operate();
            Console.WriteLine("Driving a four wheeled vehicle");
        }

    }

    public class TwoWheeledVehicle : Vehicle
    {
        public TwoWheeledVehicle() : base(2) { }
        public override void Operate()
        {
            base.Operate();
            Console.WriteLine("Driving a two wheeled vehicle");
        }

    }
    public class Car : FourWheeledVehicle { }
    public class Truck : FourWheeledVehicle { }
    public class Motorycle : TwoWheeledVehicle { }
}