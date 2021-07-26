using System;
using System.Collections.Generic;

namespace Two_Strings
{
    class Program
    {
        /*
         * Given two strings, determine if they share a common substring. A substring may be as small as one character.
         */

        /*
             * Complete the 'twoStrings' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts following parameters:
             *  1. STRING s1
             *  2. STRING s2
        */

        public static string twoStrings(string s1, string s2)
        {
            char[] str1 = s1.ToCharArray();

            char[] str2 = s2.ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char c in str1)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);

                }
                else
                {
                    dict[c]++;
                }
            }

            foreach (char c in str2)
            {
                if (dict.ContainsKey(c))
                {
                    return "YES";
                }
                    
            }

            return "NO";

        }
        static void Main(string[] args)
        {
            Console.WriteLine("///////Given two strings, determine if they share a common substring. A substring may be as small as one character.////////// \n");

            string str1 = "hello";

            string str2 = "World";

            Console.WriteLine("String 1: " + str1);

            Console.WriteLine("String 2: " + str2);

            string result = twoStrings(str1, str2);

            Console.WriteLine("Do they share common substring? : {0}", result);

            Console.ReadLine();
        }
    }
}
