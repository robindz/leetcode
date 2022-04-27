namespace _0010._Regular_Expression_Matching
{
    public class Solution
    {
        public static bool IsMatch(string s, string p)
        {
            bool[,] memory = new bool[s.Length + 1, p.Length + 1];
            memory[s.Length, p.Length] = true;

            for (int i = s.Length; i >= 0; i--)
            {
                for (int j = p.Length - 1; j >= 0; j--)
                {
                    bool matches = i < s.Length && (p[j] == s[i] || p[j] == '.');
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        memory[i, j] = memory[i, j + 2] || matches && memory[i + 1, j];
                    }
                    else
                    {
                        memory[i, j] = matches && memory[i + 1, j + 1];
                    }
                }
            }

            return memory[0, 0];
        }
    }
}
