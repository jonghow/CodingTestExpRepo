using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : 
// * URL : https://www.acmicpc.net/problem/2992
//  * Time : 
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
        public const int _max = 8;
        public int _n;
        public int _m;
        public int[] _arr;
        public bool[] _visit;

        public StringBuilder _sb;
        public HashSet<string> _hs;
        public void solve()
        {
            _hs = new HashSet<string>();
            string[] _input = Console.ReadLine().Split(' ');

            _n = int.Parse(_input[0]);
            _m = int.Parse(_input[1]);

            _input = Console.ReadLine().Split(' ');
            _visit = new bool[_max];
            _sb = new StringBuilder();
            _arr = new int[_n];
            int[] _c = new int[_m];

            for (int i = 0; i < _arr.Length; ++i)
                _arr[i] = int.Parse(_input[i]);

            Array.Sort(_arr);

            BT(0, ref _c, -1);
            Console.Write(_sb.ToString());
        }

        public void BT(int pos, ref int[] _c, int _Prev)
        {
            if (pos == _m)
            {
                string _s = string.Empty;

                for (int i = 0; i < _c.Length; ++i)
                {
                    _s += _c[i];

                    if (i != _c.Length - 1)
                        _s += ' ';
                }

                if (!_hs.Contains(_s))
                {
                    _hs.Add(_s);
                    _sb.Append(_s);
                    _sb.AppendLine();
                }
            }
            else
            {
                for (int i = 0; i < _n; ++i)
                {
                    if (_arr[i] < _Prev) continue;

                    _c[pos] = _arr[i];
                    BT(pos + 1, ref _c, _arr[i]);
                }
            }
        }
    }
}