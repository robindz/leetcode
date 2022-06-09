namespace _0019._Remove_Nth_Node_From_End_of_List
{
    public class Solution
    {
        //For eg.let the list be 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9, and n = 4.
        //
        //1. 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9 -> null
        //   ^slow               ^fast
        //   |<--gap of n nodes-->|
        //
        // => Now traverse till fast reaches end
        //
        // 2. 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9 -> null
        //                        ^slow               ^fast
        //                        |<--gap of n nodes-->|
		//				
        //'slow' is at (n+1)th node from end.
        //So just delete nth node from end by assigning slow -> next as slow -> next -> next (which would remove nth node from end of list).
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head, slow = head;
            while (n > 0)
            {
                fast = fast.next;
                n--;
            }

            if (fast == null) return head.next;

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;
            return head;
        }
    }
}
