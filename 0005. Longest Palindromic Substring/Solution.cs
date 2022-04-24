using System.Text;

namespace _0005._Longest_Palindromic_Substring
{
    public class Solution
    {
        // Implementation of Manacher's algorithm https://en.wikipedia.org/wiki/Longest_palindromic_substring#Manacher's_algorithm
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1) return s;

            StringBuilder sb = new("|");
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
                sb.Append('|');
            }

            string sComplement = sb.ToString();
            sb.Clear();

            int[] palindromeRadii = new int[sComplement.Length];

            int center = 0, radius = 0;

            while (center < sComplement.Length)
            {
                while (center - radius - 1 >= 0 && 
                       center + radius + 1 < sComplement.Length && 
                       sComplement[center - radius - 1] == sComplement[center + radius + 1])
                {
                    radius++;
                }

                palindromeRadii[center] = radius;

                int oldCenter = center, oldRadius = radius;
                center++;
                radius = 0;

                while (center <= oldCenter + oldRadius)
                {
                    int mirroredCenter = oldCenter - (center - oldCenter);
                    int maxMirroredRadius = oldCenter + oldRadius - center;
                    
                    if (palindromeRadii[mirroredCenter] < maxMirroredRadius)
                    {
                        palindromeRadii[center] = palindromeRadii[mirroredCenter];
                        center++;
                    }
                    else if (palindromeRadii[mirroredCenter] > maxMirroredRadius)
                    {
                        palindromeRadii[center] = maxMirroredRadius;
                        center++;
                    }
                    else
                    {
                        radius = maxMirroredRadius;
                        break;
                    }
                }
            }

            // End of Manacher's algorithm.

            // Find index in complement string with the highest radius.
            int maxPalindromeRadiusIndex = 0;
            int maxPalindromeRadius = 0;
            for (int i = 0; i < palindromeRadii.Length; i++)
            {
                if (palindromeRadii[i] > maxPalindromeRadius)
                {
                    maxPalindromeRadiusIndex = i;
                    maxPalindromeRadius = palindromeRadii[maxPalindromeRadiusIndex];
                }
            }

            // Calculate the start and end index in the original string based on
            // the radius of the biggest palindrome and its center index.
            if (maxPalindromeRadius % 2 == 1)
            {
                // Palindrome length is uneven.
                int startIndex = maxPalindromeRadiusIndex / 2 - maxPalindromeRadius / 2;
                int endIndex = maxPalindromeRadiusIndex / 2 + maxPalindromeRadius / 2 + 1;
                return s[startIndex..endIndex];
            }
            else
            {
                // Palindrome length is even.
                int startIndex = maxPalindromeRadiusIndex / 2 - maxPalindromeRadius / 2;
                int endIndex = maxPalindromeRadiusIndex / 2 + maxPalindromeRadius / 2;
                return s[startIndex..endIndex];
            }
        }
    }
}
