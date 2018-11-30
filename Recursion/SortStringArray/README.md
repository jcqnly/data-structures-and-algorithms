# Add Array of Strings to BST and Return a Sorted Array

## Problem Domain
Given an array of strings, construct a BST and return a sorted 
array.

#### Input
["h", "b", "j", "e", "a", "g", "c", "f", "d", "i"]
#### Output
"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"

## Approach
This solution assumes that the strings are 1 character long.  
Longer strings will be another challenge.

Since a BST is required, a BST class and Node class were created 
The problem domain asks for to return a sorted array.  Since 
arrays are not mutable, a list was used to store the alphabetized 
letters.

The overall idea is to find the ASCII value of each character 
and place them into a BST based on that value.  Then use an 
in-order traversal method to travel through the tree and place 
the characters, in order, in a list.

*This project also finds the min and max value in the BST.*