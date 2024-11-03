using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;

///*
// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/1977
//  * Time : 8m 8s
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
        public List<int> _retList = new List<int>(); // 완전제곱수 모음

        public int _retSum;
        public int _retSmall;

        public int _n;
        public int _m;

        public void solve()
        {
            _retSmall = int.MaxValue;
            _n = int.Parse(Console.ReadLine());
            _m = int.Parse(Console.ReadLine());

            int idx = 0;
            while (true)
            {
                int _pow = (int)Math.Pow(idx, 2);

                if (_pow > _m)
                    break;

                if(_pow >= _n && _pow <= _m)
                {
                    _retList.Add(_pow);
                    _retSum += _pow;

                    if (_retSmall >= _pow)
                        _retSmall = _pow;


                }

                idx++;
            }

            if(_retList.Count > 0 )
            {
                Console.WriteLine(_retSum);
                Console.WriteLine(_retSmall);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
