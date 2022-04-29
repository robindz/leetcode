using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0014._Longest_Common_Prefix
{
    public class Solution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0 || strs.Any(x => x.Length == 0)) 
                return string.Empty;

            StringBuilder sb = new();
            int searchLength = int.MaxValue;

            // Find shortest string length.
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < searchLength)
                    searchLength = strs[i].Length;
            }

            // Append to result until mismatch.
            for (int i = 0; i < searchLength; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (c != strs[j][i]) return sb.ToString();
                }
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
