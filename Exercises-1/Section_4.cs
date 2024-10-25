using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangBinhAn_31231021006
{
    internal class Section_4
    {
        public static void Main()
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question6();
            //Question7();
            //Question8();
            //Question9();
            //Question10();
            //Question11();
            //Question12();
            Question13();

            Console.WriteLine("press any key to escape");
            Console.ReadKey();
        }
        public static void Question1()
        {
            Console.Write("Enter a number: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine($"{numb} is an even number");
            else
                Console.WriteLine($"{numb} is an odd number");
            Console.ReadKey();
        }
        public static void Question2()
        {
            bool check = true;
            while (check)
            {
                Console.Write("Enter the first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Enter the third number: ");
                int c = int.Parse(Console.ReadLine());
                if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Please enter separate number!");
                    check = true;
                }
                else
                {
                    int Max = a;
                    if (b > Max)
                        Max = b;
                    if (c > Max)
                        Max = c;
                    Console.WriteLine("The largest of three numbers is: " + Max);
                    break;
                }
            }
            Console.ReadKey();
        }

        public static void Question3()
        {
            Console.Write("Input the value X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input the value Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                if (y == 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin");
                } 
                else
                    Console.WriteLine($"The coordinate point ({x},{y}) lies at the y-axis");
            }
            if (y == 0 && x != 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the x-axis");
            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant");
            Console.ReadKey();
        }
        public static void Question4()
        {
            while (true)
            {
                Console.Write("Input side 1 of triangle: ");
                int sideA = int.Parse(Console.ReadLine());
                Console.Write("Input side 2 of triangle: ");
                int sideB = int.Parse(Console.ReadLine());
                Console.Write("Input side 3 of triangle: ");
                int sideC = int.Parse(Console.ReadLine());
                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    if (sideA == sideB && sideB == sideC)
                        Console.WriteLine("This is an equilateral triangle");
                    else if (sideA == sideB || sideB == sideC || sideA == sideC)
                        Console.WriteLine("This is an isosceles triangle");
                    else
                        Console.WriteLine("This is a scalene triangle");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input the value again");
                }
            }
            Console.ReadKey();
        }
        public static void Question5()
        {
            int sum = 0;
            Console.WriteLine("Input the 10 numbers: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number {i}: ");
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            float avg = (float)sum / 10;
            Console.WriteLine("The sum of 10 numbers is : {0}\nThe Average is : {1}", sum, avg);
            Console.ReadKey();
        }
        public static void Question6()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                float result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }
            Console.ReadKey();
        }
        public static void Question7()
        {
            Console.WriteLine("Enter the pattern number that you want to see (1, 2, 3): ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Insert the rows: ");
                    int rows = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int k = 1;
                    Console.Write("Insert the rows: ");
                    int row1s = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= row1s; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{k} ");
                            k++;
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    int k1 = 1;
                    Console.Write("Insert the rows: ");
                    int row2s = int.Parse(Console.ReadLine());
                    int space = row2s + 4 - 1;
                    for (int i = 1; i <= row2s; i++)
                    {
                        for (int spc = space; spc >= 1; spc--)
                            Console.Write(" ");
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{k1} ");
                            k1++;
                        }
                        Console.WriteLine();
                        space--;
                    }
                    break;
            }          
            Console.ReadKey(); 

        }
        public static void Question8()
        {
            float s = 0;
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write($"1/{i} + ");
                    s += (float)1 / i;
                }
                else if (i == n)
                {
                    Console.Write($"1/{i}");
                    s += (float)1 / i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the series upto {0} terms: {1}", n, s);
            Console.ReadKey();
        }
        public static void Question9()
        {
            Console.Write("Insert the start of the range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Insert the end of the range: ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int kq = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        kq += j;
                }
                if (i == kq)
                    Console.WriteLine("{0} is the perfect number", i);
            }
            Console.ReadKey();
        }
        public static void Question10()
        {
            int demUoc = 0;
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    demUoc++;
            }
            if (demUoc == 2)
                Console.WriteLine($"{n} is a prime number");
            else
                Console.WriteLine($"{n} is not a prime number");
            Console.ReadKey();
        }
        public static void Question11()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y*y + 2*y + 1;
                Console.WriteLine("Certain value of function x when y = {0} la: {1}",y,x);
            }
            Console.ReadKey();
        }
        public static void Question12()
        {
            float distance;
            float hour, min, sec;
            float timeSec;
            float mps;
            float kph, mph;
            Console.Write("Input distance (metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());
            timeSec = (hour * 3600) + (min * 60) + sec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
            Console.ReadKey();
        }
        public static void Question13() 
        {
            /*Console.Write("Input the character: ");
            if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i'|| c == 'A' || c == 'E' || c == 'O' || c == 'U' || c == 'I')
            {
                Console.WriteLine("The character you insert is vowel");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("The character you insert is digit");
            }
            else
                Console.WriteLine("The character you insert is other symbol"); */
            Random r = new Random();  
            int comp_number = r.Next(1,101);
            int count = 0;
            do
            {
                Console.WriteLine(comp_number);
                do
                {
                    count++;
                    Console.WriteLine("Moi nhap so ban doan: ");
                    int n = int.Parse(Console.ReadLine());
                    if (comp_number == n)
                    {
                        Console.WriteLine("ban dung roi");
                        break;
                    }
                    if (comp_number > n)
                    {
                        Console.WriteLine("so ban nghi nho hon so may nghi");
                    }
                    if (comp_number < n)
                    {
                        Console.WriteLine("so ban nghi nhieu hon so may nghi");
                    }
                }
                while (true);
                Console.WriteLine("ban da doan dung sau {0} lan", count);
                Console.WriteLine();
                Console.WriteLine("Ban co muon choi tiep khong (co/khong): ");
                string answer = Console.ReadLine();
                if (answer == "khong")
                {
                    Console.WriteLine("bye bye, see you");
                    break;
                }               
            }
            while (true);
 
            Console.ReadKey(); 
        }
    }
}
