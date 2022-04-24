using _0004._Median_of_Two_Sorted_Arrays;
using Xunit;

int[] nums1 = { 1, 3 };
int[] nums2 = { 2 };
double median = Solution.FindMedianSortedArrays(nums1, nums2);
Assert.Equal(2.0, median);

nums1 = new int[]{ 1, 2 };
nums2 = new int[]{ 3, 4 };
median = Solution.FindMedianSortedArrays(nums1, nums2);
Assert.Equal(2.5, median);

Console.ReadKey();