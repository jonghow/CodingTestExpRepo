//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/1251
//  * Time : 43m
// */


////mobitel
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
//        public string _in;
//        public string _ret;

//        List<string> _sorted_list = new List<string>();

//        public void Solve()
//        {
//            _ret = string.Empty;
//            _in = Console.ReadLine();

//            for(int i = 1; i < _in.Length -1; ++i)
//            {
//                string copy = _in;
//                string _1 = copy.Substring(0, i);

//                for (int j= 1; (j+i) < _in.Length; ++j)
//                {
//                    string _2 = copy.Substring(i, j);
//                    string _3 = copy.Substring(j+1+(i-1),copy.Length-(1+j+(i-1)));

//                    char[] _1arr= _1.ToCharArray();
//                    char[] _2arr= _2.ToCharArray();
//                    char[] _3arr = _3.ToCharArray();

//                    Array.Reverse(_1arr);
//                    Array.Reverse(_2arr);
//                    Array.Reverse(_3arr);

//                    string __1 = new string(_1arr);
//                    string __2 = new string(_2arr);
//                    string __3 = new string(_3arr);

//                    string _combine = __1 + __2 + __3;

//                    _sorted_list.Add(_combine);
//                }
//            }

//            _sorted_list.Sort();

//            if (_sorted_list.Count > 0)
//                _ret = _sorted_list[0];

//            print();
//        }

//        public void print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}