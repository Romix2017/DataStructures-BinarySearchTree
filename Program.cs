using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            tree.Add(4);

            PrintTree(tree.Preorder());
            PrintTree(tree.PostOrder());
            PrintTree(tree.InOrder());
        }

        static void PrintTree(List<int> tree)
        {
            foreach (var item in tree)
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();
        }
    }
}
