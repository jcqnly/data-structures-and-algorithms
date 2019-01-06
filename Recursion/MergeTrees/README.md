# Merge 2 Binary Trees
Problem from [here](https://leetcode.com/problems/merge-two-binary-trees/description/)

#### Input
```
                Tree 1                      Tree 2
                 11                           2
                 / \                         / \
                3   2                       1   6
               /                             \   \
              5                               9   7

```


#### Output
```
                13
               / \
              4   8
             / \   \
            5   9   7  

```

## Problem Solving Process
I worked with a classmate on this.  There are 2 base cases to account 
for when one tree has a node and the other is null.  If this is the case, 
return the node that is not null.  Otherwise, add the value of the node on 
tree2 to tree1, go left ond recursively call the method on each of the 
trees left nodes.  Then repeat for the right side.  Finally, return the 
node from tree1.