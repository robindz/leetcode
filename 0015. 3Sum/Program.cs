using _0015._3Sum;
using Xunit;

var sums = Solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
Assert.Equal(new int[] { -1, -1, 2 }, sums[0]);
Assert.Equal(new int[] { -1, 0, 1 }, sums[1]);

sums = Solution.ThreeSum(new int[] { });
Assert.Equal(0, sums.Count);

sums = Solution.ThreeSum(new int[] { 0 });
Assert.Equal(0, sums.Count);

Console.ReadKey();