using _0003._Longest_Substring_Without_Repeating_Characters;
using Xunit;

string s = "abcabcbb";
int length = Solution.LengthOfLongestSubstring(s);
Assert.Equal(3, length);

s = "bbbbb";
length = Solution.LengthOfLongestSubstring(s);
Assert.Equal(1, length);

s = "pwwkew";
length = Solution.LengthOfLongestSubstring(s);
Assert.Equal(3, length);

s = "ctnhk";
length = Solution.LengthOfLongestSubstring(s);
Assert.Equal(5, length);

Console.ReadKey();