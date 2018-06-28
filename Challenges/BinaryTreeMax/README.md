# Find the Max Value in a Binary Tree

## Challenge
Write a method that takes a binary tree as its input and returns the
max value.  All values stored in the tree are numeric.  There can be
duplicate values.

---

## Problem Solving Process
Our group chose the breadth first traversal method.  The initial max
value is the first enqueued node.  From there, if either the right
or left child of the node we're on is larger than the max, reassign max
to that value.  Continue enqueueing and dequeueing the tree to compare 
the remaining node values.

---

## Whiteboard Solution
![Find Max Binary Tree](/assets/FindMaxWhiteboard.png)


---

## Acknowledgments
Thanks to Anthony and Nate for their teamwork in solving this challenge.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this amazing README layout.