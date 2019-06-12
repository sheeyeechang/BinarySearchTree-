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
            tree.Add(45);
            tree.Add(60);
            tree.Add(50);
            tree.Add(65);
            tree.Add(85);
            tree.Add(70);
            tree.Add(35);
            tree.Add(75);
            tree.Add(90);
            tree.Add(100);

            Node node = null;
            Console.WriteLine(tree.Search(10, node));
            Console.ReadLine();

        }
    }
}
