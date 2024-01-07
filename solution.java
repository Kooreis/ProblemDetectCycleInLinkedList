class LinkedList {
    Node head;

    public void push(int data) {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }
}