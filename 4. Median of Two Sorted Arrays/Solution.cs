namespace _0004._Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[] merged = new int[m + n];
            int i = 0, j = 0, k = 0;

            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    merged[k] = nums1[i];
                    i++;
                }
                else
                {
                    merged[k] = nums2[j];
                    j++;
                }

                k++;
            }

            while (i < m)
            {
                merged[k] = nums1[i];
                i++;
                k++;
            }

            while (j < n)
            {
                merged[k] = nums2[j];
                j++;
                k++;
            }

            if (k % 2 == 1) return merged[k / 2];
            return (merged[(k / 2) - 1] + merged[k / 2]) / 2.0;
        }
    }
}
