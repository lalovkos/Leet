using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Leet
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumbers = new Dictionary<char, int>
            {
                { 'M', 1000},
                { 'D', 500}, 
                { 'C', 100},
                { 'L', 50}, 
                { 'X', 10}, 
                { 'V', 5}, 
                { 'I', 1}
            };

            int sum = 0;
            var curNumberIndex = romanNumbers.GetEnumerator();

            //Main cycle for string
            foreach (char curChar in s)
            {
                char curNumber = curNumberIndex.Current.Key;
                if (romanNumbers[curNumber] < romanNumbers[curChar])
                {
                    curNumberIndex.MoveNext();
                }
                else
                {
                    
                }

                Console.WriteLine(curChar);
            }

            return sum;
        }
    }
}
