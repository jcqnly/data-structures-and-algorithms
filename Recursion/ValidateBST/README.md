# Validate a BST
Given a BST, determine if it is a valid BST.

#### Input
```
                   4
                 /   \
                1     6
               / \   / \
              0   2 5   7
```

#### Output
True

## Problem Solving Process
_What determines if a BST is balanced?_  
A valid balanced BST is one where the left node is less than the root, 
and the right node is greater than the root.  Each subtree needs to 
follow the same rule.  

This is valid:  
```
                   4
                 /   \
                1     6
               / \   / \
              0   2 5   7
```
Each subtree follows the rule stated earlier.

This is _not_ valid:  

```
                   4
                 /   \
                1     6
               / \   / \
              0   2 3   7
```
Note that the left and right nodes of 6 are in the correct place for the 
subtree to be balanced.  In the grand scheme of the tree, the 3 is not in 
the correct spot for the entire tree to be balanced.


## Solution:
The recursive solution shown here made the most sense and was 
originally found [here](https://leetcode.com/problems/validate-binary-search-tree/discuss/32112/Learn-one-iterative-inorder-traversal-apply-it-to-multiple-tree-questions-(Java-Solution)).

_Recursive Explanation:_
Travel DF InOrder down the tree all the while keeping track of the value 
of a previous node that we were at, so as to have something to compare 
with the current node.  

When the right side gets checked, the previous node value is 
set to the current node value.  This previous value then can be compared 
with the root node of the subtree where this subtree is located as 
we go back through the recursive call stack.

_Iterative Explanation:_  
There are 2 similar ways to write this logic, and both are included in 
this project.  Uncomment the commented code and give it a whirl!

This strategy uses a stack to hold the values of the nodes.  While
the stack is not empty or the node we're looking at is not null, 
push it into the stack and go left until a null node is encountered.  
When this happens and the stack is not empty, pop the top node.  Check 
if the node's value is less than prev.  If it is, the tree is not a 
valid BST.  Otherwise, reset the value of prev and go right.  Repeat 
starting at the 'while' sentence of this paragraph.



