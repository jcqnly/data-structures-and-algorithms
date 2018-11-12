# Delete a Node

## Delete any node
Problem found [here](https://leetcode.com/problems/delete-node-in-a-linked-list/description/)
Given a singly linked list, delete a certain node.

### Input
10 -> 5 -> 20 -> 13 -> 18, node = 20

### Output
10 -> 5 -> 13 -> 18

### Problem Solving Process
_Strategy 1_:
Walk through the linked list.  If the next node is the one to be 
deleted, set the current.next pointer to current.next.next.
(This strategy is from Hacker Rank)

_Strategy 2_:
Walk through the linked list.  Go to the node to be deleted.  Set its 
value to the one after it.  Set its current.next pointer to 
current.next.next.

This strategy assumes you only have access to that node in the 
linked list.  This will not work if the node to be deleted is 
the last node.
(This strategy is from LeetCode)

## Delete a node Kth from the end
Problem found [here](https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/)
Given a singly linked list and a value K from the end, 
delete that node.

### Input

### Output

### Problem Solving Process
