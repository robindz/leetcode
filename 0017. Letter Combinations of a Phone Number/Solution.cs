using System.Text;

namespace _0017._Letter_Combinations_of_a_Phone_Number
{
    public class Solution
    {
        public static List<string> LetterCombinations(string digits)
        {
            // Use a FIFO queue
            Queue<string> combinations = new Queue<string>();
            if (digits.Length == 0) return new List<string>();

            string[] map = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            combinations.Enqueue(string.Empty);

            for (int i = 0; i < digits.Length; i++)
            {
                int mapIndex = digits[i] - '0' - 2;
                int count = combinations.Count; // Number of nodes already in the queue       
                for (int k = 0; k < count; k++)
                {
                    string partialCombination = combinations.Dequeue();
                    foreach (char c in map[mapIndex])
                        combinations.Enqueue(partialCombination + c);
                }
            }

            return combinations.ToList();
        }
    }
}
