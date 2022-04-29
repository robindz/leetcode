using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0013._Roman_to_Integer
{
    public class Solution
    {
        public static int RomanToInt(string s)
        {
            int num = 0;
            int previousNumber = 0;
            Dictionary<char, int> romanNumerals = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                if (romanNumerals[c] >= previousNumber)
                {
                    num += romanNumerals[c];
                }
                else
                {
                    num -= romanNumerals[c];
                }
                previousNumber = romanNumerals[c];
            }

            return num;
        }
    }
}
