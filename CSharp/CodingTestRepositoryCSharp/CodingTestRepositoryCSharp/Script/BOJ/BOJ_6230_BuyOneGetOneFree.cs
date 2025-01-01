//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Middle
//// * URL : https://www.acmicpc.net/problem/6230
////  * Time : 1h 27m
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
//        public HashSet<string> _hs_ret;
//        public int _n;
//        public int _m;

//        public int[] _arrN;
//        public int[] _arrM;

//        public int _left;
//        public int _right;

//        public void solve()
//        {
//            _hs_ret = new HashSet<string>();
//            string[] _input = Console.ReadLine().Split(' ');
//            _n = int.Parse(_input[0]);
//            _m = int.Parse(_input[1]);

//            _arrN = new int[_n];
//            _arrM = new int[_m];

//            for (int i = 0; i < _n; ++i)
//                _arrN[i] = int.Parse(Console.ReadLine());

//            for (int i = 0; i < _m; ++i)
//                _arrM[i] = int.Parse(Console.ReadLine());

//            /*
//             *  A크기 건초베일 하나 살때 B 크기의 건초베일 무료로
//             *  N 고품질 배일 , M 저품질 베일
//             */
//            _left = 0;
//            _right = _n - 1;

//            // 제일 큰 수에서 가져오면 된다.

//            Array.Sort(_arrN, (int a, int b) => { return b.CompareTo(a); });
//            Array.Sort(_arrM, (int a, int b) => { return b.CompareTo(a); });

//            int _retResult = 0;

//            while(_left < _arrN.Length)
//            {
//                int _nArrElem = _arrN[_left];

//                for(int i = 0; i < _arrM.Length; ++i)
//                {
//                    int _mArrElem = _arrM[i];

//                    if (_nArrElem <= _mArrElem) continue;

//                    string _key = $"{i}"; // 인덱스로 넣음
//                    if(!_hs_ret.Contains(_key))
//                    {
//                        _hs_ret.Add(_key); // 저품질 건초 +
//                        break;
//                    }
//                }

//                ++_retResult; // 고급 건초 카운트
//                ++_left;
//            }

//            _retResult += _hs_ret.Count;
//            Console.WriteLine(_retResult);
//        }
//    }
//}
 