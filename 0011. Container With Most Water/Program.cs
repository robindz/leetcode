
using _0011._Container_With_Most_Water;
using Xunit;

int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
int area = Solution.MaxArea(height);
Assert.Equal(49, area);

height = new int[] { 1, 1 };
area = Solution.MaxArea(height);
Assert.Equal(1, area);

Console.ReadKey();