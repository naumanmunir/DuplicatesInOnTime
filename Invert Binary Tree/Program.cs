using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invert_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tn = new TreeNode(4);
            tn.left = new TreeNode(2);
            tn.left.left = new TreeNode(1);
            tn.left.right = new TreeNode(3);
            tn.right = new TreeNode(7);
            tn.right.left = new TreeNode(6);
            tn.right.right = new TreeNode(9);

            var res = InvertTree(tn);

            Console.ReadLine();
        }

        static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            InvertTree(root.left);

            InvertTree(root.right);


            return root;
        }
    }
}
