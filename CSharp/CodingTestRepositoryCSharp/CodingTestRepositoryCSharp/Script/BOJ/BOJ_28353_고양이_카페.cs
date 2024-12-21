//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Middle - Hard
//// * URL : https://www.acmicpc.net/problem/28353
////  * Time : 1h 6m +
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
//        int _n;
//        int _k;

//        int[] _arr;

//        int _left;
//        int _right;

//        int _retResult;

//        Dictionary<int,int> _dict_L;
//        Dictionary<int,int> _dict_R;

//        public void solve()
//        {
//            _dict_L = new Dictionary<int, int>();
//            _dict_R = new Dictionary<int, int>();
//            _retResult = int.MinValue;

//            string[] _input = Console.ReadLine().Split(' ');

//            _n = int.Parse(_input[0]);  
//            _k = int.Parse(_input[1]);

//            _arr = new int[_n];

//            _left = 0;
//            _right = _n -1;

//            _input = Console.ReadLine().Split(' ');

//            for(int i = 0; i < _arr.Length; i++)
//                _arr[i] = int.Parse(_input[i]);

//            Array.Sort(_arr);

//            int _sLeft = 0;
//            int _sRight = _n - 1;

//            int _val = 0;
//            int _val2 = 0;

//            while(_left < _right)
//            {
//                if (_arr[_right] >= _k)
//                {
//                    --_right;
//                    continue;
//                }

//                _sLeft = _left;
//                _sRight = _right;
//                _val = 0;
//                _val2 = 0;
//                _dict_L.Clear();
//                _dict_R.Clear();

//                int _cnt = 0;
//                int _temp=0;
//                int _temp2=0;

//                while(_sLeft < _sRight)
//                {
//                    _cnt++;

//                    if (_cnt == 2)
//                    {
//                        _val += _arr[_sLeft];
//                        _val2 += _arr[_sRight];

//                        if(_val <= _k)
//                        {
//                            _dict_L[_temp] = _sLeft;
//                            ++_sLeft;
//                        }

//                        if (_val <= _k)
//                        {
//                            _dict_R[_temp2] = _sRight;
//                            --_sRight;
//                        }

//                        _cnt = 0;
//                        _val = 0;
//                        _val2 = 0;
//                    }
//                    else
//                    {
//                        _temp = _sLeft;
//                        _val += _arr[_sLeft];
//                        _dict_L.Add(_sLeft, 0);
//                        ++_sLeft;

//                        _temp2 = _sRight;
//                        _val2 += _arr[_sRight];
//                        _dict_R.Add(_sRight, 0);
//                        --_sRight;
//                    }
//                }


//                int valCnt = 0;
//                int valCnt2 = 0;

//                foreach(var pair in  _dict_L)
//                {
//                    if (pair.Value == 0)
//                        ++valCnt;
//                }

//                foreach (var pair in _dict_R)
//                {
//                    if (pair.Value == 0)
//                        ++valCnt2;
//                }

//                int tempResult = _dict_L.Count + _dict_R.Count - (valCnt + valCnt2);

//                if (_retResult <= (tempResult))
//                    _retResult = (tempResult);

//                ++_left;
//                --_right;
//            }
//            // 5 20 
//            // 2 4 8 11 16

//            // 2 4 
//            // 한명이 버틸 수 있는 최대무게 K

//            // 6 10
//            // 3 4 5 6 7 9 

//            // 

//            Console.WriteLine(_retResult);
//        }
//    }
//}
