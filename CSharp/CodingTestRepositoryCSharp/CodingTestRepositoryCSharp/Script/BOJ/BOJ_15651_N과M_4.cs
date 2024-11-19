//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/15652
////  * Time : 21m
//// */

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
//        public const int max = 9;
//        public int _n;
//        public int _m;

//        public int[] _arr;
//        public int[] _per;

//        public StringBuilder _sb;

//        public void solve()
//        {
//            _sb = new StringBuilder();
//            string[] _in = Console.ReadLine().Split(' ');

//            _n = int.Parse(_in[0].ToString());
//            _m = int.Parse(_in[1].ToString());

//            _arr = new int[max];

//            for (int i = 0; i < max; ++i)
//                _arr[i] = i + 1;

//            _per = new int[max];

//            dfs(0, 0, 0);

//            Console.Write(_sb.ToString());
//        }
//        public void dfs(int cnt, int pos, int prev)
//        {
//            if (cnt >= _m)
//            {
//                for (int i = 0; i < cnt; ++i)
//                {
//                    _sb.Append(_per[i]);

//                    if (i != cnt - 1)
//                        _sb.Append(" ");
//                }

//                _sb.AppendLine();
//            }
//            else
//            {
//                for (int i = 0; i < _n; ++i)
//                {
//                    if (_arr[i] < prev) continue;

//                    _per[pos] = _arr[i];
//                    dfs(cnt + 1, pos + 1, _arr[i]);
//                }
//            }
//        }
//    }
//}
