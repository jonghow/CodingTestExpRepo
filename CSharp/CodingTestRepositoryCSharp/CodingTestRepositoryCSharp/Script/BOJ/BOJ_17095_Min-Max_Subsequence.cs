using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : 
// * URL : https://www.acmicpc.net/problem/17095
//  * Time : 01h 02m + 
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

        public int[] _arr;

        public int _retVal; // 가장 큰 값
        public int _retLength; //  출력 밸류

        public void solve()
        {
            _n = int.Parse(Console.ReadLine());
            _arr = new int[_n];

            //string[] _input = new string[100001];
            //for (int i = 0; i < _n; ++i)
            //    _input[i] = "0";

            string[] _input = Console.ReadLine().Split(' ');

            for (int i = 0; i < _n; ++i)
                _arr[i] = int.Parse(_input[i]);

            _retVal = int.MinValue;
            _retLength = int.MaxValue;

            int _addRange;
            _left = 0;
            _right = _n - 1;

            int _fixRight = _right;

            while (_left < _right)
            {
                _addRange = 0;

                while ((_left+_addRange) < _fixRight)
                {
                    int calcValue = Math.Abs(_arr[_left] - _arr[_left + _addRange]);
                    int calcIndex = _addRange + 1;

                    if (_retVal <= calcValue)
                    {
                        if (_retVal != calcValue)
                        {
                            _retLength = calcIndex;
                        }
                        else
                        {
                            _retLength = _retLength >= calcIndex ? calcIndex : _retLength;
                        }
                        _retVal = calcValue;
                    }

                    ++_addRange;
                }
                // 왼쪽 기준으로 서치

                _addRange = 0;
                while ((_right + _addRange) >= 0)
                {
                    int calcValue = Math.Abs(_arr[_right] - _arr[_right + _addRange]);
                    int calcIndex = Math.Abs(_addRange) + 1;

                    if (_retVal <= calcValue)
                    {
                        if (_retVal != calcValue)
                        {
                            _retLength = calcIndex;
                        }
                        else
                        {
                            _retLength = _retLength >= calcIndex ? calcIndex : _retLength;
                        }

                        _retVal = calcValue;
                    }

                    --_addRange;
                }
                // 오른쪽 기준으로 서치

                ++_left;
                --_right;
            }

            Console.WriteLine(_retLength);
        }
    }
}
