using _0001._Two_Sum;
using Xunit;

int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] twoSum = Solution.TwoSum(nums, target);

Assert.Equal(0, twoSum[0]);
Assert.Equal(1, twoSum[1]);

nums = new int[]{ 3, 2, 4 };
target = 6;
twoSum = Solution.TwoSum(nums, target);

Assert.Equal(1, twoSum[0]);
Assert.Equal(2, twoSum[1]);

nums = new int[] { 3, 3 };
target = 6;
twoSum = Solution.TwoSum(nums, target);

Assert.Equal(0, twoSum[0]);
Assert.Equal(1, twoSum[1]);

Console.ReadKey();