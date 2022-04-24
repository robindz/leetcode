using System.Text;

namespace _0006._Zigzag_Conversion
{
    public class Solution
    {
        /*
         * n=numRows
         * Δ=2n-2    1                           2n-1                         4n-3
         * Δ=        2                     2n-2  2n                    4n-4   4n-2
         * Δ=        3               2n-3        2n+1              4n-5       .
         * Δ=        .           .               .               .            .
         * Δ=        .       n+2                 .           3n               .
         * Δ=        n-1 n+1                     3n-3    3n-1                 5n-5
         * Δ=2n-2    n                           3n-2                         5n-4
        */

        public static string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            int i;
            StringBuilder[] builders = new StringBuilder[numRows];
            for (i = 0; i < builders.Length; i++) builders[i] = new StringBuilder();

            i = 0;
            while (i < s.Length)
            {
                for (int j = 0; j < numRows && i < s.Length; j++)       // Build string vertically downwards.
                    builders[j].Append(s[i++]);
                for (int j = numRows - 2; j > 0 && i < s.Length; j--)   // Build string diagonally to the top right.
                    builders[j].Append(s[i++]);
            }

            for (i = 1; i < builders.Length; i++)
                builders[0].Append(builders[i]);

            return builders[0].ToString();
        }
    }
}
