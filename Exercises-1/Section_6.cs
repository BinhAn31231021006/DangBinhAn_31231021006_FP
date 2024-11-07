using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
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
            //int[] array5 = { 1, 2, 3, 3, 5, 6, 7, 7, 8, 9, 9 };
            Random r = new Random();
            Console.Write("Enter array's range: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0,101);
                Console.Write(array[i] + " ");
            }
            
            Console.WriteLine();
            double average = calculateAverage(array);
            Console.WriteLine("the average value of array elements: " + average);

            Console.Write("Enter a value for checking: ");
            int a = int.Parse(Console.ReadLine());
            bool kq = checkSpecificValue(array, a);
            Console.WriteLine("Does the array contain {0}?: {1}", a, kq);

            Console.Write("Enter an element for finding index: ");
            int b = int.Parse(Console.ReadLine());
            int kq1 = findIndex(array, b);
            Console.WriteLine("The index of {0} is {1}", b, kq1);

            Console.Write("Enter an element for removing: ");
            int c = int.Parse(Console.ReadLine());
            int[] array2 = removeSpecificElement(array, c);
            Console.WriteLine("The array after removing a specific element: ");
            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The maximum value of array: " + findMax(array));

            Console.WriteLine("The minimum value of array: " + findMin(array));

            int[] array3 = reverseArray(array);
            Console.WriteLine("The array after reversing: ");
            foreach (int i in array3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            if (findDuplicateValues(array).ToArray().Length > 0)
            {
                Console.WriteLine("The duplicate values in an array: ");
                foreach (int i in findDuplicateValues(array))
                {
                    Console.Write(i + " ");
                }
            } 
            else
                Console.WriteLine("The duplicate values in an array: 0");

            int[] array4 = removeDuplicateElements(array);
            Console.WriteLine("The array after removing the duplicate values: ");
            foreach (int i in array4)
            {
                Console.Write(i + " ");
            }

        }

        static double calculateAverage(int[] array)
        {
            return array.Length > 0 ? array.Average() : 0;
        }
        static bool checkSpecificValue(int[] array, int value)
        {
            return array.Contains(value);
        }
        static int findIndex(int[] array, int element)
        {
            return Array.IndexOf(array, element);
        }
        static int[] removeSpecificElement(int[] array, int value)
        {
            List<int> lst = new List<int>();
            foreach (int i in array)
            {
                if (i != value)
                {
                    lst.Add(i);
                }
            }    
            return lst.ToArray();
        }
        static int findMax(int[] array)
        {
            return array.Max();
        }
        static int findMin(int[] array)
        {
            return array.Min();
        }
        static int[] reverseArray(int[] array)
        {
            return array.Reverse().ToArray();
        }
        static List<int> findDuplicateValues(int[] array)
        {
            List<int> duplicate = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j] && !duplicate.Contains(array[i]))
                    {
                        duplicate.Add(array[i]);
                        break;
                    }    
                }    
            }    
            return duplicate;
        }
        static int[] removeDuplicateElements(int[] array)
        {
            return array.Distinct().ToArray();
        }
    }
}
