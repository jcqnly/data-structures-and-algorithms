# Tree Intersection - a hashtable implementation
Using concepts of a binary tree traversal and a hashtable find 
common values.

---

## Challenge
Given 2 binary search trees, find the common values found in both 
trees.  Return this set of values

---
## Problem Solving Process
Traverse through one tree via the Breadth First Traversal method.  
While traversing through the tree, add that node to a hashtable.

Then traverse through the second tree with the Breadth First Traversal 
method.  While traversing through the second tree, check if that node 
is in the hashtable of nodes.

Finally return that hashtable of common values

---
## Visual
Problem domain, visual, and algorithm

![Problem Domain](/assets/treeIntersection1.jpeg)

Pseudo code solution

![PseudoCode](/assets/treeIntersection2.jpeg)