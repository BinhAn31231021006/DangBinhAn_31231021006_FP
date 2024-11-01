using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangBinhAn_31231021006
{
    internal class Section_5
    {
        public static void Main()
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4_1();
            Question4_2();
            Console.WriteLine("press any key to escape");
            Console.ReadKey();
        }
        public static void Question1()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = int.Parse(Console.ReadLine());
            int max = Max(x, y, z);
            Console.WriteLine("The maximum number is: " + max);

        }
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
        public static void Question2()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            float factorial = calculatingFactorial(n);
            Console.WriteLine("the factorial of number {0}: {1}", n, factorial);

        }
        static float calculatingFactorial(int n)
        {
            int demSo = 1;
            for (int i = 1; i <= n; i++)
            {
                demSo *= i;
            }
            return demSo;
        }
        public static void Question3()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int demUoc = checkingPrimeNumber(n);
            if (demUoc == 2)
                Console.WriteLine($"{n} is a prime number");
            else
                Console.WriteLine($"{n} is not a prime number");

        }
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
    }
}
