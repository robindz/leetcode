using _6._Zigzag_Conversion;
using Xunit;

string result = Solution.Convert("PAYPALISHIRING", 3);
Assert.Equal("PAHNAPLSIIGYIR", result);

result = Solution.Convert("PAYPALISHIRING", 4);
Assert.Equal("PINALSIGYAHRPI", result);

Console.ReadKey();