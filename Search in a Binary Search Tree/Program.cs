using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_a_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tn = new TreeNode(4);
            tn.left = new TreeNode(2);
            tn.right = new TreeNode(7);
            tn.left.left = new TreeNode(1);
            tn.left.right = new TreeNode(3);

            var res = SearchBST2(tn, 0);

            Console.ReadLine();
        }

        static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;

            if (root.val == val)
                return root;

            if (val <= root.val)
            {
                SearchBST(root.left, val);
                SearchBST(root.right, val);
            }

            if (val > root.val)
            {
                SearchBST(root.right, val);
                SearchBST(root.left, val);

            }

            return root;
        }

        static TreeNode SearchBST2(TreeNode root, int val)
        {
            if (root == null) return null;

            if (root != null && val <= root.val)
            {
                while (root != null)
                {
                    if (val == root.val)
                        break;
                    else if (val <= root.val)
                    {
                        root = root.left;
                    }
                    else
                    {
                        root = root.right;
                    }
                }
            }
            if (root != null && val > root.val)
            {
                while (root != null)
                {
                    if (val == root.val)
                        break;
                    else if (val <= root.val)
                    {
                        root = root.left;
                    }
                    else
                    {
                        root = root.right;
                    }
                }
            }

            return root;
        }
    }
}
