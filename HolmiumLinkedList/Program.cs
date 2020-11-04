using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmiumLinkedList
{
    class Program
    {
        public BinarySearchTree binarySearchTree = new BinarySearchTree();
        static void Main(string[] args)
        {
            Node node1 = new Node(4);
            Node node2 = new Node(2);
            Node node3 = new Node(67);
            Node node4 = new Node(6);
            Node node5 = new Node(34);
            Node node6 = new Node(34);

            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(node1);
            binarySearchTree.Add(node2);
            binarySearchTree.Add(node3);
            binarySearchTree.Add(node4);
            binarySearchTree.Add(node5);
            binarySearchTree.Add(node6);
        }
    }
}
