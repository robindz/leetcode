using _0010._Regular_Expression_Matching;
using Xunit;

bool isMatch = Solution.IsMatch("aa", "a");
Assert.False(isMatch);

isMatch = Solution.IsMatch("aa", "a*");
Assert.True(isMatch);

isMatch = Solution.IsMatch("ab", ".*");
Assert.True(isMatch);

isMatch = Solution.IsMatch("aab", "c*a*b*");
Assert.True(isMatch);

isMatch = Solution.IsMatch("mississippi", "mis*is*p*.");
Assert.False(isMatch);

isMatch = Solution.IsMatch("ab", ".*c");
Assert.False(isMatch);

isMatch = Solution.IsMatch("aaa", "aaaa");
Assert.False(isMatch);

isMatch = Solution.IsMatch("aab", "c*a*b");
Assert.True(isMatch);

isMatch = Solution.IsMatch("aaa", "a*a");
Assert.True(isMatch);

Console.ReadKey();