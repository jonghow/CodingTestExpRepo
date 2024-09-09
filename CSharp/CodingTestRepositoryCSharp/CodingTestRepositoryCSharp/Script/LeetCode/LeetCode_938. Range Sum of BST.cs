using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

///*
// * URL : https://leetcode.com/problems/range-sum-of-bst/description/
// */

namespace CodingTestProj
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TreeNode root6 = new TreeNode(18, null, null);
            TreeNode root5 = new TreeNode(7, null, null);
            TreeNode root4 = new TreeNode(3, null, null);
            TreeNode root3 = new TreeNode(15, null, root6);
            TreeNode root2 = new TreeNode(5, root4, root5);
            TreeNode root1 = new TreeNode(10, root2, root3);

            int low = 7;
            int high = 15;
            Solution solu = new Solution();
            solu.RangeSumBST(root1,low,high);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public static int Ret;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            // low , high 의 모든 노드 값의 합
            Ret = 0;
            RootRecursion(root, low, high);
            return Ret;
        }

        public void RootRecursion(TreeNode curRoot, int low, int high)
        {
            if (curRoot == null) return;

            if(curRoot.val >= low && curRoot.val <= high)
                Ret += curRoot.val;

            RootRecursion(curRoot.left, low, high);
            RootRecursion(curRoot.right, low, high);
        }
    }
}







