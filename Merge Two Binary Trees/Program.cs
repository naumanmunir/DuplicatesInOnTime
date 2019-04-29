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

            TreeNode tn2 = new TreeNode(1);
            tn2.left = new TreeNode(2);


            var res = MergeTrees(tn,tn2);
        }

        static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            var curr1 = t1;
            var curr2 = t2;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (curr2 != null || curr1 != null || stack.Count > 0)
            {
                while (curr1 != null || curr2 != null)
                {
                    if (curr1 != null && curr2 != null)
                        curr1.val += curr2.val;

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
                
                curr2 = stack.Pop();
                curr1 = stack.Pop();

                var tmpcurr1 = curr1.right;
                var tmpcurr2 = curr2.right;


                if (tmpcurr1 == null && tmpcurr2 != null)
                {
                    curr1.right = new TreeNode(0);
                }
                if (tmpcurr2 == null && tmpcurr1 != null)
                {
                    curr2.right = new TreeNode(0);
                }

                


                curr1 = curr1.right;
                curr2 = curr2.right;

            }

            return t1;
        }

        //static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        //{
        //    var curr1 = t1;
        //    var curr2 = t2;

        //    Stack<TreeNode> stack = new Stack<TreeNode>();

        //    while (curr2 != null || curr1 != null || stack.Count > 0)
        //    {
        //        while (curr1 != null || curr2 != null)
        //        {
        //            if (curr1 != null)
        //            {
        //                stack.Push(curr1);
        //                curr1 = curr1.left;
        //            }
        //            else
        //            {
        //                stack.Push(new TreeNode(0));
        //            }
        //            if (curr2 != null)
        //            {
        //                stack.Push(curr2);
        //                curr2 = curr2.left;
        //            }
        //            else
        //            {
        //                stack.Push(new TreeNode(0));
        //            }

        //        }

        //        curr2 = stack.Pop();
        //        curr1 = stack.Pop();

        //        var tmpcurr1 = curr1.right;
        //        var tmpcurr2 = curr2.right;


        //        if (tmpcurr1 == null && tmpcurr2 != null)
        //        {
        //            curr1.right = new TreeNode(0);
        //        }
        //        if (tmpcurr2 == null && tmpcurr1 != null)
        //        {
        //            curr2.right = new TreeNode(0);
        //        }

        //        curr1.val += curr2.val;


        //        curr1 = curr1.right;
        //        curr2 = curr2.right;

        //    }

        //    return t1;
        //}
    }
}
