//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/14246
////  * Time : 
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
//        public int _ret;
//        public int _n;
//        public int _k;

//        public int[] _arrAsc;

//        public HashSet<KeyValuePair<int,int>> _hs;

//        public void solve()
//        {
//            _ret = 0;
//            _hs = new HashSet<KeyValuePair<int, int>>();

//            _n = int.Parse(Console.ReadLine());
//            _arrAsc = new int[_n];
//            string[] _input = Console.ReadLine().Split(' ');

//            for(int i = 0; i < _input.Length; ++i)
//            {
//                _arrAsc[i] = int.Parse(_input[i]);
//            }

//            int _left = 0;
//            int _right = _n - 1;

//            _k = int.Parse(Console.ReadLine());

//            while (_left <= _right)
//            {
//                int _valAcc = 0;

//                for(int i = _left; i < _arrAsc.Length; ++i)
//                {
//                    _valAcc += _arrAsc[i];

//                    if(_valAcc > _k)
//                    {
//                        KeyValuePair<int, int> kv = new KeyValuePair<int, int>(_left, i);
//                        if (!_hs.Contains(kv))
//                        {
//                            _hs.Add(kv);
//                            ++_ret;
//                        }
//                    }
//                }

//                _valAcc = 0;
//                for (int i = _right; i >= 0; --i)
//                {
//                    _valAcc += _arrAsc[i];

//                    if (_valAcc > _k)
//                    {
//                        KeyValuePair<int, int> kv = new KeyValuePair<int, int>(i, _right);
//                        if (!_hs.Contains(kv))
//                        {
//                            _hs.Add(kv);
//                            ++_ret;
//                        }
//                    }
//                }

//                ++_left;
//                --_right;
//            }

//            Console.WriteLine(_ret);
//        }
//    }
//}