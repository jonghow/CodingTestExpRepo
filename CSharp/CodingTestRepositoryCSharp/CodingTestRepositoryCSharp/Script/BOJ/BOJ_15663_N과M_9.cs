//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Middle
//// * URL : https://www.acmicpc.net/problem/15663
////  * Time : 38m
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
//        public int[] _arr;
//        public bool[] _isVisited;


//        public StringBuilder _sb;
//        public StringBuilder _sbc;

//        public HashSet<string> _hs;
//        public void solve()
//        {
//            _hs = new HashSet<string>();
//            string[] _input = Console.ReadLine().Split(' ');
//            _isVisited = new bool[_max];

//            _n = int.Parse(_input[0]);
//            _m = int.Parse(_input[1]);
//            _input = Console.ReadLine().Split(' ');
//            _sb = new StringBuilder();
//            _sbc = new StringBuilder();
//            _arr = new int[_n];
//            int[] _per = new int[_m];

//            for (int i = 0; i < _arr.Length; ++i)
//                _arr[i] = int.Parse(_input[i]);

//            Array.Sort(_arr);

//            BT(0, ref _per);
//            Console.Write(_sb.ToString());
//        }

//        public void BT(int cnt, ref int[] _c)
//        {
//            if (cnt == _m)
//            {
//                _sbc.Clear();

//                for (int i = 0; i < cnt; ++i)
//                {
//                    _sbc.Append(_c[i]);

//                    if (i != cnt - 1)
//                        _sbc.Append(' ');
//                }

//                if(_hs.Contains(_sbc.ToString()) == false)
//                {
//                    _hs.Add(_sbc.ToString());
//                    _sb.Append(_sbc.ToString());
//                    _sb.AppendLine();
//                }
//            }
//            else
//            {
//                for (int i = 0; i < _n; ++i)
//                {
//                    if (_isVisited[i] == false)
//                    {
//                        _c[cnt] = _arr[i];
//                        _isVisited[i] = true;
//                        BT(cnt + 1, ref _c);
//                        _isVisited[i] = false;
//                    }
//                }
//            }
//        }
//    }
//}