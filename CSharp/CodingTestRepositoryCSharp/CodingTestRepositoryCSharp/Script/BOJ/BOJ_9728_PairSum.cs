//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/9728
////  * Time : 13m
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
//        int _n; // 배열 사이즈
//        int _m; // 정수 M

//        int _loopCnt;
//        int[] _arr;
//        Dictionary<int, int> _dic;

//        public void solve()
//        {
//            _dic = new Dictionary<int, int>();
//            _loopCnt = int.Parse(Console.ReadLine());

//            for (int i = 0; i < _loopCnt; ++i)
//            {
//                string[] _input = Console.ReadLine().Split(' ');
//                _n = int.Parse(_input[0]);
//                _m = int.Parse(_input[1]);

//                _arr = new int[_n];
//                _input = Console.ReadLine().Split(' ');

//                for (int j = 0; j < _input.Length; ++j)
//                    _arr[j] = int.Parse(_input[j]);
//                // 데이터 설정

//                int _left = 0;
//                int _right = _arr.Length - 1;

//                while (_left < _right)
//                {
//                    if (_arr[_left] + _arr[_right] == _m)
//                    {
//                        if (_dic.ContainsKey(i) == false)
//                            _dic.Add(i, 0);

//                        _dic[i]++;
//                        ++_left;
//                    }
//                    else if (_arr[_left] + _arr[_right] < _m)
//                    {
//                        ++_left;
//                    }
//                    else
//                    {
//                        --_right;
//                    }
//                }
//            }

//            foreach (var pair in _dic)
//            {
//                int key = pair.Key;
//                int value = pair.Value;

//                Console.WriteLine($"Case #{key + 1}: {value}");
//            }
//        }
//    }
//}