# Reverse Words in a String
___

## Problem Overview
Given a string of words, return the words in reversed order.

### Input
"I like green eggs and ham"

### Output
"ham and eggs green like I"

___

## Problem Solving Process
Firstly, the given string is split on a space and stored in a new array.  
The new array is then iterated, starting from the end towards the start of the array.  
As each word is iterated through, the word is appended to a String builder.
