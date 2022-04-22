namespace _705._Design_HashSet
{
    public class Element
    {
        public int Value { get; set; }
        public bool Deleted { get; set; }
        public Element? Next { get; set; }

        public bool HasNext() => Next != null;
    }
}
