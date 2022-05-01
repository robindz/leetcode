using _0016._3Sum_Closest;
using Xunit;

var sum = Solution.ThreeSumClosest(new int[] { -1, 2, 1, 4 }, 1);
Assert.Equal(2, sum);

sum = Solution.ThreeSumClosest(new int[] { 0, 0, 0 }, 1);
Assert.Equal(0, sum);

Console.ReadKey();