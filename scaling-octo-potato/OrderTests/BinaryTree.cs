using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTests
{
    public class TreeNode<T> where T : IComparable
    {
        public T Value { get; set; }

        public TreeNode<T> Left { get; set; } 

        public TreeNode<T> Right { get; set; } 

    }
    public class BinaryTree<T> where T : IComparable
    {
        public TreeNode<T> RootNode { get; set; }

        /// <summary>
        /// Add value as leaf node
        /// </summary>
        /// <param name="Value"></param>
        public void AddNode(T value)
        {
            if (RootNode == null)
            {
                RootNode = new TreeNode<T>();
                RootNode.Value = value;
                return;
            }

            AddNode(RootNode, value);
        }

        private void AddNode(TreeNode<T> rootNode, T value)
        {
            if (value.CompareTo(rootNode.Value) < 0)
            {
                if (rootNode.Left == null)
                {
                    rootNode.Left = new TreeNode<T>();
                    rootNode.Left.Value = value;
                    return;
                }

                AddNode(rootNode.Left, value);
            }
            else
            {
                if (rootNode.Right == null)
                {
                    rootNode.Right = new TreeNode<T>();
                    rootNode.Right.Value = value;
                    return;
                }

                AddNode(rootNode.Right, value);
            }
        }


        public void DeleteNode(T value)
        { }
    }
}
