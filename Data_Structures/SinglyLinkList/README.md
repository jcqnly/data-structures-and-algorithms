# Singly Linked List
A singly linked list is recursive in nature because it points to another
object of the same type.  To get to a certain node, one must traverse
through all the preceeding nodes before it.

## Use Cases
Typically, singly linked lists are used if a simple recursive nature is required, like
enumerating through a list to see all the contents.
A real life example would be an elevator.  You can go in one direction.
There is a bottom floor and a top floor

## Challenge
Implement a singly linked list that does the following:

-add: add a node to the front of the list

-find: find a specific value in the linked list

-print: prints out all the values in the linked list

-add before node: add a node before an existing node

-add after node: add a node after an existing node

-add last node: add a node to the end of a linked list

## Visual
![Add After Example](/assets/addAfter.jpg)

## Time Complexity
-add: O(1)

-find: O(N)

-print: O(N)

-add before node: O(N)

-add after node: O(N)

-add last node: O(N)