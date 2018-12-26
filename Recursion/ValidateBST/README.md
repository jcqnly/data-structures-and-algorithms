# Validate a BST
Given a BST, determine if it is a valid BST.

#### Input

#### Output

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
