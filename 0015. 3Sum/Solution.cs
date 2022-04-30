namespace _0015._3Sum
{
    public class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            // Sort the input array
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            // Iterate through 0...n-1 numbers
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                // Avoid duplicates
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    // Initialize two pointers and the sum which should be equal to
                    // the sum of the values at the pointers in the array, but with
                    // the opposite sign.
                    int low = i + 1, high = nums.Length - 1, sum = 0 - nums[i];
                    while (low < high)
                    {
                        if (nums[low] + nums[high] == sum)
                        {
                            result.Add(new List<int> { nums[i], nums[low], nums[high] });
                            while (low < high && nums[low] == nums[low + 1]) low++;
                            while (low < high && nums[high] == nums[high - 1]) high--;
                            low++;
                            high--;
                        }
                        else if (nums[low] + nums[high] < sum)
                        {
                            low++;
                        }
                        else
                        {
                            high--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
