//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/15651
////  * Time : 16m
//// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution solu = new Solution();
//            solu.solve();
//        }
//    }

//    public class Solution
//    {
//        public const int _max = 8;
//        public int _n;
//        public int _m;

//        public int[] _per;
//        public int[] _arr;

//        public int _curPos;

//        public StringBuilder _sb;

//        public void solve()
//        {
//            string[] _input = Console.ReadLine().Split(' ');
//            _n = int.Parse(_input[0]);
//            _m = int.Parse(_input[1]);
//            _sb= new StringBuilder();

//            _arr = new int[_max];
//            _per = new int[_max];

//            for (int i = 0; i < _max; ++i)
//                _arr[i] = i + 1;

//            dfs(0);
//            Console.Write(_sb.ToString());
//        }

//        public void dfs(int cnt)
//        {
//            if(cnt >= _m)
//            {
//                for(int i  = 0; i < cnt; ++i)
//                {
//                    _sb.Append(_per[i]);

//                    if(i != cnt -1)
//                        _sb.Append(' ');
//                }

//                _sb.AppendLine();
//            }
//            else
//            {
//                for(int i = 0; i < _n; ++i)
//                {
//                    _per[cnt] = _arr[i];
//                    dfs(cnt + 1);
//                }
//            }
//        }
//    }
//}
