using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private double meter;
        private double kg;
        private double bmi;

        public double Meter
        {
            get
            {
                return this.meter;
            }

            set
            {
                this.meter = value;
            }
        }
        public double Kg
        {
            get
            {
                return this.kg;
            }

            set
            {
                this.kg = value;
            }
        }
        public double Bmi
        {
            get
            {
                return this.bmi;
            }

            set
            {
                this.bmi = value;
            }
        }


        static void Main(string[] args)
        {
           
            double meter,kg,BMI;

            Console.WriteLine("Enter height");
            meter = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter weight");
            kg = Convert.ToSingle(Console.ReadLine());
            BMI = kg / meter;
            if (BMI < 18.5) { Console.WriteLine("overweight"); }
            else if (BMI >= 25) { Console.WriteLine("healthy"); }


        }
    }
}
