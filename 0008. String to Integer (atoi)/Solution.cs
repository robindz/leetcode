using System.Text;

namespace _0008._String_to_Integer__atoi_
{
    public class Solution
    {
        public static int MyAtoi(string s)
        {
            if (s.Length == 0) return 0;

            bool findingNumbers = true;
            int sign = 1, i = 0;
            StringBuilder sb = new();

            // Skip past the whitespace.
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            // If the entire string was read, return 0.
            if (i == s.Length) return 0;

            // Check if the first character is indicative of a sign.
            char c = s[i];
            if (c == '-')
            {
                sign = -1;
                i++;
            }
            else if (c == '+')
            {
                i++;
            }

            // Loop through the remaining string until a non number character is found,
            // or until we reach the end of the string.
            while (i < s.Length && findingNumbers)
            {
                if (s[i] >= 48 && s[i] <= 59)
                    sb.Append(s[i++]);
                else
                    findingNumbers = false;
            }

            if (sb.Length == 0) return 0;

            // Try to convert the string to a number. The string only contains numbers,
            // so if the conversion fails, it means the number represented by the string
            // is too big to store in a 32-bit integer, so we then cap this value to
            // 2^31 or -2^31-1 based on the sign of the number.
            bool parsed = int.TryParse(sb.ToString(), out int result);
            if (parsed) return sign * result;
            else return sign == 1 ? int.MaxValue : int.MinValue;
        }
    }
}
