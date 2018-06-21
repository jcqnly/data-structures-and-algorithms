# Multi Bracket Validation
Validate that a given string has a balanced number of brackets.
Return true if it is, otherwise return false.  Ignore any
non-brackets.

---

## Challenge
Brackets in this challenge can be the following:
```
() {} []
```
Check that a given string has a balanced number of brackets.
Balance in this scenario is as follows:
```
//INPUT
{}
//OUTPUT
TRUE

//INPUT
{}(){}
//OUTPUT
TRUE

//INPUT
[({}]
//OUTPUT
FALSE
```

---

## Problem Solving Process
The initial solution involved using a queue and I hope to solve
this challenge with that data structure.  Since there were no 
restrictions on having to use queues, I opted to follow Jermaine's
suggestion that involved looping through the given string and
comparing it to the count of left and right brackets.

---

## Solution

![Whiteboard Solution](/assets/BracketValidation.jpg)

---

## Future Goal
This challenge should be solved using a queue data structure.

---

## Acknowledgments
Thanks to Jermaine for his non-complicated method of solving this.

Thanks to Mario and Max for their teamwork in solving this challenge.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this amazing README layout.

