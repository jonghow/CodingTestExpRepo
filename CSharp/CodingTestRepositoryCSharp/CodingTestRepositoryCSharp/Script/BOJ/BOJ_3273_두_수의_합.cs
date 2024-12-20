//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Middle
//// * URL : https://www.acmicpc.net/problem/3273
////  * Time : 20m
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
//        public int _m;
//        public int[] _arr;

//        public int _left;
//        public int _right;
//        public void solve()
//        {
//            _n = int.Parse(Console.ReadLine());

//            _arr = new int[_n];

//            string[] _input = Console.ReadLine().Split(' ');

//            for(int i =0; i < _n; ++i)
//                _arr[i] = int.Parse(_input[i]);

//            Array.Sort(_arr);

//            _m  = int.Parse(Console.ReadLine());

//            _left = 0;
//            _right = _n - 1;

//            while(_left < _right)
//            {
//                if(_arr[_left] + _arr[_right] == _m)
//                {
//                    ++_ret;
//                    ++_left;
//                    --_right;
//                }
//                else if (_arr[_left] + _arr[_right] < _m)
//                {
//                    ++_left;
//                }
//                else
//                {
//                    --_right;
//                }
//            }

//            Console.WriteLine(_ret);
//        }
//    }
//}
