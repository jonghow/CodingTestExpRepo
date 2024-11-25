using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/15656
////  * Time : 
///
/// BOJ_15654_N과 M (7)
//// */
///
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
        public const int _max = 8;
        public int _n;
        public int _m;
        public int[] _arr;
        public int[] _per;

        public HashSet<string> _ret;

        public StringBuilder _sb;
        public StringBuilder _compareSb;

        /*
         * 
         * 
         * 
        3 1
        4 5 2
         * 
        4 2
        9 8 7 1
         * 
         */

        public void solve()
        {
            _ret = new HashSet<string>();
            _sb = new StringBuilder();
            _compareSb = new StringBuilder();
            string[] _in = Console.ReadLine().Split(' ');
            _n = int.Parse(_in[0].ToString());
            _m = int.Parse(_in[1].ToString());

            _in = Console.ReadLine().Split(' ');
            _arr = new int[_n];

            for (int i = 0; i < _in.Length; ++i)
                _arr[i] = Int32.Parse(_in[i]);

            List<int> _tempInt = new List<int>(_arr);
            _tempInt.Sort(Sorted);
            _arr = _tempInt.ToArray();

            _per = new int[_m];
            BT(0, ref _per, 0, 0, "");

            Console.Write(_sb.ToString());
        }
        public int Sorted(int n, int m)
        {
            return n.CompareTo(m);
        }

        public void BT(int pos, ref int[] c, int cnt, int depth, string _s)
        {
            if (cnt >= _m)
            {
                _s = _s.Remove(0, 1);

                if (_ret.Contains(_s) == false)
                {
                    _ret.Add(_s);
                    _sb.Append(_s);
                    _sb.AppendLine();
                }
            }
            else if (pos == _arr.Length) return;
            else
            {
                for (int i = 0; i < _arr.Length; ++i)
                {
                    c[pos] = _arr[i];
                    BT(pos + 1, ref c, cnt + 1, depth + 1, _s + $" {_arr[i]}");
                }
            }
        }
    }
}

