Here is a C# console application that solves the problem:

```csharp
using System;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

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

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Head = new Node { Value = 1 };
        list.Head.Next = new Node { Value = 2 };
        list.Head.Next.Next = new Node { Value = 3 };
        list.Head.Next.Next.Next = new Node { Value = 4 };
        list.Head.Next.Next.Next.Next = list.Head.Next;

        Node cycleStart = list.DetectCycle();
        if (cycleStart != null)
        {
            Console.WriteLine("Cycle detected. Cycle starts at node with value: " + cycleStart.Value);
        }
        else
        {
            Console.WriteLine("No cycle detected.");
        }
    }
}
```

This program creates a linked list with a cycle, then uses the Floyd's cycle-finding algorithm to detect the cycle and find the start of the cycle. If a cycle is detected, it prints the value of the node where the cycle starts. If no cycle is detected, it prints "No cycle detected."