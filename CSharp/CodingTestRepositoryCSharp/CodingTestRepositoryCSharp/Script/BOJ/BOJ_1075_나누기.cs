using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;

///*
// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/1075
//  * Time : 23m
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
        public List<int> _retList = new List<int>();
        public int _ret;
        public int _n;
        public int _f;

        public void solve()
        {
            _n = int.Parse(Console.ReadLine());
            _f = int.Parse(Console.ReadLine());

            _ret = 99;

            int _nEnd = _n % 100;
            // 2자릿 수가 나옴

            _n -= _nEnd;

            for (int i = 0; i < 100; ++i)
            {
                int newN = _n + i;
                if (newN % _f == 0)
                {
                    if (_ret >= i)
                        _ret = i;
                }
            }

            Console.WriteLine(string.Format("{0:D2}", _ret));
        }
    }
}
