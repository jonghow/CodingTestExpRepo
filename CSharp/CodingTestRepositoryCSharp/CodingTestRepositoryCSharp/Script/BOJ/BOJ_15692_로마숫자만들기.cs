using System;
using System.Collections.Generic;
using System.Text;

/////*
//// * Difficulty : Middle ~ hard
//// * URL : https://www.acmicpc.net/problem/16922
////  * Time : 1h over
//// */

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solve();
        }
    }

    public class Solution
    {
        public const int maxValues = 50;
        public const int max = 20;
        public int _n;
        public int _m;
        public char[] _arr;
        public char[] _per;
        public bool[] _checkCnt;

        public int _ret = 0;

        public void solve()

        {
            _checkCnt = new bool[(maxValues * max) + 1];
            string _in = Console.ReadLine();
            _n = 4;
            _m = int.Parse(_in.ToString());

            _arr = new char[4];
            _arr[0] = 'I';
            _arr[1] = 'V';
            _arr[2] = 'X';
            _arr[3] = 'L';

            _per = new char[max];

            dfs(0, 0, 0);

            Console.Write(_ret);
        }

        public void dfs(int cnt, int pos, int calc)
        {
            if (cnt >= _m)
            {
                if (_checkCnt[calc] == false)
                {
                    _checkCnt[calc] = true;
                    ++_ret;
                }
            }
            else
            {

                for (int i = pos; i < _n; ++i)
                {
                    dfs(cnt + 1, i, calc + GetVal(_arr[i]));
                }
            }
        }

        public int GetVal(char a)
        {
            if (a == 'I')
                return 1;
            if (a == 'V')
                return 5;
            if (a == 'X')
                return 10;
            if (a == 'L')
                return 50;

            return 0;
        }
    }
}

