# Merge Sort
Given an array, sort it.

---
## Challenge
Implement a merge sort

---
## Merge Sort Defined
A merge sort is a recursive way of sorting a large array.  It is a 'divide and 
conquer' style of sorting.  This style means that an array will be split in 
half.  Those halves are split in half and so forth.  Those halves are sorted 
and then those halves are sorted with the other half.

---
## Big O
Since this breaks the array in two, the sort needs to do log n merges steps 
because each merge step doubles the size of the array.  Since every number is 
looked at, this algorithm runs in O(n log n) in terms of time.  In terms of 
space, this will be O(1) because no new array is created to store the sorted 
values.

---
## Visual
![Merger Sort](/assets/mergeSort.png)

---
## Acknowledgments
Thanks to the [Hacker Rank Tutorial](https://www.youtube.com/watch?v=KF2j-9iSf4Q)