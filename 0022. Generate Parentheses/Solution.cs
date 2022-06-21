namespace _0022._Generate_Parentheses
{
    public class Solution
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            char[] parenthesisArray = new char[n * 2];
            Backtrack(result, parenthesisArray, 0, 0, 0, n);
            return result;
        }

        private static void Backtrack(IList<string> result, char[] parenthesisArray, int index, int openCount, int closedCount, int n)
        {
            if (openCount == n && closedCount == n)
            {
                result.Add(new string(parenthesisArray));
                return;
            }

            if (openCount < n)
            {
                parenthesisArray[index] = '(';
                Backtrack(result, parenthesisArray, index + 1, openCount + 1, closedCount, n);
            }

            if (closedCount < openCount)
            {
                parenthesisArray[index] = ')';
                Backtrack(result, parenthesisArray, index + 1, openCount, closedCount + 1, n);
            }
        }
    }
}
