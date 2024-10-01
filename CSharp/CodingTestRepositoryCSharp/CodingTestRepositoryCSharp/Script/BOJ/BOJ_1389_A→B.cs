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
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/16953
// */


//namespace CodingTestProj
//{
//    internal class Program
//    {


//        static void Main(string[] args)
//        {
//            //Case 0 _ Short
//            Solution solution = new Solution();
//            solution.solve();
//        }
//    }
//    public class Solution
//    {
//        public int start;
//        public double target;

//        public double ret;
//        public Dictionary<double, double> dic;

//        public void solve()
//        {
//            dic = new Dictionary<double, double>();

//            string[] input = Console.ReadLine().Split(' ');

//            start = Convert.ToInt32(input[0].ToString());
//            target = Convert.ToInt64(input[1].ToString());

//            BFS();
//            Print();
//        }

//        public void BFS()
//        {
//            Queue<double> q = new Queue<double>();
//            q.Enqueue(start);

//            if (dic.ContainsKey(start) == false)
//                dic.Add(start, 1);

//            while (q.Count > 0)
//            {
//                var cur = q.Dequeue();

//                if (cur == target)
//                    break;

//                if (cur > target)
//                    continue;

//                var calc1 = (double)cur * (double)2;
//                var calc2 = double.Parse(cur.ToString() + "1");

//                if (calc1 <= target)
//                {
//                    q.Enqueue(calc1);

//                    if (dic.ContainsKey(calc1) == false)
//                    {
//                        var values = dic[cur] + 1;
//                        dic.Add(calc1, values);
//                    }
//                }

//                if (calc1 == target)
//                    break;

//                if (calc2 <= target)
//                {
//                    q.Enqueue(calc2);

//                    if (dic.ContainsKey(calc2) == false)
//                    {
//                        var values = dic[cur] + 1;
//                        dic.Add(calc2, values);
//                    }
//                }

//                if (calc2 == target)
//                    break;
//            }
//        }

//        public void Print()
//        {
//            ret = dic.ContainsKey(target) == false ? (double)(-1) : dic[target];
//            Console.WriteLine(ret);
//        }
//    }
//}

