# Left Join
A hashtable implementation.  The method that solves this implementation lives in 
HashTable.cs and is called LeftJoinHashTable

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
The current hashtable class uses a node class that takes in a Key and Value that 
are both of STRING type.  The hashtable class used has been refactored slightly 
to handle the slightly refactored node class.

The process involves creating a third hashtable to store the left join. 
Then go through the entire length of hashtable 1. 
As long as that index, of hashtable 1, is not null, check if hashtable 
2 has that key.  If it does, add the key and both of the values to 
hashtable 3.  Otherwise, there was no match found. Since this implements a left 
join, add the key and value of hashtable 1 to hashtable 3.

Return Hashtable 3.

---
## Visual

Whiteboard:

![Left Join](/assets/leftJoin.jpeg)