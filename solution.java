Here is a Java console application that solves the problem:

```java
import java.util.HashSet;

class Node {
    int data;
    Node next;

    Node(int data) {
        this.data = data;
        next = null;
    }
}

class LinkedList {
    Node head;

    public void push(int data) {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    public boolean detectLoop() {
        Node slow = head, fast = head;
        while (slow != null && fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) {
                return true;
            }
        }
        return false;
    }

    public Node findStartOfLoop() {
        if (head == null || head.next == null)
            return null;

        Node slow = head, fast = head;

        slow = slow.next;
        fast = fast.next.next;

        while (fast != null && fast.next != null) {
            if (slow == fast)
                break;

            slow = slow.next;
            fast = fast.next.next;
        }

        if (slow != fast)
            return null;

        slow = head;
        while (slow != fast) {
            slow = slow.next;
            fast = fast.next;
        }

        return slow;
    }
}

public class Main {
    public static void main(String[] args) {
        LinkedList list = new LinkedList();
        list.push(20);
        list.push(4);
        list.push(15);
        list.push(10);

        list.head.next.next.next.next = list.head;

        if (list.detectLoop())
            System.out.println("Loop found");
        else
            System.out.println("No Loop");

        Node startNode = list.findStartOfLoop();
        if (startNode != null)
            System.out.println("Start of loop is at node: " + startNode.data);
        else
            System.out.println("No Loop");
    }
}
```

This program creates a LinkedList with a loop. The `detectLoop` method uses Floyd's Cycle-Finding Algorithm to detect if there is a loop in the LinkedList. The `findStartOfLoop` method also uses Floyd's Algorithm to find the start of the loop. The `main` method tests these functionalities.