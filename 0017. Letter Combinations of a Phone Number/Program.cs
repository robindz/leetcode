using _0017._Letter_Combinations_of_a_Phone_Number;
using Xunit;

var combinations = Solution.LetterCombinations("23");
combinations.Sort();
Assert.Equal(new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }, combinations);

combinations = Solution.LetterCombinations("");
combinations.Sort();
Assert.Equal(new List<string>(), combinations);

combinations = Solution.LetterCombinations("2");
combinations.Sort();
Assert.Equal(new List<string> { "a", "b", "c" }, combinations);

Console.ReadKey();