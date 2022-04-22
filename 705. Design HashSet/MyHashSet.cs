namespace _705._Design_HashSet
{
    public class MyHashSet
    {

        private static readonly int _size = 16;
        private readonly Element[] _set = new Element[_size];

        public MyHashSet() { }

        public void Add(int key)
        {
            int index = CalculateSetIndex(key);

            Element? element = _set[index];
            if (element != null && !element.Deleted && element.Value == key)
            {
                return;
            }

            if (element != null)
            {
                while (element.HasNext())
                {
                    element = element.Next;
                    if (!element.Deleted && element.Value == key)
                    {
                        return;
                    }
                }
            }

            element = _set[index];
            Element newElement = new Element
            {
                Value = key
            };

            if (element != null)
            {
                while (!element.Deleted && element.HasNext())
                {
                    element = element.Next;
                }

                if (element.Deleted)
                {
                    element.Deleted = false;
                    element.Value = newElement.Value;
                }
                else
                {
                    element.Next = newElement;
                }
            }
            else
            {
                _set[index] = newElement;
            }
        }

        public void Remove(int key)
        {
            int index = CalculateSetIndex(key);

            Element? element = _set[index];
            if (element == null)
            {
                return;
            }
            else if (!element.Deleted && element.Value == key)
            {
                element.Deleted = true;
                return;
            }

            while (element.HasNext())
            {
                element = element.Next;
                if (!element.Deleted && element.Value == key)
                {
                    element.Deleted = true;
                }
            }
        }

        public bool Contains(int key)
        {
            int index = CalculateSetIndex(key);

            Element? element = _set[index];
            if (element == null)
            {
                return false;
            }
            else if (!element.Deleted && element.Value == key)
            {
                return true;
            }

            while (element.HasNext())
            {
                element = element.Next;
                if (!element.Deleted && element.Value == key)
                {
                    return true;
                }
            }

            return false;
        }

        private static int CalculateSetIndex(int key)
        {
            return key.GetHashCode() % _size;
        }
    }
}
