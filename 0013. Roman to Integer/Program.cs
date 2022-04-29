using _0013._Roman_to_Integer;
using Xunit;

var number = Solution.RomanToInt("III");
Assert.Equal(3, number);

number = Solution.RomanToInt("LVIII");
Assert.Equal(58, number);

number = Solution.RomanToInt("MCMXCIV");
Assert.Equal(1994, number);

number = Solution.RomanToInt("DCXXI");
Assert.Equal(621, number);

Console.ReadKey();