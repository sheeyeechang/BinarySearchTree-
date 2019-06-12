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
        Node rootNode = null;

        //constructor
        public BinarySearchTree(int data)
        {
            rootNode = new Node(data);
        }
        //method (CAN DO)  ----------------------------------------------------------------------------------------------------------
        public void Add(int data)
        {
            Node newChildNode = new Node(data);            //these varibale only in this method/scope
            Node currentNode;
            bool nodeInsert = false;

            if (rootNode == null)                       // start with rootNode
            {
                rootNode = newChildNode;
            }
            else
            {
                currentNode = rootNode;                     // need currentNode, use to track location in tree // this's the problem ex. 50 go the the newChildNode to the right
                while (nodeInsert == false)                         // while loop
                {              
                    if (newChildNode.data <= currentNode.data)               
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newChildNode;            //insert node
                            nodeInsert = true;
                        }
                        else if (rootNode.left != null)
                        {
                            currentNode = currentNode.left;

                        }
                    }
                    else if (newChildNode.data > currentNode.data)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = newChildNode;         
                            nodeInsert = true;
                        }
                        else if (currentNode.right != null)
                        {
                            currentNode = currentNode.right;          // // use node agai
                        }
                    }
                }
            }

            nodeInsert = false;
        }


        //    public void addNode(int x, Node root)
        //    {
        //        Node newNode = new Node(x);

        //        if (root == null)
        //        {
        //            root = newNode;
        //        }
        //        if (root.value == newNode.value)
        //        {
        //            return;
        //        }
        //        else if (newNode.value < root.value)
        //        {
        //            if (root.left == null)
        //            {
        //                root.left = newNode;
        //            }
        //            else
        //            {
        //                addNode(x, root.left);
        //            }
        //        }
        //        else if (newNode.value > root.value)
        //        {
        //            if (root.right == null)
        //            {
        //                root.right = newNode;
        //            }
        //            else
        //            {
        //                addNode(x, root.right);
        //            }
        //        }
        //    }
        //}


        //The left sub-tree of a node has a key less than or equal to its parent node's key. 
        //The right sub-tree of a node has a key greater than to its parent node's key.

        // search method  ------------------------------------------------------------------------------------------------------------
        public bool Search(int data, Node currentNode)
        {
            if (currentNode == null)
            {
                currentNode = rootNode;
            }

            if (currentNode.data == data)
            {
                return true;
            }

            if (data <= currentNode.data)
            {
                return Search(data, currentNode.left);
            }
            else
            {
                return Search(data, currentNode.right);
            }
        }

        //node search(node, key)
        //{
        //    if node is null then return null;
        //    if node.key = key then
        //    return node
        //    if key < node then
        //    return search(node.left, key);
        //    else
        //    return search(node.right, key);
        //}

    }
}
