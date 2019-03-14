using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static BstNode Insert(BstNode root, int value)
        {
            var newNode = new BstNode(value);
            if (root == null)
                root = newNode;
            else if (value <= root.value)
                root.left = Insert(root.left, value);
            else
                root.right = Insert(root.right, value);
            return root;
        }
        static bool Search(BstNode root, int value)
        {
            if (root == null)
                return false;
            else if (root.value == value)
                return true;
            else if (root.value > value)
                return Search(root.left, value);
            else
                return Search(root.right, value);
        }
        public static int FindMin(BstNode root)
        {
            if (root.left == null)
                return root.value;
            else
                return FindMin(root.left);
        }
        public static int FindMax(BstNode root)
        {
            if (root.right == null)
                return root.value;
            else
                return FindMax(root.right);
        }
        public static int height(BstNode root)
        {
            if (root == null)
                return -1;
            if (root.left == null && root.right == null)
                return 0;
            return Math.Max(height(root.left), height(root.right)) + 1;
        }

        public static void levelOrder(BstNode root)
        {
            var q = new GenericDsQueue<BstNode>();
            if (root == null)
                return;

            q.Enqueue(root);
            while (!q.isEmpty())
            {
                var current = q.getFront();
                Console.Write(current.value.value + " ");
                if (current.value.left != null)
                    q.Enqueue(current.value.left);
                if (current.value.right != null)
                    q.Enqueue(current.value.right);
                q.Dequeue();
            }
        }
        static void PreOrder(BstNode root)
        {
            if (root != null)
                Console.Write(root.value + " ");
            if (root.left != null)
                PreOrder(root.left);
            if (root.right != null)
                PreOrder(root.right);
        }
        static void InOrder(BstNode root)
        {
            if (root == null)
                return;
            if (root.left != null)
                InOrder(root.left);
            Console.Write(root.value + " ");
            if (root.right != null)
                InOrder(root.right);
        }
        static void PostOrder(BstNode root)
        {
            if (root == null)
                return;
            if (root.left != null)
                PostOrder(root.left);
            if (root.right != null)
                PostOrder(root.right);
            Console.Write(root.value + " ");
        }
        static bool IsBST(BstNode root)
        {
            if (root == null)
                return true;
            if (IsSubtreeLesser(root.left, root.value)
                && IsSubtreeGreater(root.right, root.value)
                && IsBST(root.left)
                && IsBST(root.right))
                return true;
            else
                return false;
        }
        static bool IsSubtreeLesser(BstNode root, int value)
        {
            if (root == null)
                return true;
            if (root.value <= value
            && IsSubtreeLesser(root.left, value)
            && IsSubtreeLesser(root.right, value)
            )
                return true;
            else
                return false;

        }

        static bool IsSubtreeGreater(BstNode root, int value)
        { 
               if (root == null)
                return true;
            if (root.value > value
            && IsSubtreeGreater(root.left, value)
            && IsSubtreeGreater(root.right, value)
            )
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {

            BstNode root = null;
            root = Insert(root, 2);
            root = Insert(root, -25);
            root = Insert(root, 10);
            root = Insert(root, 4);
            root = Insert(root, -3);
            root = Insert(root, 20);
            root = Insert(root, 21);
            root = Insert(root, 0);
            root = Insert(root, 20);
            root = Insert(root, 25);
            root = Insert(root, 8);
            root = Insert(root, 12);
            Console.WriteLine(Search(root, 5));
            Console.WriteLine(Search(root, 10));
            Console.WriteLine(FindMin(root));
            Console.WriteLine(FindMax(root));
            Console.WriteLine(height(root));
            Console.WriteLine();
            levelOrder(root);
            Console.WriteLine();
            PreOrder(root);
            Console.WriteLine();
            InOrder(root);
            Console.WriteLine();
            PostOrder(root);
            Console.WriteLine();
            Console.WriteLine(IsBST(root));

        }
    }
}
