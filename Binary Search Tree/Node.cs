using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        //member varibale  
        public int data;

        public Node linkedList;
        public Node right;
        public Node left;
        //constructor
        public Node(int data)
        {
            this.data = data;

            linkedList = null;
            right = null;
            left = null;
        }

        //method ----------------------------------------------------------------------------------------------------------
    }
}
