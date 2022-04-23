using System.Text;

namespace _7._Reverse_Integer
{
    public class Solution
    {
        public static int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                // Get the last number from the original integer.
                int tail = x % 10;

                // Append the last number of the original integer to the new integer.
                int temp = result * 10 + tail;

                // Check for overflow, this happens if, after appending the last number
                // of the original integer to the new integer, the reverse operation
                // does not yield te same result.
                //
                // Basic arithmetic:
                // temp = result * 10 + tail
                // temp - tail = result * 10
                // (temp - tail) / 10 = result
                if ((temp - tail) / 10 != result)
                    return 0;

                // Save the new number.
                result = temp;

                // Remove the last number of the original integer.
                x /= 10;
            }

            return result;
        }
    }
}
