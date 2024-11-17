//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/15649
////  * Time : X
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
//        public const int _max = 9;
//        public int _n;
//        public int _m;

//        public int[] _per;
//        public int[] _arr;

//        public int _curPos;

//        public bool[] _isVisit;

//        public StringBuilder _sb;

//        public void solve()
//        {
//            _sb = new StringBuilder();
//            string[] _input = Console.ReadLine().Split(' ');
//            _n = int.Parse(_input[0]);
//            _m = int.Parse(_input[1]);

//            _isVisit = new bool[_max];
//            _arr = new int[_max];
//            _per = new int[_max];

//            for (int i = 0; i < 9; ++i)
//                _arr[i] = i + 1;

//            dfs(0);
//            Console.WriteLine(_sb.ToString());
//        }

//        public void dfs(int _cnt)
//        {
//            if (_cnt >= _m)
//            {
//                for (int i = 0; i < _cnt; ++i)
//                {
//                    _sb.Append(_per[i]);

//                    if (i != _cnt-1)
//                        _sb.Append(" ");
//                }

//                _sb.AppendLine();
//            }
//            else
//            {

//                for (int i = 0; i < _n; ++i)
//                {
//                    if (_isVisit[i] == false)
//                    {
//                        _isVisit[i] = true;
//                        _per[_cnt] = _arr[i];
//                        dfs(_cnt + 1);
//                        _isVisit[i] = false;
//                    }
//                }
//            }
//        }
//    }
//}
