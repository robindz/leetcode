using System.Text;

namespace _0012._Integer_to_Roman
{
    public class Solution
    {
        public static string IntToRoman(int num)
        {
            if (num < 0 || num > 3999) return string.Empty;

            StringBuilder sb = new StringBuilder();
            string[] romanCharacters = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] numericValues = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            int i = 0;
            while (num > 0)
            {
                while (num >= numericValues[i])
                {
                    sb.Append(romanCharacters[i]);
                    num -= numericValues[i];
                }
                i++;
            }

            return sb.ToString();
        }
    }
}
