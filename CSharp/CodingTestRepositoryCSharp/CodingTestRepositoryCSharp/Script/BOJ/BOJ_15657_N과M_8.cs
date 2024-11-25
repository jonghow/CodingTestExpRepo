//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;

///////*
////// * Difficulty : Middle
////// * URL : https://www.acmicpc.net/problem/15657
//////  * Time : 38h
/////
///// BOJ_15657_N과 M (8)
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
//        public const int _max = 8;
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

//            _in = Console.ReadLine().Split(' ');
//            _arr = new int[_n];

//            for (int i = 0; i < _in.Length; ++i)
//                _arr[i] = Int32.Parse(_in[i]);

//            List<int> _tempInt = new List<int>(_arr);
//            _tempInt.Sort(Sorted);
//            _arr = _tempInt.ToArray();

//            _per = new int[_m];
//            BT(0, ref _per, 0, 0,-1);

//            Console.Write(_sb.ToString());
//        }
//        public int Sorted(int n, int m)
//        {
//            return n.CompareTo(m);
//        }

//        public void BT(int pos, ref int[] c, int cnt, int depth, int prev)
//        {
//            if (cnt >= _m)
//            {
//                for(int i = 0; i < cnt; ++i)
//                {
//                    _sb.Append(c[i]);

//                    if(i != cnt - 1)
//                        _sb.Append(" ");
//                }

//                _sb.AppendLine();
//            }
//            else if (pos == _arr.Length) return;
//            else
//            {
//                for (int i = 0; i < _arr.Length; ++i)
//                {
//                    if (_arr[i] < prev) continue;
//                    c[pos] = _arr[i];
//                    BT(pos+1, ref c, cnt + 1, depth + 1, _arr[i]);
//                }
//            }
//        }
//    }
//}

