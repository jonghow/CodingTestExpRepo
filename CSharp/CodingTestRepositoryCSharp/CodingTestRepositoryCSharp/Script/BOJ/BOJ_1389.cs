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
//using System.Runtime.InteropServices.WindowsRuntime;
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
// * URL : https://www.acmicpc.net/problem/1389
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
//        int n;
//        int m;

//        List<int>[,] maps;

//        public List<Tuple<int, int>> retList = new List<Tuple<int, int>>();

//        public void solve()
//        {
//            string[] input = Console.ReadLine().Split(' ');

//            n = Convert.ToInt32(input[0].ToString());
//            m = Convert.ToInt32(input[1].ToString());

//            maps = new List<int>[n, n];

//            for(int i = 0; i < m; ++i)
//            {
//                input = Console.ReadLine().Split(' ');

//                int start = Int32.Parse(input[0])-1;
//                int end = Int32.Parse(input[1])-1;

//                if(maps[start, end] == null)
//                    maps[start, end] = new List<int>();

//                maps[start, end].Add(end);
//            }

//            for(int i = 0; i < n; ++i)
//            {
//                for (int j = 0; j < n; ++j)
//                {
//                    if (i == j) continue;

//                    BFS(i,j, new bool[n,n]);
//                }
//            }

//            Print();
//        }

//        public void BFS(int start, int end, bool[,] visited)
//        {
//            Queue<int> q = new Queue<int>();
//            q.Enqueue(start);
//            visited[start, end] = true;

//            int ret = 0;
//            while(q.Count > 0)
//            {
//                var cur = q.Dequeue();

//                if (cur == end)
//                    break;

//                var count = maps[start, end] == null ? 0 : maps[start, end].Count;
//                for (int i = 0; i < count; ++i)
//                {
//                    var next = maps[start, end][i];

//                    if (visited[cur, next] == true)
//                        continue;

//                    visited[cur, next] = true;
//                    q.Enqueue(next);
//                    ++ret;
//                }
//            }

//            retList.Add(new Tuple<int,int>(start, ret));
//        }

//        public void Print()
//        {
//            if (retList.Count == 0)
//            {
//                Console.WriteLine(0);
//                return;
//            }


//            retList.Sort((Tuple<int, int> a1, Tuple<int, int> a2) =>
//            {

//                if (a1.Item2 == a2.Item2)
//                    return a2.Item1.CompareTo(a2.Item1);

//                return a2.Item2.CompareTo(a1.Item2);
//            });


//            Console.WriteLine(retList[0].Item1);
//        }
//    }
//}
