# Tree Intersection - a hashtable implementation
Using a binary tree and hashtable data structure

---

## Challenge
Given 2 binary search trees, find the common values found in both 
trees.  Return this set of values

---
## Problem Solving Process
The method that solves the problem is named TreeIntersection 
and lives in the HashTable class.

The idea is:

Traverse through one tree via the Breadth First Traversal method.  
While traversing through the tree, add that node to a hashtable.

Then traverse through the second tree with the Breadth First Traversal 
method.  While traversing through the second tree, check if that node 
is in the hashtable of nodes.

Finally return that hashtable of common values.

Since the BreadFirst method of the BinaryTreeSearch class was 
used for both tree traversals, and this was where the nodes were 
added to their own hashtables, a hashtable is created for each 
tree that uses this method.

---
## Challenges With This Challenge
Due to strict typing, the Node class for the HashTable had to be 
renamed to HTNode.  This prevents ambiguity between the node class 
of a hashtable and a binary tree.  Both have different properties.

---
## Big O
Due to the challenges, space complexity will be O(N) because 
new hashtables are made with every tree traversal.  

Time complexity will also be O(N) as the algorithm checks every 
index of the hashtable and sees if that values exists in the 
hashtable for the other tree.

---
## Visual
Problem domain, visual, and algorithm

![Problem Domain](/assets/treeIntersection1.jpeg)

Pseudo code solution

![PseudoCode](/assets/treeIntersection2.jpeg)