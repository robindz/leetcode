using _0018._4Sum;
using Xunit;

var sums = Solution.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
Assert.Equal(new int[] { -2, -1, 1, 2 }, sums[0]);
Assert.Equal(new int[] { -2, 0, 0, 2 }, sums[1]);
Assert.Equal(new int[] { -1, 0, 0, 1 }, sums[2]);

sums = Solution.FourSum(new int[] { 2, 2, 2, 2, 2 }, 8);
Assert.Equal(new int[] { 2, 2, 2, 2 }, sums[0]);

Console.ReadKey();