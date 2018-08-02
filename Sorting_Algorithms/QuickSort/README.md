# Quick Sort
Given an unsorted array, sort it with a quick sort.

---
## Challenge
Implement a quick sort

---
## Quick Sort Defined
A quick sort requires picking a pivot element within an array.  A pointer will 
be at either end of the array.  As both pointers move towards the center, elements 
that are larger than the pivot will be moved to the right side while elements that 
are less than the pivot are moved to the left side of the array.

Repeat this process to the elements that are on the left side of the pivot and on 
the right side.

Since this is a requires splitting the array in half each time, this is an log n 
run time.  Since there are n elements to go through, the Big O of time would be 
O(n log n).

Big O of space stays consistent as no new array is made to store the quick sorted 
array.

---
## Visual
![Quick Sort](/assets/quickSort.jpeg)

## Acknowledgments
Thanks to the [Hacker Rank Tutorial](https://www.youtube.com/watch?v=SLauY6PpjW4)

Thanks to the [Joe James Tutorial](https://www.youtube.com/watch?v=SLauY6PpjW4)

