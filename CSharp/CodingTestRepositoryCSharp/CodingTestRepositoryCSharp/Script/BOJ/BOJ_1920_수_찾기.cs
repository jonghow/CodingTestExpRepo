//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/1920
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
//        public int _n;
//        public int _m;

//        public int[] _arr;
//        public int[] _candidate;

//        public void solve()
//        {
//            _n = int.Parse(Console.ReadLine());

//            _arr = new int[_n];
//            string[] _input = Console.ReadLine().Split(' ');

//            for (int i = 0; i < _input.Length; ++i)
//                _arr[i] = int.Parse(_input[i]);

//            // Array.Sort(_arr);
//            // 정렬

//            _m = int.Parse(Console.ReadLine());
//            _candidate = new int[_m];

//            _input = Console.ReadLine().Split(' ');

//            for (int i = 0; i < _input.Length; ++i)
//                _candidate[i] = int.Parse(_input[i]);
//            // Input..

//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < _candidate.Length; ++i)
//            {
//                if (BinarySearch(_arr, _candidate[i]) != -1)// Finds
//                    sb.Append(1);
//                else
//                    sb.Append(0);

//                sb.AppendLine();
//            }

//            Console.WriteLine(sb.ToString());
//        }

//        public int BinarySearch(int[] _arr, int _searchItem)
//        {
//            int _ret = -1;
//            int _left = 0;
//            int _right = _arr.Length - 1;

//            while (_left <= _right)
//            {
//                int mid = (_left + _right) / 2;

//                if (_arr[mid] == _searchItem)
//                {
//                    _ret = 1;
//                    break;
//                }
//                else if (_arr[mid] > _searchItem)
//                    _right = mid;
//                else if (_arr[mid] < _searchItem)
//                    _left = mid + 1;
//            }

//            return _ret;
//        }
//    }
//}
