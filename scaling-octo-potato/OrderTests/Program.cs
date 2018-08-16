using System;
using static System.Console;

namespace OrderTests
{

    class Program
    {
        static void arrayMethod(int[] a)
        {
            int[] b = new int[5];
            a[0] = 5;
            a = b;
        }

        //private static void Main(string[] args)
        //{

        //    int[] arr = new int[10];
        //    arrayMethod(arr);
        //    WriteLine(arr.Length);

        //    ReadKey();
        //    //BinaryTree<int> newTree = new BinaryTree<int>();
        //    //newTree.AddNode(4);
        //    //newTree.AddNode(1);
        //    //newTree.AddNode(5);
        //    //newTree.AddNode(2);
        //}
    }
}
