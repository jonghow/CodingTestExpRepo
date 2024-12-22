//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/4158
////  * Time : 22m 
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

//        int _tc;
//        int _n; // 상근 CD 수
//        int _m; // 선영 CD 수

//        // _n, _m <= 1000000

//        HashSet<int> _hs_N;
//        HashSet<int> _hs_M;
        
//        int _left;
//        int _right;

//        public void solve()
//        {
//            _hs_N = new HashSet<int>();
//            _hs_M = new HashSet<int>();

//            string _inputRead = string.Empty;
//            string _endFlag = string.Empty;


//            while (true)
//            {
//                _ret = 0;
//                _hs_N.Clear();
//                _hs_M.Clear();
//                _inputRead = string.Empty;


//                string _input = Console.ReadLine();
//                if (_input == "0 0") 
//                    break;

//                string[] _inputSeperate = _input.Split(' ');

//                _n = int.Parse(_inputSeperate[0]);
//                _m = int.Parse(_inputSeperate[1]);

//                for (int i = 0; i < _n; ++i)
//                    _hs_N.Add(int.Parse(Console.ReadLine()));

//                for (int i = 0; i < _m; ++i)
//                    _hs_M.Add(int.Parse(Console.ReadLine()));

//                _left = 0;
//                _right = 0;

//                foreach (var val in _hs_N)
//                {
//                    if (_hs_M.Contains(val))
//                    {
//                        ++_ret;
//                    }
//                }

//                Console.WriteLine(_ret);
//            }
//        }
//    }
//}
