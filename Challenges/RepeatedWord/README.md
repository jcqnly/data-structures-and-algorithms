# Repeated Word - a Hashtable Challenge
---
## Challenge
Using a hashtable data structure, find the first repeated word from a 
given lengthy string.

---
## Problem Solving Process
The logic involves removing all punctuation marks first. Then split the 
string on a space and store that into an array of type string.  Then 
loop through every word in the new array.  Within that loop, check if 
that word is already in the hashtable.  If it is, return that word. 
If not, add that word to the hashtable and repeat.

If there are no repeating words, return a message that says there 
were no repeating words.

--
## Whiteboard

![Rpeated Word](/assets/repeatWord.jpeg)

---

## Acknowledgments
Thanks to Max for letting me walk through the problem with him.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.
