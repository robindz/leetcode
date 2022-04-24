using _0705._Design_HashSet;
using Xunit;

MyHashSet myHashSet = new();

myHashSet.Add(1);
myHashSet.Add(2);
Assert.True(myHashSet.Contains(1));
Assert.False(myHashSet.Contains(3));

myHashSet.Add(2);
Assert.True(myHashSet.Contains(2));

myHashSet.Remove(2);
Assert.False(myHashSet.Contains(2));

Console.ReadKey();