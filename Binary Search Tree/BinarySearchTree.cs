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

        public bool nodeInsert = false;

        //constructor
        public BinarySearchTree(int data)
        {
            rootNode = new Node(data);
            node = rootNode;

        }
        //method (CAN DO)  ----------------------------------------------------------------------------------------------------------
        public void Add(int data)
        {
            Node newChildNode = new Node(data);
            if (rootNode == null)
            {
                newChildNode = rootNode;
            }
            while (nodeInsert == false)                         // while loop
            {
                if (newChildNode.data == rootNode.data)               // fix the equal
                {
                    if (node.left == null)
                    {
                        node.left = newChildNode;
                        newChildNode = node.left;       //reassign variable
                        nodeInsert = true;
                    }
                    else if (node.left != null && newChildNode.data < node.left.data)
                    {
                        node = node.left;           // use node again
                                                    //test
                    }
                    else if (node.left != null && newChildNode.data > node.left.data)
                    {
                        node = node.right;           // use node again
                                                    //test
                    }
                }
                else if (newChildNode.data < rootNode.data)               // fix the equal
                {
                    if (node.left == null)
                    {
                        node.left = newChildNode;
                        newChildNode = node.left;       //reassign variable
                        nodeInsert = true;
                    }
                    else if (node.left != null)
                    {
                        node = node.left;           // use node again
                                                      //test
                    }
                }
                else if (newChildNode.data > rootNode.data)
                {
                    if (node.right == null)
                    {
                        node.right = newChildNode;
                        newChildNode = node.right;          // reassign variable
                         nodeInsert = true;
                    }
                    else if (node.right != null)
                    {
                        node = node.right;          // // use node again

                    }
                }
            }
            nodeInsert = false;

        }

        //The left sub-tree of a node has a key less than or equal to its parent node's key. 
        //The right sub-tree of a node has a key greater than to its parent node's key.




        public void Search()
        {

        }
    }
}
