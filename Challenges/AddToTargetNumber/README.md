# Find Numbers That Add to a Target Number

## Find 2 Numbers That Add to a Target Number

### Input
[1, 8, 3, 2, 6], 10

### Output
8, 2

### Problem Solving Process
There are multiple ways to solve this. 

One strategy requires an O(N^2) solution in terms of time and an O(1) in terms of space.

The other strategy requires an O(N) in terms of time, but an O(N) in terms of space. The built in list is a good option.  A hashtable will work as well.

Another strategy involves 2 counters, but the array needs to be sorted. Time efficiency is O(n log n).

## Find 3 Numbers That Add to a Target Number

### Input
[1, 0, 4, 7, -2], 9

### Output
4, 7, -2
