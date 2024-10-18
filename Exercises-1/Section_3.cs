using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangBinhAn_31231021006
{
    internal class Section_3
    {
        public static void Main()
        {
            //Question1();
            //Question2();
            Question3();
            Console.WriteLine("press any key to escape");
            Console.ReadKey();
        }

        /// <summary>
        /// Convert from Celsius to Kelvin and Fahrenheit
        /// </summary>
        public static void Question1()
        {
            Console.Write("Enter Celsius: ");
            float Cel = float.Parse(Console.ReadLine());
            float Kel = Cel + 273;
            float fah = (Cel * 18 / 10) + 32;
            Console.WriteLine("Kelvin = " + Kel);
            Console.WriteLine("Fahrenheit = " + fah);
            Console.ReadKey();

        }
        /// <summary>
        /// Inpur Radius for calculating surface and volume
        /// </summary>
        public static void Question2()
        {
            Console.Write("Enter Radius: ");
            float r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("surface = " + surface);
            Console.WriteLine("volume = " + volume);
            Console.ReadKey();
        }
        /// <summary>
        /// Input a and b for calculating adding, subtracting,  multiplying and dividing 
        /// </summary>
        public static void Question3()
        {
            Console.Write("Enter a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            float b = float.Parse(Console.ReadLine());
            float sum = a + b;
            float minus = a - b;
            double multiplying = a * b;
            double dividing = a / b;
            float mod = a % b;
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {minus}");
            Console.WriteLine($"{a} x {b} = {multiplying}");
            Console.WriteLine($"{a} / {b} = {dividing}");
            Console.WriteLine($"{a} mod {b} = {mod}");
            Console.ReadKey();


        }
    }
}
