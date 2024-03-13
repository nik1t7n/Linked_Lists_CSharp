# Single Linked List

After we have created **Node** class we can start implementing first
type of Linked List - **Single Linked List**. Why is it called like that?

## Base

> Single Linked List means that each of its nodes can refer only to
the next one. There is no refernece to previous nodes, only further!

*What about structure?* Here we have three properties:
- Head
- Tail
- Count

<u>Head</u> is used to point the first element of a list.
In opposite, <u>Tail</u> points the last element.
<u>Count</u> we use to track amount of nodes in a list.

We will write *two* constructors: default one and one with passed node.
In former we just make every property **null** while in latter we make
_head and _tail equal to given node, _count is incremented by 1.

## Display

In this method firstly we check if the list is empty and if it is not
we go through the list using *While-loop*.

---

(further I will not explain the some of the "If-statements" 
because they are usedjust for safety and are not connected to the logic)

---

## AddAfterLastNode

Here we need to redefine the reference of the Tail to new given node 
to create a connection and make given node a Tail. Also don't forget
about _count incrementation.

## AddBeforeFirstNode

Firstly we create a connection between given node (future head) and 
current head and just redefine _head to given node.

## AddAfterSpecifiedPosition

This method iterates through the linked list until it reaches the node 
just before the specified position, then inserts the new node after 
that position, updating the relevant references accordingly. Finally, 
it increments the count of nodes in the list to reflect the addition 
of the new node.

## RemoveLastNode

Here we segment removes the last node from the linked list. It 
iterates through the list until it finds the node just before the 
last node, sets its Next reference to null, updates the tail reference 
to point to this node, and decrements the count of nodes in the list.

## RemoveFirstNode

This code just makes the next node head. Thats all, very simple!

## RemoveNodeAtSpecificPosition

This method segment removes the node at a specific position within 
the linked list. It iterates through the list until it reaches the 
node just before the specified position, updates the references to 
skip over the node at the specified position, effectively removing 
it from the list, and decrements the count of nodes in the list.

## SearchByValue

Here we search for a specific value within the linked 
list and returns its position if found, or -1 if the value is not 
present. We iterate through the list, comparing each node's data 
with the specified value until a match is found, updating the 
position counter accordingly. If the value is null, it throws an 
exception.

---

So, thats how I implemented all required methods.