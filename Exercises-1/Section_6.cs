using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DangBinhAn_31231021006
{
    internal class Section_6
    {
        public static void Main()
        {
            //Question1();
            //Question2();
            Question3();
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
                array[i] = r.Next(0, 101);
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
        static void Question2()
        {
            static int[] bubblesort(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
                return array;
            }
            int[] arrayInt = new int[10];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.Write("Enter the number {0}: ", i + 1);
                arrayInt[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("array that you have entered: ");
            foreach (int i in arrayInt)
                Console.Write(i + " ");

            Console.WriteLine("array after implementing the bubble sort algorithm: ");
            foreach (int i in bubblesort(arrayInt))
            {
                Console.Write(i + " ");
            }
        }
        static void Question3()
        {
            static int linearSearch(string[] sentence, string word)
            {
                for (int index = 0; index < sentence.Length; index++)
                {
                    if (sentence[index] == word)
                    {
                        return index;
                    }
                }
                return -1;
            }
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();
            if (linearSearch(sentence.Split(' '),word) == -1)
            {
                Console.WriteLine($"Word {word} was not found");
            }
            else
                Console.WriteLine($"Word {word} was found in {linearSearch(sentence.Split(' '), word)} index");
        }
    }
    

}
