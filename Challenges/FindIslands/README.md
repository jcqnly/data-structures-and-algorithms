# Find Islands
A graph implementation involving an adjacency matrix

## Overview
Given a 2D matrix, find the number of islands.

## Problem Solving Process
Since a 2D matrix is given, a double nested for loop is necessary 
to cycle through all the contents.  Before proceeding, declare a list 
to put the connected nodes.  Dive into the double nested loop.  

If the contents at that row and column is 1 and if the row nodes 
contains the column node, call the AddEdge method where the row is the 
source and the column is the destination. Add this edge to an adjacency 
list.

If the contents at that row and column is 1 and if the row nodes 
doesn't contain the column node, declare a new list.  Call the AddEdge 
method where the row is the source and the column is the destination.

The tricky part is how to figure out when a new island begins.

## Whiteboard

![find islands](/assets/findIslands.jpeg)

---

## Acknowledgments

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.