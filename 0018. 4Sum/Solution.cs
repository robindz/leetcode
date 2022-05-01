namespace _0018._4Sum
{
    public class Solution
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            // General idea: reduce k problem to k - 1 problem until we find
            // a value of k that has an easy solution (in this instance k = 2 or 2Sum)
            Array.Sort(nums);
            return KSum(nums, target, 0, 4);
        }

        private static IList<IList<int>> KSum(int[] nums, int target, int start, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();

            // If we have run out of numbers to add, return res.
            if (start == nums.Length)
                return result;

            // There are k remaining values to add to the sum. The 
            // average of these values is at least target / k.
            int average = target / k;

            // We cannot obtain a sum of target if the smallest value
            // in nums is greater than target / k or if the largest 
            // value in nums is smaller than target / k.
            if (nums[start] > average || average > nums[nums.Length - 1])
            {
                return result;
            }

            if (k == 2)
            {
                return TwoSum(nums, target, start);
            }

            for (int i = start; i < nums.Length; ++i)
            {
                if (i == start || nums[i - 1] != nums[i])
                {
                    foreach (IList<int> subset in KSum(nums, target - nums[i], i + 1, k - 1))
                    {
                        result.Add(new List<int> { nums[i] });
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        (result[result.Count - 1] as List<int>).AddRange(subset);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    }
                }
            }

            return result;
        }

        private static IList<IList<int>> TwoSum(int[] nums, int target, int start)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int low = start, high = nums.Length - 1;
            while (low < high)
            {
                int sum = nums[low] + nums[high];
                if (sum < target || (low > start && nums[low] == nums[low - 1]))
                {
                    low++;
                }
                else if (sum > target || (high < nums.Length - 1 && nums[high] == nums[high + 1]))
                {
                    high--;
                }
                else
                {
                    result.Add(new List<int> { nums[low++], nums[high--] });
                }
            }

            return result;
        }
    }
}
