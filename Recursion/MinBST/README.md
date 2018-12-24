# Min BST

A challenge from Cracking the Coding Interview book, pg 242

## Problem Domain
Given a sorted array of unique ints, create a balance BST

#### Input
```
[0, 1, 2, 3, 4, 5, 6, 7, 8]
```

#### Output
```
                        4
                      /   \ 
                     1     6
                    / \   / \
                   0   2 5   7
                        \     \
                         3     8

```

## Problem Solving Process
A balance BST is one where the values of the left node is less 
than the value of the root, and the value of the right node is greater 
than the value of the root.  Since we are given a sorted array of unique 
values, we can find the mid of the array.  Then find the mid of 
the left half and the mid of the right half recursively.  Every time the 
mid is calculated, that mid becomes the new node of the tree.
