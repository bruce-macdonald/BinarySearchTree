using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolmiumLinkedList
{
    class BinarySearchTree
    {
        
        public Node RootNode { get; set; }
        
        public BinarySearchTree()
        {

        }
        public void Add(Node nodeToAdd)
        {
           
                if (RootNode == null)
                {
                    RootNode = nodeToAdd;
                }
            else
            {
                Node focusNode = RootNode;
                while (true)
                {
                    if (nodeToAdd.Data <= focusNode.Data)
                    {
                        if (focusNode.Left == null)
                        {
                            focusNode.Left = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.Left;
                        }
                        //go left
                    }
                    else if (nodeToAdd.Data > focusNode.Data)
                    {
                        if (focusNode.Right == null)
                        {
                            focusNode.Right = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.Right;
                        }
                        //go left
                    }

                }

            }

        }


        //public void Search(Node nodeToFind)
        //{
        //    for (int i = 0; i < binarySearchTree.Count; i++)
        //    {
        //        if (nodeToFind==binarySearchTree[])
        //        {
        //            binarySearchTree[];
        //        }
        //    }
        //}
        
    }
}
