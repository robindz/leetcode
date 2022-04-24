namespace _0003._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            HashSet<char> seenChars = new HashSet<char>();
            int l = 0;
            int r = 0;
            int length = 0;

            for (; r < s.Length; r++)
            {
                while (seenChars.Contains(s[r]))
                {
                    seenChars.Remove(s[l]);
                    l++;
                }

                seenChars.Add(s[r]);
                length = Math.Max(length, seenChars.Count);
            }

            return length;
        }
    }
}
