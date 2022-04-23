using _8._String_to_Integer__atoi_;
using Xunit;

int number = Solution.MyAtoi("42");
Assert.Equal(42, number);

number = Solution.MyAtoi("   -42");
Assert.Equal(-42, number);

number = Solution.MyAtoi("4193 with words");
Assert.Equal(4193, number);

number = Solution.MyAtoi("words and 987");
Assert.Equal(0, number);

number = Solution.MyAtoi("-91283472332");
Assert.Equal(int.MinValue, number);

number = Solution.MyAtoi("");
Assert.Equal(0, number);

number = Solution.MyAtoi(" ");
Assert.Equal(0, number);

Console.ReadKey();