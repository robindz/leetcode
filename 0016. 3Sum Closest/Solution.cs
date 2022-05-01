namespace _0016._3Sum_Closest
{
    public class Solution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            /* nums[0] nums[1] nums[2] ... nums[i] .... nums[j] ... nums[k] ... nums[n-2] nums[n-1]
             *                             nums[i]  <=  nums[j]  <= nums[k] always, because we sorted our array. 
             * Now, for each number, nums[i] : we look for pairs nums[j] & nums[k] such that 
             * absolute value of (target - (nums[i] + nums[j] + nums[k]) is minimised.
             * if the sum of the triplet is greater then the target it implies
             * we need to reduce our sum, so we do k = k - 1, that is we reduce
             * our sum by taking a smaller number.
             * Simillarly if sum of the triplet is less then the target then we
             * increase out sum by taking a larger number, i.e. j = j + 1.
             */

            Array.Sort(nums);
            int closest = nums[0] + nums[1] + nums[2], sum;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1, k = nums.Length - 1;
                while (j < k)
                {
                    sum = nums[i] + nums[j] + nums[k];
                    if (Math.Abs(target - closest) > Math.Abs(target - sum))
                    {
                        closest = sum;
                        if (closest == target) return closest;
                    }

                    if (sum > target)
                        k--;
                    else
                        j++;
                }
            }

            return closest;
        }
    }
}
