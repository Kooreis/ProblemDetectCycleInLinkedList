public class LinkedList
{
    public Node Head { get; set; }

    public Node DetectCycle()
    {
        Node slow = Head;
        Node fast = Head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
            {
                Node slow2 = Head;
                while (slow2 != slow)
                {
                    slow = slow.Next;
                    slow2 = slow2.Next;
                }
                return slow2;
            }
        }
        return null;
    }
}