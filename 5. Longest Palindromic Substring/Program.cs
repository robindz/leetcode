using _5._Longest_Palindromic_Substring;
using Xunit;

string s = "babad";
string palindrome = Solution.LongestPalindrome(s);
Assert.Equal("bab", palindrome);

s = "abcdsaippuakivikauppiasefgh";
palindrome = Solution.LongestPalindrome(s);
Assert.Equal("saippuakivikauppias", palindrome);

s = "cbbd";
palindrome = Solution.LongestPalindrome(s);
Assert.Equal("bb", palindrome);

s = "abcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcba";
palindrome = Solution.LongestPalindrome(s);
Assert.Equal("abcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcba", palindrome);

s = "bananas";
palindrome = Solution.LongestPalindrome(s);
Assert.Equal("anana", palindrome);

Console.ReadKey();