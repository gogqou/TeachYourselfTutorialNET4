using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypesandStructures
{
    struct Celsius
    {
        private float degrees;
        public float Degrees
        {
            get
            {
                return this.degrees;
            }
        }
        // ****************//************** METHODS/****************************//**********/
        public Celsius(float temperature)
        {
            this.degrees = temperature;
        }
        public static Celsius operator +(Celsius x, Celsius y)
        {
            return new Celsius(x.Degrees + y.Degrees);
        }
        public static Celsius operator -(Celsius m, Celsius n)
        {
            return new Celsius(m.Degrees - n.Degrees);
        }
        public static implicit operator float(Celsius c)
        {
            return c.Degrees;
        }
        public static implicit operator Celsius(float f)
        {
            return new Celsius(f);
        }
        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((9.0f / 5.0f) * c.Degrees + 32);
        }
        public override string ToString()
        {
            return this.Degrees.ToString();
        }

    }
}

