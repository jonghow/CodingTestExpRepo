//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Authentication;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

///*
// * URL : https://leetcode.com/problems/deepest-leaves-sum/
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // TC1. 
//            // Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
//            // Output: 15

//            TreeNode node1 = new TreeNode(1);
//            TreeNode node2 = new TreeNode(2);
//            TreeNode node3 = new TreeNode(3);
//            TreeNode node4 = new TreeNode(4);
//            TreeNode node5 = new TreeNode(5);
//            TreeNode node6 = new TreeNode(6);
//            TreeNode node7 = new TreeNode(7);
//            TreeNode node8 = new TreeNode(8);

//            node1.left = node2;
//            node1.right = node3;

//            node2.left = node4;
//            node2.right = node5;

//            node3.left = null;
//            node3.right = node6;

//            node4.left = node7;
//            node4.right = null;

//            node5.left = null;
//            node5.right = null;

//            node6.left = null;
//            node6.right = node8;

//            Solution solution = new Solution(); ;
//            int result = solution.DeepestLeavesSum(node1);
//            Console.WriteLine(result);
//        }

//        public class TreeNode
//        {
//            public int val;
//            public TreeNode left;
//            public TreeNode right;
//            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//            {
//                this.val = val;
//                this.left = left;
//                this.right = right;
//            }
//        }

//        public class Solution
//        {

//            public static int s_iFindDepth; // 깊이 값
//            public List<KeyValuePair<int, int>> depthValueList = new List<KeyValuePair<int, int>>(); // 깊이값에 대한 Value 값을 나타내기 위한 변수

//            public int DeepestLeavesSum(TreeNode root)
//            {
//                int resValue = 0;
//                s_iFindDepth = 0; // 으로 초기화

//                DFS(root, 0);

//                var findPair = depthValueList.FindAll(rhs => rhs.Key == s_iFindDepth);
//                for (int i = 0; i < findPair.Count; ++i)
//                {
//                    var Value = findPair[i].Value;
//                    resValue += Value;
//                }

//                return resValue;
//            }

//            public void DFS(TreeNode node, int depth) // 깊이 값
//            {
//                if (s_iFindDepth < depth)
//                {
//                    s_iFindDepth = depth; // Depth 값이 더 크다면 
//                }

//                int value = node.val;

//                depthValueList.Add(new KeyValuePair<int, int>(depth, value));

//                if (node.left != null)
//                    DFS(node.left, depth + 1);

//                if (node.right != null)
//                    DFS(node.right, depth + 1);
//            }
//        }
//    }
//}



