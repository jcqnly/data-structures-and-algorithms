# Reverse Each Word In A String
Reverse each word in a given string, but maintain the 
word order.

## Input
"Hello world"

## Output
"olleH dlrow"

## Problem Solving Process
Both process used StringBuilder.

### 1 - With .Split
This process required an O(N) solution in terms of time.  
First the string was split on the spaces and stored into an 
array. Starting from the end of each word, each letter was 
appended.

### 2 - Without .Split
This process required an O(N^2) solution.  The first for loop 
being the one that iterates over the entire string.  The second 
loop decrements through the letter count of each word. 
A temp variable kept track of where we are in the first loop, 
so that the specific character is correctly appended.

