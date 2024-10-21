//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/1235
//  * Time : 1h 3m
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
//        public int n;
//        public int ret;
//        public List<string> list_number = new List<string>();

//        public List<string> list_sorted = new List<string>();

//        public char[,] _arr2Axis;

//        public void Solve()
//        {
//            ret = int.MaxValue ;
//            n = Int32.Parse(Console.ReadLine());
//            int _length = 0;
            
//            for(int i = 0; i < n; ++i)
//            {
//                string _in = Console.ReadLine();
//                _length = _in.Length;

//                if (_arr2Axis == null)
//                    _arr2Axis = new char[_in.Length, n];

//                for(int j = 0; j < _in.Length; ++j)
//                {
//                    _arr2Axis[j,i] = _in[j];
//                }
//            }

//            // 유동적이다 몇번재 번호가 주어지는지는.
//            // 다 9 자리 일 수도있고, 100번째일수도있음.

//            for (int i = _length-1  ; i >= 0; --i)
//            {
//                list_sorted.Clear();
//                for (int j = 0; j < n; ++j)
//                {
//                    string ret = string.Empty;
//                    for(int k = 0; k < _length - i; ++k)
//                    {
//                        ret += _arr2Axis[i+k,j];
//                    }

//                    list_sorted.Add(ret);
//                }

//                list_sorted.Sort();


//                bool _isPass = true;
//                for (int k = 0; k < list_sorted.Count - 1; ++k)
//                {
//                    if (list_sorted[k] == list_sorted[k + 1])
//                    {
//                        _isPass = false;
//                        break;
//                    }
//                }

//                if (_isPass == true)
//                {
//                    ret = _length - i;
//                    break;
//                }
//            }

//            print();
//        }

//        public void print()
//        {
//            Console.WriteLine(ret);
//        }
//    }
//}