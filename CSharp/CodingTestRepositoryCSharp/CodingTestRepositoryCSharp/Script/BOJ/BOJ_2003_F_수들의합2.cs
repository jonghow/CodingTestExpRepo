//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/2003
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
//        int _n;
//        int _m;

//        int _left;
//        int _right;

//        int[] _arr;
//        public void solve()
//        {
//            string[] input = Console.ReadLine().Split(' ');
//            _n = int.Parse(input[0]);
//            _m = int.Parse(input[1]);

//            _arr = new int[_n];

//            //Array.Sort(_arr);

//            input = Console.ReadLine().Split(' ');

//            for (int i = 0; i < input.Length; i++)
//                _arr[i] = int.Parse(input[i]);

//            _left = 0;
//            _right = _arr.Length - 1;

//            int _rightMax = _arr.Length -1 ;

//            int _StandardLeft = 0;
//            int _StandardRight = 0;

//            int _addLeft = 0;
//            int _addRight = 0;

//            int _ret = 0;

//            while( _left <= (_rightMax * 0.5))
//            {
//                _StandardLeft = _left;
//                _StandardRight= _right;

//                _addLeft = 0;
//                _addRight = 0;

//                bool _isSuccess = false;

//                while (_StandardLeft <= (_rightMax* 0.5))
//                {
//                    _addLeft += _arr[_StandardLeft];

//                    if (_addLeft == _m)
//                    {
//                        ++_ret;
//                        _isSuccess = true;
//                        break;
//                    }
//                    else if (_addLeft > _m)
//                        break;
//                    else
//                        ++_StandardLeft;
//                }

//                if (_isSuccess && _StandardLeft == _StandardRight)
//                {
//                    ++_left;
//                    --_right;
//                    continue;
//                }

//                while (_StandardRight >= (_rightMax * 0.5))
//                {
//                    _addRight += _arr[_StandardRight];

//                    if (_addRight == _m)
//                    {
//                        ++_ret;
//                        break;
//                    }
//                    else if (_addRight > _m)
//                        break;
//                    else
//                        --_StandardRight;
//                }

//                ++_left;
//                --_right;
//            }

//            Console.WriteLine(_ret);
//        }
//    }
//}