////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.ComponentModel.Design;
////using System.Diagnostics;
////using System.IO;
////using System.Linq;
////using System.Runtime.InteropServices;
////using System.Security.AccessControl;
////using System.Security.Authentication;
////using System.Security.Cryptography.X509Certificates;
////using System.Text;
////using System.Threading;
////using System.Threading.Tasks;
////using System.Web;
////using System.Xml.Linq;
////using static CodingTestProj.Program;

/////*
//// * URL : https://www.acmicpc.net/problem/1312
//// */

////namespace CodingTestProj
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            string[] inputs = Console.ReadLine().Split(' ');

////            int a = Int32.Parse(inputs[0]);
////            int b = Int32.Parse(inputs[1]);
////            int n = Int32.Parse(inputs[2]);

////            int ret = Solution.Prog(a,b,n);
////            Console.WriteLine(ret);
////        }
////    }

////    public static class Solution
////    {
////        public static int Prog(int a, int b, int n)
////        {
////            int ret = 0;
////            int mok = 0;

////            for (int i = 0; i < n; ++i)
////            {
////                a = (a % b) * 10;
////                mok = (a / b);
////            }

////            ret = mok;
////            return ret;
////        }
////    }
////}
