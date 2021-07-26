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

            foreach(char c in str2)
            {
                if (dict.ContainsKey())
                {

                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
