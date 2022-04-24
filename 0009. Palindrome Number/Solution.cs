namespace _0009._Palindrome_Number
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int reversed = 0, remainder, original = x;
            while (x != 0)
            {
                remainder = x % 10;
                reversed = reversed * 10 + remainder;
                x /= 10;
            }

            return reversed == original;
        }
    }
}
