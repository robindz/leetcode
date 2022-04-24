using _0009._Palindrome_Number;
using Xunit;

bool isPalindrome = Solution.IsPalindrome(121);
Assert.True(isPalindrome);

isPalindrome = Solution.IsPalindrome(-121);
Assert.False(isPalindrome);

isPalindrome = Solution.IsPalindrome(10);
Assert.False(isPalindrome);

Console.ReadKey();