# Left Join
A hashtable implementation

---
## Challenge
Write a method that takes in 2 hashtables and joins them into a single data 
structure.  The first parameter is a hashmap that has words as keys and a 
synonym of the key as values.  The second parameter is a hashmap that has 
words as keys and an antonym of the key as a value.

Left join means that all values in the first hashtable are returned, and if 
values exist in the "right" hashtable, append it to a result row.

The returned data structure can be anything so long as it implements the left 
join concept.

---
## Problem Solving Process
The current hashtable data structure does not allow for null values and the 
value was set to a type int.

For this challenge, the Value, in the key/value pair, will be set to a 
type string.


## Visual

Whiteboard:

![Left Join](/assets/leftJoin.jpeg)