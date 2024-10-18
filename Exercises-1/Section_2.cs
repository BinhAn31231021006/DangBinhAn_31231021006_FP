using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace DangBinhAn_31231021006
{
    internal class Section_2
    {
        public static void Main1()
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
            Question10();

            Console.WriteLine("press any key to escape");
            Console.ReadKey();
        }
        public static void Question1()
        {
            Console.Write("Moi nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap b: ");
            int b = int.Parse(Console.ReadLine());
            int tong = a + b;
            int tich = a * b;
            Console.WriteLine($"{a} + {b} = {tong}");
            Console.WriteLine($"{a} * {b} = {tich}");
            Console.ReadKey();
        }
        public static void Question2()
        {
            int a = 15, b = 16;
            Console.WriteLine("So a va b truoc khi doi la: a = {0}, b = {1}",a,b);
            (a, b) = (b, a);
            Console.WriteLine("So a va b sau khi doi la: a = {0}, b = {1}",a,b);
            Console.ReadKey();
        }
        public static void Question3()
        {
            float a = 10.15f;
            float b = 15.25f;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            float kq = a * b;
            Console.WriteLine("a * b = " + kq);
            Console.ReadKey();
        }
        public static void Question4()
        {
            Console.WriteLine("Nhap feet: ");
            float feet = float.Parse(Console.ReadLine());
            double doi = feet * 0.3048;
            Console.WriteLine("{0} feet = {1} meters", feet, doi);
            Console.ReadKey();
        }
        public static void Question5()
        {
            Console.Write("nhap do C: ");
            float C = float.Parse(Console.ReadLine());
            float doi = (C * 9 / 5) + 32;
            Console.WriteLine($"{C} do C = {doi} do F");
            Console.Write("nhap do F: ");
            float F = float.Parse(Console.ReadLine());
            float doi1 = (F - 32) * 5 / 9;
            Console.WriteLine($"{F} do F = {doi1} do C");
            Console.ReadKey();
        }
        public static void Question6()
        {
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of deciaml: " + sizeof(decimal));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of short: " + sizeof(short));

        }
        public static void Question7()
        {
            Console.WriteLine("Input the character: ");
            char character = char.Parse(Console.ReadLine());
            int ASCII = (int)character;
            Console.WriteLine("ASCII value: " + ASCII);

        }
        public static void Question8()
        {
            Console.Write("Nhap ban kinh (r): ");
            float r = float.Parse(Console.ReadLine());
            double S = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("Dien tich duong tron: " + S);
            Console.ReadKey();
        }
        public static void Question9()
        {
            Console.Write("Nhap canh hinh vuong: ");
            float a = float.Parse(Console.ReadLine());
            float S = a * a;
            Console.WriteLine("Dien tich hinh vuong la: " + S);
            Console.ReadKey();
        }
        public static void Question10()
        {
            Console.Write("Nhap so ngay: ");
            int numbDays = int.Parse(Console.ReadLine());
            int year = numbDays / 365;
            int week = (numbDays % 365) / 7;
            int day = (numbDays % 365) % 7;
            Console.WriteLine($"kq: {year} nam {week} tuan {day} ngay ");
        }

    }
}