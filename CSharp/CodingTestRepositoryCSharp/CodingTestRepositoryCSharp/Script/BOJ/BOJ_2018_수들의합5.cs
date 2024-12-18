using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/2018
//  * Time : 30m
// */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            solu.solve();
        }
    }

    public class Solution
    {
        public int _n;
        public int _left;
        public int _right;
        public int _ret;

        public int[] _arr;

        public void solve()
        {
            _n = int.Parse(Console.ReadLine());
            _left = 0;
            _right = _n-1;
            _ret = 0;
            _arr = new int[_n];

            for(int i= 0; i < _n; i++)
            {
                _arr[i] = i+1;
            }

            int _leftAdd = 0;
            int _rightAdd = 0;

            int _standardLeft = 0;
            int _standardRight = 0;
            // 기준 인덱스

            while(_left < (_n * 0.5))
            {
                _standardLeft = _left;
                _standardRight = _right;
                _leftAdd = 0;
                _rightAdd = 0;

                while (_standardLeft < (_n * 0.5))
                {
                    _leftAdd += _arr[_standardLeft];

                    if (_leftAdd == _n)
                    {
                        ++_ret;
                        break;
                    }
                    else if (_leftAdd > _n)
                        break;
                    else
                        ++_standardLeft;
                }
                // Left

                while(_standardRight > (_left))
                {
                    _rightAdd += _arr[_standardRight];

                    if (_rightAdd == _n)
                    {
                        ++_ret;
                        break;
                    }
                    else if (_rightAdd > _n)
                        break;
                    else
                        --_standardRight;
                }
                // Right

                ++_left;
                --_right;
            }

            Console.WriteLine(_ret);
        }
    }
}