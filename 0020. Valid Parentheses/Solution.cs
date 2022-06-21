namespace _0020._Valid_Parentheses
{
    public class Solution
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '[')
                    stack.Push(']');
                else if (c == '{')
                    stack.Push('}');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }

            return stack.Count == 0;
        }
    }
}
