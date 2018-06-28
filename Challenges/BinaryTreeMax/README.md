# Find the Max Value in a Binary Tree

## Challenge
Write a method that takes a binary tree as its input and returns the
max value.  All values stored in the tree are numeric.  There can be
duplicate values.

---

## Problem Solving Process
Our group chose the breadth first traversal method.  The initial max
value is the first enqueued node and in the initial max value.  
From there, if the current front node is larger than the max, 
reassign max to this value.  Continue enqueueing and dequeueing 
the tree to compare the remaining node values.

The big O of time is O(N) as the traversal time depends on the number
nodes.  The big O of space is O(1) as the queue is continually being
dequeued and enqueued.

---

## Whiteboard Solution
![Find Max Binary Tree](/assets/FindMaxWhiteboard.png)


---

## Acknowledgments
Thanks to Anthony and Nate for their teamwork in solving this challenge.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this amazing README layout.