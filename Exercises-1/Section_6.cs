using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangBinhAn_31231021006
{
    internal class Section_6
    {
        public static void Main()
        {
            Question1();
        }
        static void Question1()
        {
            Random r = new Random();
            Console.Write("Enter array's range: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0,101);
                Console.WriteLine(array[i]);
            }
            double average = calculateAverage(array);
            Console.WriteLine("the average value of array elements: " + average);
            Console.Write("Enter a value for checking: ");
            int a = int.Parse(Console.ReadLine());   
        }
        static double calculateAverage(int[] array)
        {
            return array.Length > 0 ? array.Average() : 0;
        }
        static bool checkSpecificValue(int[] array, int value)
        {
            return array.Contains(value);
        }
    }
}
