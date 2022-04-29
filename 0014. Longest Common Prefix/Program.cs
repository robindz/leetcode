using _0014._Longest_Common_Prefix;
using Xunit;

string[] words = new string[] { "flower", "flow", "flight" };
string prefix = Solution.LongestCommonPrefix(words);
Assert.Equal("fl", prefix);

words = new string[] { "dog", "racecar", "car" };
prefix = Solution.LongestCommonPrefix(words);
Assert.Equal(string.Empty, prefix);

Console.ReadKey();
