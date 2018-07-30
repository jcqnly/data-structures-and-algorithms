# Insertion Sort
Implement an insertion sort

---
## Insertion Sort Further Defined
Insertion sort iterates over an array.  Each iteration, the sort removes one 
element from the input data, finds its location within a sorted array, and 
inserts it there.  This repeats until there are no more elements left to check.

Big O of time for the best case scenario, an already ordered array, is O(N) because 
the algorithm still checks every number in the array. 

Big O of time for the worst case, a reversed array, and an average case scenario is 
a quadratic O(N^2).

Big O of space is constant O(1) because no new space is created.

---
## Challenge
Create a method that takes in an unsorted array and returns a sorted array.

---
## Use Cases
Use cases would be for challenges that works with an unsorted array.  
Sorting an array can facilitate in solving a challenge.

---
## Visual
![Insertion Sort Whiteboard](/assets/insertionSort.jpeg)

---
## Problem Solving Process
For this implementation, the process compares a number against a sorted list. 
If the number to the left is larger, the 2 numbers are 
swapped.  There is an additional indexer that tracks where within the 
sorted list is being checked, so that the number being compared is checked 
against the numbers in the sorted list.

To accomplish this, there are 2 while loops.  One loop is for the given array.  
The other loop is for the sorted list with which to check the number being 
checked.