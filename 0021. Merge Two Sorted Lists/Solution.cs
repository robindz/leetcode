namespace _0021._Merge_Two_Sorted_Lists
{
    public class Solution
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            return Merge(list1, list2);
        }

        private static ListNode Merge(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            if (l1.val <= l2.val)
            {
                l1.next = Merge(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = Merge(l1, l2.next);
                return l2;
            }
        }
    }
}
