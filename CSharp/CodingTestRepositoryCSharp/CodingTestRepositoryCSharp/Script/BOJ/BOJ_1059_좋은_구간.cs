//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * Difficulty : Easy ~ Middle
// * URL : https://www.acmicpc.net/problem/1059
//  * Time : 28m
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
//        public int L;
//        public int[] _arr;
//        public int _ret;
//        public int _n;

//        public void Solve()
//        {
//            L = Int32.Parse(Console.ReadLine());
//            _arr = new int[L];

//            string[] _in = Console.ReadLine().Split(' ');
//            for(int i = 0; i < _in.Length; ++i)
//                _arr[i] = int.Parse(_in[i]);

//            _n = Int32.Parse(Console.ReadLine());

//            Array.Sort(_arr);

//            // _n 을 포함하는 좋은 갯수를 구한다. 

//            if(Array.Exists(_arr, rhs => rhs == _n))
//                _ret = 0;
//            else
//            {
//                for(int i = 1; i < 1000 ; ++i)
//                {
//                    for(int j = i +1; j < 1001; ++j)
//                    {
//                        if ((i <= _n && j >= _n) == false)
//                            continue;
//                        //// 범위에없다면

//                        if (Array.Exists(_arr, rhs => rhs == _n) == true)
//                            continue;

//                        bool isPass = true;
//                        for(int k = i; k <= j; ++k)
//                        {
//                            if(Array.Exists(_arr,rhs => rhs == k ) == true)
//                            {
//                                isPass = false;
//                                break;
//                            }
//                            }
//                        }
//                        if (isPass == false)
//                            continue;

//                        ++_ret;
//                    }
//                }
//            }
//            print();
//        }

//        public void print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}