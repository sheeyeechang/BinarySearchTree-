using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree tree = new BinarySearchTree(50);
            tree.Add(55);
            tree.Add(60);
            tree.Add(50);
            tree.Add(65);
            tree.Add(85);
            tree.Add(70);
            tree.Add(80);
            tree.Add(75);
            tree.Add(90);
            tree.Add(100);
            //tree.Search(95);

        }
    }
}
