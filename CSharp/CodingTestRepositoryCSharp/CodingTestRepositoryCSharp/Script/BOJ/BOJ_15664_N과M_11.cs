using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/15665
//  * Time : 34mm
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
            int[] _per = new int[_m];

            for (int i = 0; i < _arr.Length; ++i)
                _arr[i] = int.Parse(_input[i]);

            Array.Sort(_arr);

            BT(0, ref _per,0);
            Console.Write(_sb.ToString());
        }

        public void BT(int pos, ref int[] _c, int depth)
        {
            if (pos == _m)
            {
                string _s = string.Empty;
                for (int i = 0; i < pos; ++i)
                {
                    _s += _c[i];

                    if (i != pos - 1)
                        _s += ' ';
                }

                if (_hs.Contains(_s) == false)
                {
                    _hs.Add(_s);
                    _sb.AppendLine(_s);
                }
            }
            else if (depth == _arr.Length) return;
            else
            {
                _c[pos] = _arr[depth];

                BT(pos + 1, ref _c, depth + 1);
                BT(pos, ref _c, depth + 1);
            }
        }
    }
}