//using System;
//using System.CodeDom;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
//using System.Security.AccessControl;
//using System.Security.Authentication;
//using System.Security.Cryptography;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/3040
//  * Time : 2h over
// */


//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution solution = new Solution();
//            solution.solve();
//        }
//    }
//    public class Solution
//    {
//        int _count = 9;
//        int _target = 100;

//        bool _isPass = false;

//        public void solve()
//        {
//            int[] arr = new int[9];

//            for (int i = 0; i < _count; ++i)
//            {
//                int val = Int32.Parse(Console.ReadLine());
//                arr[i] = val;
//            }
            
//            int[] conbination = new int[7];
//            Combination(arr, conbination, 7, 0, 0);
//        }

//        public void Combination(int[] arr, int[] combination, int r, int pos, int depth)
//        {
//            if(r == 0)
//            {
//                int val = 0;

//                for(int i =0; i < combination.Length; ++i)
//                    val += combination[i];

//                if(val == 100)
//                {
//                    for (int i = 0; i < combination.Length; ++i)
//                        Console.WriteLine(combination[i]);
//                }
//            }
//            else if (depth == arr.Length)
//            {
//                return;
//            }
//            else
//            {
//                combination[pos] = arr[depth];

//                Combination(arr, combination, r - 1, pos + 1, depth + 1);
//                Combination(arr, combination, r  , pos, depth + 1);
//            }
//        }
//    }
//}

