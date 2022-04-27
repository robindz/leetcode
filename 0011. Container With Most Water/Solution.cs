namespace _0011._Container_With_Most_Water
{
    public class Solution
    {
        public static int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1;
            int water = 0;

            while (l < r)
            {
                water = Math.Max(water, (r - l) * Math.Min(height[l], height[r]));
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return water;
        }
    }
}
