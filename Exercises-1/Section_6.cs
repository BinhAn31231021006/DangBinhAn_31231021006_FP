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
            //Question3();
            //Question4();
            //Question5();
            Question6();
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
            if (linearSearch(sentence.Split(' '), word) == -1)
            {
                Console.WriteLine($"Word {word} was not found");
            }
            else
                Console.WriteLine($"Word {word} was found in {linearSearch(sentence.Split(' '), word)} index");
        }
        static void Question4()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[5] { 1, 1, 1, 1, 1 };
            jaggedArray[1] = new int[2] { 2, 2 };
            jaggedArray[2] = new int[4] { 3, 3, 3, 3 };
            jaggedArray[3] = new int[2] { 4, 4 };
            Console.WriteLine("Jagged Array: ");
            foreach (int[] rows in jaggedArray)
            {
                foreach (int value in rows)
                    Console.Write(value + " ");
                Console.WriteLine();
            }
        }
        static void Question5()
        {
            Console.Write("Enter the rows for jagged array: ");
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.Write("Enter the columns for row {0}: ", i+1);
                int columns = int.Parse(Console.ReadLine());  
                jaggedArray[i] = new int[columns];
            }
            Console.WriteLine();
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Enter values for row {i + 1}:");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Enter value {j + 1}: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                foreach (int value in jaggedArray[i])
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //largestInRows(jaggedArray);
            Console.WriteLine();
            //largestInArray(jaggedArray);
            Console.WriteLine();
            //sortEachRow(jaggedArray);
            Console.WriteLine();
            //isPrime(jaggedArray);
            Console.WriteLine();
            searchPositions(jaggedArray);
        }
        static void largestInRows(int[][] jaggedArray)
        {
            Console.WriteLine("Largest number in each row: ");
            for (int i = 0; i < jaggedArray.Length;i++)
            {
                int MaxInRows = int.MinValue;
                foreach (int value in jaggedArray[i])
                {
                    if (value > MaxInRows)
                        MaxInRows = value;
                }
                Console.WriteLine($"Max value in Row {i+1}: {MaxInRows}");
            }    
        }
        static void largestInArray(int[][] jaggedArray)
        {
            int MaxInArray = int.MinValue;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                foreach (int value in jaggedArray[i])
                {
                    if (value > MaxInArray)
                        MaxInArray = value;
                }
            }
            Console.WriteLine($"Max value in array: {MaxInArray}");
        }
        static void sortEachRow(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Sort(jaggedArray[i]);
                foreach (int value in jaggedArray[i])
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }
        static void isPrime(int[][] jaggedArray)
        {
            List<int> lst = new List<int>(); 
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                foreach (int value in jaggedArray[i])
                {
                    int demUoc = 0;
                    for (int j = 2; j <= value; j++)
                    {
                        if (value % j == 0)
                            demUoc++;
                    }
                    if (demUoc == 1)
                        lst.Add(value);
                }
            }
            Console.WriteLine("items of the array that are prime: ");
            foreach (int i  in lst)
                Console.Write(i + " ");
        }
        static void searchPositions(int[][] jaggedArray)
        {
            Console.Write("Enter the number to search position in array: ");
            int SearchValue = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0;  j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == SearchValue)
                    {
                        Console.WriteLine($"Found at row {i+1}, column {j+1}");
                        found = true;
                    }    
                }    
            }
            if (!found)
                Console.WriteLine("number not found in the array!");
        }
        static void Question6()
        {
            static void NhapMangBangCom(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Enter element number {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            static void InMang(int[] array)
            {
                Console.WriteLine("Array: ");
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
            }
            static void IncreaseArray(int[] array, int val)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += val;
                }
            }
            static int SumArray(int[] array)
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum += i;
                }
                return sum;
            }
            static int MinArray(int[] array)
            {
                Array.Sort(array);
                return array[0];
            }
            static int MaxArray(int[] array)
            {
                Array.Sort(array);
                return array[array.Length - 1];
            }
            static double AverageArray(int[] array)
            {
                return array.Average();
            }
            Console.Write("Enter the number of elements for array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            NhapMangBangCom(array);
            InMang(array);
            IncreaseArray(array, 2);
            Console.WriteLine();
            InMang(array);
            Console.WriteLine();
            Console.WriteLine("Sum of array: " + SumArray(array));
            Console.WriteLine("Max of array: " + MaxArray(array));
            Console.WriteLine("Min of array: " + MinArray(array));
            Console.WriteLine("Average of array: " + AverageArray(array));

        }
        static void Question7()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
        }
    }

}
