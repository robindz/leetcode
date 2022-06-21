using _0022._Generate_Parentheses;
using Xunit;

var result = Solution.GenerateParenthesis(1);
Assert.Equal(result.Count, 1);
Assert.Equal(result[0], "()");

result = Solution.GenerateParenthesis(3);
Assert.Equal(result.Count, 5);
Assert.Equal(result[0], "((()))");
Assert.Equal(result[1], "(()())");
Assert.Equal(result[2], "(())()");
Assert.Equal(result[3], "()(())");
Assert.Equal(result[4], "()()()");

Console.ReadKey();