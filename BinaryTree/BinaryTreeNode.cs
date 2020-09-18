using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public enum Side
    {
        Left,
        Right
    }

    public class BinaryTreeNode<T> where T : IComparable
    {
        public BinaryTreeNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }

        public BinaryTreeNode<T> LeftNode { get; set; }

        public BinaryTreeNode<T> RightNode { get; set; }

        public BinaryTreeNode<T> ParentNode { get; set; }

        public Side? NodeSide =>
            ParentNode == null
            ? (Side?)null
            : ParentNode.LeftNode == this
                ? Side.Left
                : Side.Right;

        public override string ToString() => Data.ToString();
    }
}
