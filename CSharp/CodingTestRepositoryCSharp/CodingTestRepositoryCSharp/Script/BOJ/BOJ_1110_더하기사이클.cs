using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/1110
//  * Time : 35m
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
        // 0 ~ 99 
        public int _val;
        public int _ret;

        // 10보다 작다 => 0을 붙인다.

        public void solve()
        {
            _val = int.Parse(Console.ReadLine());
            _ret = 0;

            int _calc = _val;

            while(true)
            {
                ++_ret;

                int _valRet = 0;
                int _tempCalc = 0;
                bool _isLower10 = (_calc < 10) ? true : false;

                if (_isLower10)
                {
                    _tempCalc = _calc * 10;
                    _calc = _tempCalc;
                }

                int _val1 = _calc / 10; // 십의자리
                int _val2 = _calc % 10; // 일의자리

                int _val3 = (_val1 + _val2) >= 10 ? (_val1 + _val2) % 10 : _val1 + _val2;

                if (_isLower10)
                    _valRet = (_val1 * 10) + _val3;
                else
                    _valRet = (_val2 * 10) + _val3;

                if (_val == _valRet)
                    break;

                _calc = _valRet;
            }

            Console.WriteLine(_ret);
        }
    }
}
