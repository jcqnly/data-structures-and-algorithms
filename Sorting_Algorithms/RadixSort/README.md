# Radix Sort
Given an array of numbers, sort it using a radix sort.

## Radix Sort Defined
The radix sort used deals with numbers.  The current code works with the least 
significant digit.  The LSD of every number is sorted, which would be in the 
one's place.  The next spot would be the 10's spot.  Those numbers would be 
sorted.  The max number of digits used is 3, so the final spot sorted would 
be the hundreds spot.

## Problem Solving Process
First the numbers in the single spot are sorted amongst each other.  If a 
has less digits than the max number of digits, the digits in that spot would 
be a "0".

## Visual
![Radix Sort](/assets/radixSort.jpeg)

## Acknowledgments
Thanks to this [tutorial](https://binged.it/2KlTWgt) for the overall picture.