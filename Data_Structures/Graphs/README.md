# Graphs
A graph is a non-linear data structure comprised of nodes, or points, and 
connected to each other by lines referred to as edges.

## Graphs Further Defined

#### Directed vs Undirected
Graphs with directed edges are like one-way streets while undirected edges are 
like two-way streets.

#### Complete vs Connected vs Disconnected
A complete graph is where all nodes are connected to other nodes.

A connected graph has nodes that have at least one edge.

A disconnected graph has nodes that may not have edges.

#### Cyclic vs Acyclic
A cyclic graph is a graph that has cycles, which is defined as a path of positive 
length that starts and ends at the same vertex.  A cycle is when a node can be 
traversed through and potentially end back at itself.

An acyclic graph is a graph that does not have cycles, like a binary tree.

#### Graph Representation
1. Adjacency Matrix
    - This is represented with a 2D array.  If there are _n_ nodes, then 
    the matrix is an _n_ x _n_ Boolean matrix.
2. Adjacency List
   - This list is a collection of linked lists or arrays that list all of the 
   other values that are connected.

#### Weighted Graphs
Weighted graphs have numbers assigned to its edges.  These numbers are called 
weights.  When depicted in an adjacency list, both the weight and the adjacent 
vertex must be included.

---

## Traversals

#### Breadth First Traversal
Breadth first traversal is when all nodes are visited, level by level, until 
all nodes have been visited.  Enqueue the root node.  Create a loop that will run 
while that root node still has nodes.  Dequeue the first node from the queue.  If 
that dequeued node has unvisited child nodes, mark the unvisited children as 
visited and re-insert them back in the queue.

#### Depth First Traversal
Depth first traversal doesn't traverse outwards like a BFS, rather the traversal 
goes deeper from one node, to one of its children, and its children's children.

---

## Use Cases
Graphs are used extensively in social networks, seggestions of products, maps 
and directions.

---

## Challenge
Implement a **Graph** as an adjacency list that has the following:

AddEdge(): adds a new vertice to the graph

GetNodes(): returns all the nodes in the graph as a collection

GetNeighbors(): returns a collection of nodes connected to the given node

Size(): returns the total number of nodes in the graph

BreadthFirst(): takes in a root node and returns a collection of all the nodes 
visited in order

---


## Visual

Graphs:

![](/assets/)

Graphs2

![](/assets/)

---

## Acknowledgments
Thanks to [Aiverson1011](https://github.com/Aiverson1011) for the guidance.

Thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this lovely README layout.