using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class InchesToFeet
    {
        static void Main(string[] args)
        {
            Console.Write("Inches- ");
            InchesToFeet(Convert.ToInt32(Console.ReadLine()));
        }
        public static void InchesToFeet(int inches)
        {
            Console.WriteLine(inches + " Inches Is " + inches / 12 + " Feet " + inches % 12 + " Inches");
        }
        public static void FeetToYards()
        {
            InchesToFeet
        }
    }
}