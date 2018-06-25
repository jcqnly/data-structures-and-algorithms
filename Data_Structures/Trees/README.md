# Binary Tree and Binary Search Tree

## Concepts defined
Trees consists of a root with a left or a right node.  Those child nodes
can have a left or a right child node themselves and so forth. A leaf
is a node with no child nodes.

A binary tree means that each node will have between 0-2 nodes each.
These nodes can be null.

A binary search tree has a specific ordering structure where the nodes
on the right are less in value than the nodes on the right.  The Big O
of a binary search tree will always be O(log N).

---

## Challenge
Implement a **Binary Tree** and a **Binary Search Tree** that does the
following following traversals:
1. PreOrder()
2. InOrder()
3. PostOrder()
4. BreadthFirst()

Allow the **Binary Tree** to Search().

Allow the **Binary Search Tree** to Search() and AddNode().

---

## Traversal Methods
1. PreOrder() - Root, Left, Right
   
2. InOrder() - Left, Root, Right

3. PostOrder() - Left, Right, Root

4. BreadthFirst() - Travels through the tree by going through
each level of the tree, node by node.

---

## Binary Tree Search()
For this solution, a breadth first traversal implementation was used.
If either child nodes of the starting node is the value, then the node
has been found.  Repeat the Dequeueing method until the desired node
is located.

Otherwise, throw an exception error if the node doesn't exist.

---

## Binary Search Tree Search()


---

## Binary Search Tree AddNode()


---

## Solution

Whiteboard:

![]()

---

## Acknowledgments
Thanks to Gayle McDowell and this [video](https://www.youtube.com/watch?v=oSWTXtMglKE) for the walk through of these concepts.

Thanks to [jaatay](https://github.com/jaatay) and [IndigoShock](https://github.com/IndigoShock) for working with me on this challenge.

Thanks to [Aiverson1011](https://github.com/Aiverson1011) for the guidance.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.