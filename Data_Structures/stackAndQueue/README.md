# Stack and Queue

## Overview
Stacks and queues are data structures that can be represented with nodes.

Stacks represent a FILO concept where the 
first element in will be the last element out.

On the other hand, queues represent a FIFO concept where the 
first element in will be the first element out.

---

## Challenge
Implement a push, pop and peek method for a stack.
Implement an enqueue, dequeue, and a peek method for a queue.

---


## Concepts Further Defined
**Stacks** allow elements to be taken from and added to the top.
The last element in will be the first element out.
Pushing an element means to add it to the top of the stack.
Popping an element means to remove the top element from the stack.
Peeking refers to having a look at what is the first element.
This is typically connected to the visual image of a stack of plates,
where the last plate stacked on top will be the first to be removed.
Push, pop and peek are all O(1) in time complexity.

**Queues** allow elements to be added to the rear, and it 
allows elements to be removed from the front.  Visually, the rear 
is on the left of the queue of elements while the front is the 
right side of the queue of elements.  Enqueue means to add an element
to the rear of the queue, while dequeue means to remove an element
from the front.  Finally,  peek refers to having a look at the front
node.  Enqueue, dequeue, and peek are all O(1) in time complexity.

---

## Use Cases
Use cases for stacks would be accessing a browser history.  The last page
viewed will be the first page displayed, if you chose to go backwards.
Another use case is for backtracking out or into a maze.  The last place you were
would be the first place you can go back to.

Use cases for queues would be a food ordering system.
The first order would be the first order served, ideally.
Another case is a ticketing system. The first person to order a ticket,
will be the first person to get a ticket.

---

## Implementation
Implementation was similar to that of a link list.
For stacks, we start off with pushing to a stack to get a stack work with.
A node class was established with a Top that is a node.

For queues, we start off by enqueueing to get a queue to work with.
A node class was established with a Rear and Front defined with nodes.

---

## Solution

Whiteboard:

![Stack and Queue](/assets/stackAndQueue.jpg)

---

## Acknowledgments
Thanks to Gayle McDowell and this [video](https://www.youtube.com/watch?v=wjI1WNcIntg) for the walk through of these concepts.

Thanks to [jaatay](https://github.com/jaatay) and [IndigoShock](https://github.com/IndigoShock) for working with me on this challenge.

Thanks to [Aiverson1011](https://github.com/Aiverson1011) for the guidance.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this amazing README layout.

