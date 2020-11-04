using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmiumLinkedList
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public Node NextNode;
        


        public Node(int data)
        {
            Data = data;
        }
    }
}
