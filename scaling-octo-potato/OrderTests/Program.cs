using System;

namespace OrderTests
{
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree<int> newTree = new BinaryTree<int>();
            newTree.AddNode(4);
            newTree.AddNode(1);
            newTree.AddNode(5);
            newTree.AddNode(2);
        }
    }
}
