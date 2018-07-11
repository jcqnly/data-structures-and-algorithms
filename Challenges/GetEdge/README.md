# Get Edges
A graph implementation involving edges

## Overview
Given a flight route and a map (displayed as a graph), determine 
if a direct trip is possible.  If there is, let the user know and its price. 
If not, tell the user there isn't a direct flight.

## Problem Solving Process
Since Edges is a property of the Node class and it now needs to have weights,
a dictionary is used because dictionaries hold key value pairs.  The key 
value pair in this challenge is a node and its weight for the Edge 
property in the Node class.

A tuple is then used in the GetEdge method, found in Graph.cs, to 
return a bool and the weight, the price in this case.  Tuples bind 
items of different types together, which makes it easier to return 
2 items 

## Whiteboard

A Graph represented as an adjacency list:

![graph edges](/assets/graphDirectFlight.jpg)

---

## Acknowledgments

Thanks to Earl Jay for introducing me to dictionaries.

Thanks to Collin for introducing me to tuples.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.