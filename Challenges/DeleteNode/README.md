# Delete a Node

## Delete any node
Problem found [here](https://leetcode.com/problems/delete-node-in-a-linked-list/description/)
Given a singly linked list, delete a certain node.

### Input
10 -> 5 -> 20 -> 13 -> 18, node = 20

### Output
10 -> 5 -> 13 -> 18

### Problem Solving Process
Ideally, the pointer of the node before the node to be deleted 
should be pointed to the node after the node to be deleted.  

Since we cannot travel backwards in a singly linked list, a way to 
solve this problem is to assign the value of the node to be deleted 
with the value of the node after it.  Then the pointer of the node 
to be deleted points to the node after it, the one whose value we 
just used.


## Delete a node Kth from the end
Problem found [here](https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/)
Given a singly linked list and a value K from the end, 
delete that node.

### Input

### Output

### Problem Solving Process
