# Hash Tables
Hash tables are a type of data structure that maps keys 
to values and makes it easy to search for that value if 
given a key.  The key is the indexer and the value is 
accessed by the key.  Searches happen quickly if a key is given. 
Due to this, the time complexity is O(1) for hash tables.

Overall, Hashtables are like arrays under the hood.

---
## Hashtable Implementation

#### Value
In this problem domain, a string is given.  An example would be "cat". 
The ASCII values for "cat" is then determined.  This will be the 
value added to the index of the array, which is the hashtable.

#### Index/Key
The index is then determined by this equation: 
```
index = arrayLength % ASCIIValOfWord
```

---
## Use Cases
Finding any information by its number can be implemented with a 
hash table.  This can be applied to looking up employees by their 
employee ID number. For the graph implementation that involved 
weights, we can store the edges and its weight in a hashtable.  
Given an edge, we can find out the weight.

---

## Challenge
Implement a **Hash Table** with capabilities to:

Add(key, value): void return

Find(int key): returns the value

Contains(int key): returns bool

GetHash(key): returns the key

Handle a collision in the event that 2 keys are the same.


## Visual

A visualization of a hashtable:

![Hash Table](/assets/hashTableVisual.jpg)

---

## Acknowledgments
Thanks to Jermain and Steph for walking through this together.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.