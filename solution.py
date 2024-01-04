Here is a Python console application that detects if a linked list has a cycle and finds the start of the cycle:

```python
class Node:
    def __init__(self, x):
        self.val = x
        self.next = None

def detectCycle(head):
    slow = fast = head
    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next
        if slow == fast:
            break
    else:
        return None

    while head != slow:
        head = head.next
        slow = slow.next
    return head

def createLinkedList(arr, pos):
    dummy = cur = Node(0)
    cycle_start = None
    for i, val in enumerate(arr):
        cur.next = Node(val)
        cur = cur.next
        if i == pos:
            cycle_start = cur
    if cycle_start:
        cur.next = cycle_start
    return dummy.next

def main():
    arr = list(map(int, input("Enter the linked list values: ").split()))
    pos = int(input("Enter the position where cycle starts: "))
    head = createLinkedList(arr, pos)
    cycle_node = detectCycle(head)
    if cycle_node:
        print("Cycle detected at node value: ", cycle_node.val)
    else:
        print("No cycle detected")

if __name__ == "__main__":
    main()
```

This console application first asks for the linked list values and the position where the cycle starts. It then creates a linked list with a cycle at the specified position. The `detectCycle` function is used to detect if there is a cycle in the linked list and find the start of the cycle. If a cycle is detected, it prints the value of the node where the cycle starts. If no cycle is detected, it prints "No cycle detected".