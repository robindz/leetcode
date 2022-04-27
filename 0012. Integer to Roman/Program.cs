using _0012._Integer_to_Roman;
using Xunit;

string roman = Solution.IntToRoman(3);
Assert.Equal("III", roman);

roman = Solution.IntToRoman(58);
Assert.Equal("LVIII", roman);

roman = Solution.IntToRoman(1994);
Assert.Equal("MCMXCIV", roman);

Console.ReadKey();