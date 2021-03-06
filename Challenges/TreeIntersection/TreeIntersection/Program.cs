﻿using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //instantiate binary search tree 1
            BinarySearchTree BST1 = new BinarySearchTree();
            //declare nodes to add to BST1
            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(150);
            Node nodeD = new Node(75);
            Node nodeE = new Node(300);
            Node nodeF = new Node(25);

            BST1.Add(nodeA, nodeB);
            BST1.Add(nodeA, nodeC);
            BST1.Add(nodeA, nodeD);
            BST1.Add(nodeA, nodeE);
            BST1.Add(nodeA, nodeF);

            //instantiate binary search tree 2
            BinarySearchTree BST2 = new BinarySearchTree();
            //declare nodes to add to BST2
            Node nodeG = new Node(100);
            Node nodeH = new Node(50);
            Node nodeI = new Node(150);
            Node nodeJ = new Node(175);
            Node nodeK = new Node(400);
            Node nodeL = new Node(205);

            BST2.Add(nodeG, nodeH);
            BST2.Add(nodeG, nodeI);
            BST2.Add(nodeG, nodeJ);
            BST2.Add(nodeG, nodeK);
            BST2.Add(nodeG, nodeL);

            HashTable ht = new HashTable();
            //nodes need to be passed in because Breadth First Searches
            //need a node to start searching from
            ht = ht.TreeIntersection(BST1, nodeA, BST2, nodeG);
        }
    }
}
