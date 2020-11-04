using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmiumLinkedList
{
    class LinkedList
    {
        public Node RootNode { get; set; }
        public Node LastNode { get; set; }

        public LinkedList()
        {
            RootNode = null;
        }

        public void Add(Node nodeToAdd)
        {
            //if(RootNode == null)
            //{
            //    RootNode = nodeToAdd;
            //    LastNode = RootNode;
            //}
            //else
            //{
            //    LastNode.NextNode = nodeToAdd;
            //    LastNode = LastNode.NextNode;
            //}
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node focusNode = RootNode;
                while (true)
                {
                    if (focusNode.NextNode == null)
                    {
                        focusNode.NextNode = nodeToAdd;
                        break;
                    }
                    else
                    {
                        focusNode = focusNode.NextNode;
                    }
                }

            }
        }
    }
}
