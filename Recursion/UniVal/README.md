# Univalue BT

Check if all the nodes in a BT are all the same values.

Problem from [here](https://leetcode.com/problems/univalued-binary-tree/)

This is an exercise in understanding how recursion works.  

## How This Recursion Solution Works
The base case for this traversal is when a node has no child nodes.  
That node is taken of the call stack and we are back to the node before 
it, its parent node.  The parent node's value is checked against its 
child node, the previous node; at any point where the parent's node value
is not the same as its child node's, then the method breaks and a false 
is returned