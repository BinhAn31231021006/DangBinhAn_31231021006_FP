using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1
{
    internal class Section_8
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine("Length of string: " + CountLengthString(s));
            SeparateCharacters(s);
            PrintReverseOrder(s);
            Console.WriteLine("The total number of words in a string: " + CountNumberOfWords(s));
            Console.WriteLine(CompareTwoStrings("Messi", "Ronaldo"));
            CountAlphabetsDigitsSpecial(s);
            CountVowelsOrConsonants(s);
            if (CheckSubstring("Messi", s))
            {
                Console.WriteLine("Checked");
            }
            else Console.WriteLine("Not having");
            Console.WriteLine("the position of a substring within a string: " + searchPosition("goat",s));
            checkAlphabet();
            Console.WriteLine("the number of times a substring appears in a given string: " + CountNumberOfSubstring("Messi",s));
            InsertSubstring(s);
            Console.ReadKey();
        }
   
        static int CountLengthString (string s)
        {
            int length = 0;
            foreach (char c in s) 
            {
                length++;
            }
            return length;
        }
        static void SeparateCharacters(string s)
        {
            foreach (char c  in s) 
            { 
                Console.WriteLine(c);
            }
        }
        static void PrintReverseOrder (string s)
        {
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }
        static int CountNumberOfWords(string s)
        {
            string[] lst = s.Split(' ');
            int count = 0;  
            foreach (string word in lst) 
            { 
                count++;
            }
            return count;
        }
        static int CompareTwoStrings(string s1, string s2)
        {
            int i = 0;
            int min = s1.Length > s2.Length ? s2.Length : s1.Length;
            while ( i < min)
            {
                if (s1[i] > s2[i])
                    return 1;
                else if (s1[i] < s2[i])
                    return -1;
            }
            if (s1.Length > s2.Length) return 1;
            else if (s1.Length < s2.Length) return -1;
            return 0;

        }
        static void CountAlphabetsDigitsSpecial(string s)
        {
            int alphabet = 0, number = 0, special = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    number++;
                }
                else if (char.IsLetter(c))
                {
                    alphabet++;
                }
                else special++;
            }
            Console.WriteLine("Alphabets = " + alphabet);
            Console.WriteLine("Numbers = " + number);
            Console.WriteLine("Special character = " + special);
        }
        static void CountVowelsOrConsonants(string s)
        {
            int countvowel = 0, consonants = 0;
            char[] vowel = ['a', 'e', 'u', 'o', 'i'];
            foreach (char c in s)
            {
                if (vowel.Contains(c))
                {
                    countvowel++;
                }
                else if (char.IsLetter(c))
                {
                    consonants++;
                }    
            }
            Console.WriteLine("vowel = " + countvowel);
            Console.WriteLine("consonants = " + consonants);
        }
        static bool CheckSubstring(string substr, string s)
        { 
            return s.Contains(substr);
        }
        static int searchPosition(string substr, string s)
        {
            int index = s.IndexOf(substr);
            return index;
        }
        static void checkAlphabet()
        {
            Console.Write("Input a character: ");
            char c = char.Parse(Console.ReadLine());    
            if (char.IsLetter(c))
            {
                if(char.IsUpper(c))
                {
                    Console.WriteLine("this character is upper");
                }
                else if (char.IsLower(c))
                {
                    Console.WriteLine("this character is lower");
                }
            }    
        }
        static int CountNumberOfSubstring(string substr, string s) 
        {
            int start = 0, index = -1, count = -1;
            while (start != -1)
            {
                start = s.IndexOf(substr, index + 1);
                count += 1;
                index = start;
            }    
            return count;
        }
        static void InsertSubstring(string s)
        {
            Console.WriteLine("Enter a substring: ");
            string substr = Console.ReadLine();
            int index = s.IndexOf(substr);
            Console.WriteLine("Enter a string to insert: ");
            string insertstring = Console.ReadLine();
            Console.WriteLine(s.Insert(index, insertstring));
        }
            


    }
}
