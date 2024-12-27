//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy - Middle
//// * URL : https://www.acmicpc.net/problem/12234
////  * Time : 38m +
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
//        int _t;

//        int _n;
//        int _cap;

//        int[] _arr;

//        int _ret;

//        public void solve()
//        {
//            _t = int.Parse(Console.ReadLine());

//            int _left;
//            int _right;

//            string[] _input;
//            int _loopCount = 0;

//            while (_t > 0)
//            {

//                _input = Console.ReadLine().Split(' ');
//                _n = int.Parse(_input[0]);
//                _arr = new int[_n];
//                _cap = int.Parse(_input[1]);

//                _input = Console.ReadLine().Split(' ');

//                for (int i = 0; i < _input.Length; ++i)
//                    _arr[i] = int.Parse(_input[i]);

//                Array.Sort(_arr);
//                _left = 0;
//                _right = _n - 1;
//                _ret = 0;

//                while (_left <= _right)
//                {
//                    int _data = _arr[_left] + _arr[_right];

//                    if (_data <= _cap)
//                    {
//                        ++_left;
//                    }

//                    --_right;
//                    ++_ret;
//                }

//                Console.WriteLine($"Case #{_loopCount + 1}: {_ret}");
//                ++_loopCount;
//                --_t;
//            }
//        }
//    }
//}
