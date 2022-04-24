namespace _0001._Two_Sum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> lookupTable = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int targetComplement = target - nums[i];

                if (lookupTable.ContainsKey(targetComplement))
                {
                    return new int[] { lookupTable[targetComplement], i };
                }

                if (!lookupTable.ContainsKey(nums[i]))
                {
                    lookupTable.Add(nums[i], i);
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
