using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangBinhAn_31231021006
{
    internal class Section_5
    {
        public static void Main6()
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4_1();
            //Question4_2();
            //Question5();
            //Question6();
            Console.WriteLine("press any key to escape");
            Console.ReadKey();
        }

        public static void Question1()
        {
            static int Max(int a, int b, int c)
            {
                int max = a;
                if (b > max)
                {
                    max = b;
                }
                if (c > max)
                {
                    max = c;
                }
                return max;
            }
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = int.Parse(Console.ReadLine());
            int max = Max(x, y, z);
            Console.WriteLine("The maximum number is: " + max);

        }

        public static void Question2()
        {
            static float calculatingFactorial(int n)
            {
                int demSo = 1;
                for (int i = 1; i <= n; i++)
                {
                    demSo *= i;
                }
                return demSo;
            }
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            float factorial = calculatingFactorial(n);
            Console.WriteLine("the factorial of number {0}: {1}", n, factorial);

        }

        public static void Question3()
        {
            static int checkingPrimeNumber(int n)
            {
                int demUoc = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        demUoc++;
                }
                return demUoc;
            }
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int demUoc = checkingPrimeNumber(n);
            if (demUoc == 2)
                Console.WriteLine($"{n} is a prime number");
            else
                Console.WriteLine($"{n} is not a prime number");

        }
        public static void Question4_1()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime numbers less than {n}:");
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i) == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static int IsPrime(int number)
        {
            int value;
            int demUoc = 0;
            for (int j = 1; j <= number; j++)
            {
                if (number % j == 0)
                    demUoc++;
            }
            if (demUoc == 2)
            {
                value = 1;
            }
            else value = 0;
            return value;
        }

        static void Question4_2()
        {
            static void NPrimeNumber(int N)
            {
                int c = 0;
                for (int i = 2; c < N; i++)
                {
                    if (IsPrime(i) == 1)
                    {
                        Console.Write(i + " ");
                        c++;
                    }
                }
            }
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            NPrimeNumber(N);
        }

        static void Question5()
        {
            static int checkingPerfectNumber(int n)
            {
                int value = 0;
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                }
                if (tong == n)
                    value = 1;
                else value = 0;
                return value;
            }
            static void printingPerfectNumber()
            {
                for (int i = 1; i < 1000; i++)
                {
                    if (checkingPerfectNumber(i) == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int value = checkingPerfectNumber(n);
            if (value == 1)
            {
                Console.WriteLine($"{n} is a perfect number");
            }
            else
                Console.WriteLine($"{n} is not a perfect number");
            Console.WriteLine("all perfect number that less than 1000: ");
            printingPerfectNumber();
            Console.WriteLine();
        }
      
        static void Question6()
        {
            static bool checkPangram(string str)
            {
                bool[] alphabet = new bool[26];
                int index = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if ('A' <= str[i] && str[i] <= 'Z')
                        index = str[i] - 'A';
                    else if ('a' <= str[i] && str[i] <= 'z')
                        index = str[i] - 'a';
                    else
                        continue;
                    alphabet[index] = true;
                }
                for (int i = 0; i <= 25; i++)
                {
                    if (alphabet[i] == false)
                        return false;
                }
                return true;
            }
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();
            if (checkPangram(str) == true)
                Console.WriteLine("{0} is a pangram", str);
            else
                Console.WriteLine("{0} is not a pangram", str);
        }
    }
}
