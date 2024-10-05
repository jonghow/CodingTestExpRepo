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
// * URL : https://www.acmicpc.net/problem/19532
// * Time : 1h Over
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
//        public decimal a;
//        public decimal b;
//        public decimal c;
//        public decimal d;
//        public decimal e;
//        public decimal f;

//        /*
//         * ax+by = c
//         * dx+ey = f
//         */
//        public void solve()
//        {
//            string[] input = Console.ReadLine().Split(' '); 

//            a = decimal.Parse(input[0]) == 0 ? 1 : decimal.Parse(input[0]);
//            b = decimal.Parse(input[1]) == 0 ? 1 : decimal.Parse(input[1]);
//            c = decimal.Parse(input[2]) == 0 ? 1 : decimal.Parse(input[2]);
//            d = decimal.Parse(input[3]) == 0 ? 1 : decimal.Parse(input[3]);
//            e = decimal.Parse(input[4]) == 0 ? 1 : decimal.Parse(input[4]);
//            f = decimal.Parse(input[5]) == 0 ? 1 : decimal.Parse(input[5]);

//            // x 기준으로 맞추자.
//            decimal y = (decimal)((((c*d) /a)- f) / ((b * d / a) - e));
//            decimal x = (decimal)(((((c * e) / (b)) - f)) / (((a * e) / b) - d));

//            if (x < -999 || x > 999 || y < -999 || y > 999) return;

//            Console.Write($"{(int)x} {(int)y}");
//        }
//    }
//}

