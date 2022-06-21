using _0020._Valid_Parentheses;
using Xunit;

Assert.True(Solution.IsValid("()"));
Assert.True(Solution.IsValid("()[]{}"));
Assert.False(Solution.IsValid("(]"));
Assert.False(Solution.IsValid("(("));

Console.ReadKey();