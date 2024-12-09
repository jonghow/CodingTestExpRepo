using System;
using System.Collections.Generic;
using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/15655
////  * Time : 11m 
//// */
///
namespace CodingTestProj
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
        public const int _max = 9;
        public const int _valmax = 10001;
        public int _n;
        public int _m;
        public int[] _arr;
        public int[] _per;

        public bool[] _isVisit;

        public HashSet<string> _hs;

        public StringBuilder _sb;
        public void solve()
        {
            _sb = new StringBuilder();
            _hs = new HashSet<string>();

            string[] _input = Console.ReadLine().Split(' ');
            _n = int.Parse(_input[0]);
            _m = int.Parse(_input[1]);

            _input = Console.ReadLine().Split(' ');

            _arr = new int[_n];
            _per = new int[_m];

            for(int i = 0; i < _input.Length; ++i)
            {
                _arr[i] = int.Parse(_input[i]);
            }

            Array.Sort(_arr);

            BT(0, ref _per, -1);

            Console.Write(_sb.ToString());
        }

        public void BT(int _cnt, ref int[] _c, int _prev)
        {
            if(_cnt == _m)
            {
                string _in = string.Empty;

                for(int i = 0; i < _cnt; ++i)
                {
                    _in += _c[i];

                    if (i != _cnt - 1)
                        _in += ' ';
                }

                if (_hs.Contains(_in) == false)
                {
                    _hs.Add(_in);
                    _sb.Append(_in);
                    _sb.AppendLine();
                }
            }
            else
            {
                for(int i = _cnt; i < _n; ++i)
                {
                    if (_prev >= _arr[i]) continue;

                    _c[_cnt] = _arr[i];
                    BT(_cnt + 1, ref _c, _arr[i]);
                }
            }
        }
    }
}

