//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;

///////*
////// * Difficulty : 
////// * URL : https://www.acmicpc.net/problem/15656
//////  * Time : 
/////
///// BOJ_15654_N과 M (7)
////// */
/////
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
//        public const int _max = 7;
//        public int _n;
//        public int _m;
//        public int[] _arr;
//        public int[] _per;

//        public StringBuilder _sb;

//        /*
//         * 
//         * 
//         * 
//        3 1
//        4 5 2
//         * 
//        4 2
//        9 8 7 1
//         * 
//         */

//        public void solve()
//        {
//            _sb = new StringBuilder();
//            string[] _in = Console.ReadLine().Split(' ');
//            _n = int.Parse(_in[0].ToString());
//            _m = int.Parse(_in[1].ToString());

//            _in = Console.ReadLine().Split(' ');
//            _arr = new int[_n];

//            for (int i = 0; i < _in.Length; ++i)
//                _arr[i] = Int32.Parse(_in[i]);

//            Array.Sort(_arr);

//            _per = new int[_m];
//            BT(0, _per);

//            Console.Write(_sb.ToString());
//        }
//        public int Sorted(int n, int m)
//        {
//            return n.CompareTo(m);
//        }

//        public void BT(int pos, int[] c)
//        {
//            if (pos >= _m)
//            {
//                _sb.AppendLine(string.Join(" ", c));
//            }
//            else if (pos == _arr.Length) return;
//            else
//            {
//                for (int i = 0; i < _arr.Length; ++i)
//                {
//                    c[pos] = _arr[i];
//                    BT(pos + 1, c);
//                }
//            }
//        }
//    }
//}

