# Check if a BST is Balanced

Given a BST, check if it's balanced.

A tree is balanced when the length of the shortest and longest branch 
differ by 1 level.  For this problem, balance refers to height balance 
of the entire tree rather than comparing its subtrees, which is a 
different problem.

#### Input
```
          1

      2       3  

   4    5
```

#### Output
True

## Problem Solving Process
Since the length for each branch needs to be checked, all branches 
must be traversed.  When a leaf is reached, the base case, return 0.  
As layers are taken off the recursive call stack, add 1 to which