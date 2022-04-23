using _7._Reverse_Integer;
using Xunit;

int x = Solution.Reverse(123);
Assert.Equal(x, 321);

x = Solution.Reverse(-123);
Assert.Equal(x, -321);

x = Solution.Reverse(120);
Assert.Equal(x, 21);

x = Solution.Reverse(int.MaxValue);
Assert.Equal(x, 0);

Console.ReadKey();