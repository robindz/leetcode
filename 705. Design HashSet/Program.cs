using _705._Design_HashSet;

MyHashSet myHashSet = new();
myHashSet.Add(1);      // set = [1]
myHashSet.Add(2);      // set = [1, 2]
myHashSet.Contains(1); // return True
myHashSet.Contains(3); // return False, (not found)
myHashSet.Add(2);      // set = [1, 2]
myHashSet.Contains(2); // return True
myHashSet.Remove(2);   // set = [1]
myHashSet.Contains(2); // return False, (already removed)

Console.ReadKey();