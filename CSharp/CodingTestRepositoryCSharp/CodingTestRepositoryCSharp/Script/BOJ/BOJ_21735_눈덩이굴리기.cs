using System;
using System.Collections.Generic;
using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/21735
////  * Time : 
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
        public int _n;
        public int _m;
        public int[] _arr;
        public int[] _per;

        public float _ret = 0;

        public void solve()
        {
            _ret = float.MinValue;
            string[] _in = Console.ReadLine().Split(' ');
            _n = int.Parse(_in[0].ToString());
            _m = int.Parse(_in[1].ToString());

            _in = Console.ReadLine().Split(' ');
            _arr = new int[_in.Length];

            for (int i = 0; i < _in.Length; ++i)
                _arr[i] = int.Parse(_in[i].ToString());

            dfs(0, 0, 1f, false);

            Console.Write(_ret);
        }

        public void dfs(int cnt, int pos, float calc, bool isThrow)
        {
            if (cnt >= _m || pos > _n)
            {
                if (_ret < calc)
                    _ret = calc;
            }
            else
            {
                for (int i = pos; i < _m; ++i)
                {
                    // 1번으로 수행했을 때, 
                    dfs(cnt + 1, i + 1, calc + _arr[i], false);

                    // 2번으로 수행했을 때,
                    float calcThrow = calc * 0.5f;
                    int valBasedLength = ((i + 1) >= _arr.Length) == true ? 0 : _arr[i + 1];
                    dfs(cnt + 1, i + 2,  (float)Math.Floor(calcThrow + valBasedLength), true);
                }
            }
        }
    }
}

