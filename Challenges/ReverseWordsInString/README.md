# Reverse Words in a String
___

## Problem Overview
Given a string of words, return the words in reversed order. Don't 
reverse the words themselves.

Strategy 1 and 2 deal with strings.  If the input has each letter in a 
char array, then strategy 3 is needed.

### Input
"I like green eggs and ham"

### Output
"ham and eggs green like I"

___

## Problem Solving Process
Strategy 1 - iterate backwards and use StringBuilder

The given string is split on a space and stored in a new array.  
The new array is then iterated, starting from the end towards the start 
of the array.  As each word is iterated through, the word is appended 
to a String builder as long as it hasn't reached the beginning of the 
array.  If i is 0, then the String builder variable is returned as a string.

_Time Complexity O(N)_

_Space Complexity O(N)_

Strategy 2 - iterate forwards and use recursion to swap words

_Time Complexity O(N)_

_Space Complexity O(1)_


## Different Scenario: 
#### Each letter is in a char arary rather than given as a string

Strategy 3 - First reverse the entire array.  Then reverse each word 
to reverse back the words themselves.
