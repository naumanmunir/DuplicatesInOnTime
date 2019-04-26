using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tn = new TreeNode(1);
            tn.left = new TreeNode(3);
            tn.right = new TreeNode(2);
            tn.left.left = new TreeNode(5);

            TreeNode tn2 = new TreeNode(2);
            tn2.left = new TreeNode(1);
            tn2.right = new TreeNode(3);
            tn2.right.right = new TreeNode(7);
            tn2.left.right = new TreeNode(4);

            var res = MergeTrees(tn,tn2);
        }
        static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            var curr1 = t1;
            var curr2 = t2;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (curr2 != null || curr1 != null || stack.Count > 0)
            {
                while (curr2 != null || curr1 != null)
                {
                    if (curr1 != null)
                    {
                        stack.Push(curr1);
                        curr1 = curr1.left;
                    }
                    else
                    {
                        stack.Push(new TreeNode(0));
                    }
                    if (curr2 != null)
                    {
                        stack.Push(curr2);
                        curr2 = curr2.left;
                    }
                    else
                    {
                        stack.Push(new TreeNode(0));
                    }

                }

                curr1 = stack.Pop();
                curr2 = stack.Pop();

                curr2.val += curr1.val;

                curr1 = curr1.right;
                curr2 = curr2.right;

                if (curr1 == null && curr2 != null)
                {
                    curr1 = new TreeNode(0);
                }
                if (curr2 == null && curr1 != null)
                {
                    curr2 = new TreeNode(0);
                }
            }




            return t1;
        }
    }
}
