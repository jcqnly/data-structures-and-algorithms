# Merge 2 Singly Linked Lists

## Challenge
Given 2 singly linked lists, merge the two and return the newly merged list.
Our group decided to make a third list to store the merged list, which created a space complexity of O(N).
We started off by setting a Current pointer to both the heads of each lists.
First, we added the value of the 1st list to the 3rd list.  Then the first value of the 2nd list is added to the third list.
Then we started traversing through the 1st and 2nd lists as long as neither is null and added those values to the 3rd list.


## Solution
![Merge 2 Singly Linked List](/assets/KthElementFromEnd.jpg)