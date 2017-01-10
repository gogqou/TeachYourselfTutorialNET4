using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesandStructures
{
    struct Fahrenheit
    {
        //field
        private float degrees;
        //property
        public float Degrees
        {
            get
            {
                return this.degrees;
            }
        }
        //constructor
        public Fahrenheit(float temperature)
        {
            this.degrees = temperature;
        }


        public static Fahrenheit operator +(Fahrenheit x, Fahrenheit y)
        {
            return new Fahrenheit(x.Degrees + y.Degrees);
        }
        public static Fahrenheit operator -(Fahrenheit m, Fahrenheit n)
        {
            return new Fahrenheit(m.Degrees - n.Degrees);
        }
        public static implicit operator float(Fahrenheit f)
        {
            return f.Degrees;
        }
        public static implicit operator Fahrenheit(float fl)
        {
            return new Fahrenheit(fl);
        }

        public static implicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((5.0f / 9.0f) * (f.Degrees - 32));
        }
        public override string ToString()
        {
            return this.Degrees.ToString();
        }
    }
}
