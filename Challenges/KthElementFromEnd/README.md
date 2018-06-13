# Kth Element From the End Of a Singly Linked List
This challenge involves finding a number that is **k** distance away on a singly linked list.
Since singly linked lists only allow direction going forward, we decided 
to find the length of the list first by incrementing a counter, as a distance marker, as we traversed the singly linked list.

After determining the length, we traversed the list again, but only went the distance minus the value of **k**.

## Challenge
Write a method for a singly linked list that takes a number, **k**, as a parameter.
Return the node that is **k** from the end of the singly linked list.

## Solution
![KthElementFromEnd](/assets/KthElementFromEnd.jpg)