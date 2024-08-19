//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.AccessControl;
//using System.Security.Authentication;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

///*
// * URL : https://leetcode.com/problems/evaluate-boolean-binary-tree/description/
// */

//namespace CodingTestProj
//{
//    public class TreeNode
//    {
//        public int val;
//        public TreeNode left;
//        public TreeNode right;
//        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//        {
//            this.val = val;
//            this.left = left;
//            this.right = right;
//        }
//    }

//    /* Condition 
//     * 1 . FULL BT
//     * 
//     * 
//     * 
//     * 
//     */

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            TreeNode node1 = new TreeNode(3);
//            TreeNode node2 = new TreeNode(3);
//            TreeNode node3 = new TreeNode(2);
//            TreeNode node4 = new TreeNode(0);
//            TreeNode node5 = new TreeNode(0);
//            TreeNode node6 = new TreeNode(3);
//            TreeNode node7 = new TreeNode(2);
//            TreeNode node8 = new TreeNode(1);
//            TreeNode node9 = new TreeNode(3);
//            TreeNode node10 = new TreeNode(1);
//            TreeNode node11 = new TreeNode(1);
//            TreeNode node12 = new TreeNode(2);
//            TreeNode node13 = new TreeNode(1);
//            TreeNode node14 = new TreeNode(1);
//            TreeNode node15 = new TreeNode(1);


//            node1.left = node2;
//            node1.right = node3;

//            node2.left = node4;
//            node2.right = node5;

//            node3.left = node6;
//            node3.right = node7;

//            // 4 , 5 X
//            node6.left = node8;
//            node6.right = node9;

//            node7.left = node10;
//            node7.right = node11;

//            node9.left = node12;
//            node9.right = node13;

//            node12.left = node14;
//            node12.right = node15;

//            Solution solution = new Solution();
//            solution.EvaluateTree(node1);
//        }
//    }

//    public class Solution
//    {
//        public bool EvaluateTree(TreeNode root)
//        {
//            if (root.left == null && root.right == null)
//                return Convert.ToBoolean(root.val);

//            bool dd = DFS(root);
//            return dd;
//        }

//        public bool DFS(TreeNode root) 
//        {
//            if (root.left == null && root.right == null)
//                return false;

//            DFS(root.left);
//            DFS(root.right);

//            if (root.left == null && root.right == null)
//                return false;

//            switch(root.val)
//            {
//                case 2:
//                    root.val = (root.left.val == 0 && root.right.val == 0) ? 0 : 1;
//                    break;
//                case 3:
//                    root.val = (root.left.val == 1 && root.right.val == 1) ? 1 : 0;
//                    break;
//            }

//            return Convert.ToBoolean(root.val);
//        }
//    }
//}