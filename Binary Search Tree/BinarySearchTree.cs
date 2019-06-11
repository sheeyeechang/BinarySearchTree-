using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinarySearchTree
    {
        //member varibale (HAS A)
        public Node node;
        Node rootNode = null;

        //constructor
        public BinarySearchTree(int data)
        {
            node = new Node(data);
        }
        //method (CAN DO)  ----------------------------------------------------------------------------------------------------------
        public void Add(int data)
        {
            Node newChildNode = new Node(data);
            Node rootNode = new Node(data);
            if (rootNode == null)
            {
                newChildNode = rootNode;
            }
                                                    // while loop
            if(newChildNode.data <= rootNode.data)
            {
                node.left = newChildNode;
            }
            else if (node.left != null)
            {
                newChildNode = node.left;    //test
            }


            if (newChildNode.data > rootNode.data)
            {
                node.right = newChildNode;
            }
            else if (node.right != null)
            {

                newChildNode = node.right;
            }
        }

        //The left sub-tree of a node has a key less than or equal to its parent node's key. 
        //The right sub-tree of a node has a key greater than to its parent node's key.






        public void Search()
        {

        }
    }
}
