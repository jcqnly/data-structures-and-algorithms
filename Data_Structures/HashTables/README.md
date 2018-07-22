# Hash Tables
Hashtables are like arrays under the hood. They are a type of data structure 
that maps keys to values and makes it easy to search for that value if 
given a key.  Due to this characteristic, the time complexity of a 
search and insertion on a hashtable is 0(1).

---
## Hashtable Implementation
This implementation will add key/value pairs to a node, which will then be 
placed into an index of the hashtable. Nodes were chosen so that in the 
case of a collision, the new node can be linked to the node that is already 
at the index.

#### Key
The given string is the key, which is turned into a hash value.  The hash 
value is where the value, associated with the key, will be placed.

#### Value
In this problem domain, a value is an arbitrary positive number.

---
## Use Cases
Hashtables provide a quick lookup of information.  An example would be 
hashing an employee name and storing that in a hashtable.  That key can be 
associated with other information like their address, phone number or 
any personal identification information.

Another example would be a for an ecommerce site that needs to store a 
collection of baskets for all its shoppers and the baskets would have all 
the contents they want to buy.  A lookup of the basket hash will show 
the contexts of their basket.

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

![Hash Table](/assets/hashtable.jpeg)

---

## Acknowledgments
Thanks to Mario for walking me through this.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.