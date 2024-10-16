//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Net.NetworkInformation;
//using static CodingTestProj.Program;

///*
// * Difficulty : 
// * URL : https://www.acmicpc.net/problem/2303
//  * Time : 
// */


//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();
//            ss.Solve();
//        }
//    }

//    public class Solution
//    {
//        public int n;

//        public List<int>[] _list;

//        int _lastNumb; // 일의 자리 숫자
//        int _ret;

//        public int[][] _arr;

//        public void Solve()
//        {
//            _ret = 0;
//            _lastNumb = 0;
//            int n = Int32.Parse(Console.ReadLine());
//            _arr = new int[n][];

//            for(int i = 0; i < n; ++i)
//            {
//                _arr[i] = new int[5];
//            }

//            for (int i = 0; i < n; i++)
//            {
//                string[] _input = Console.ReadLine().Split(' ');

//                for (int j= 0; j < _input.Length; ++j)
//                    _arr[i][j] = int.Parse(_input[j]);
//            }

//            for(int i = 0; i < n; ++i)
//            {
//                int[] _c = new int[5];
//                combination(_arr[i], _c, 3, 0, 0, i+1);
//            }

//            print();
//        }

//        public void combination(int[] _arr, int[] _com, int r, int pos,int depth, int _person)
//        {
//            if (r == 0)
//            {
//                var _val1 = _com[0];
//                var _val2 = _com[1];
//                var _val3 = _com[2];

//                var ret = _val1 + _val2 + _val3;

//                while (ret >= 10)
//                {
//                    ret %= 10;
//                }

//                if (ret >= _lastNumb)
//                {
//                    _lastNumb = ret;

//                    //if (_ret <= _person)
//                        _ret = _person;
//                }

//                return;
//            }
//            else if (depth == _arr.Length)
//                return;
//            else
//            {
//                _com[pos] = _arr[depth];

//                combination(_arr, _com, r - 1, pos + 1, depth + 1, _person);
//                combination(_arr, _com, r, pos, depth + 1, _person);
//            }
//        }


//        public void print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}

