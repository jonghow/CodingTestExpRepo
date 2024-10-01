//using System;
//using System.CodeDom;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
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
// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/2750
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
//        public int n;

//        public void solve()
//        {
//            n= Int32.Parse(Console.ReadLine());

//            List<int> list = new List<int>();

//            for(int i = 0; i < n; i++)
//            {
//                var input = Int32.Parse(Console.ReadLine());
//                list.Add(input);
//            }

//            list.Sort();

//            for(int i = 0; i < list.Count; ++i)
//                Console.WriteLine(list[i]);
//        }
//    }
//}

