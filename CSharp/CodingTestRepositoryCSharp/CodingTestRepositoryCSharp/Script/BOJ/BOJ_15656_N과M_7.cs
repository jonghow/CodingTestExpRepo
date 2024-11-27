using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/15656
////  * Time : 
///
/// BOJ_15656_N과 M (7)
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
        public const int _max = 7;
        public int _n;
        public int _m;
        public int[] _arr;
        public int[] _per;

        public StringBuilder _sb;

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
            _sb = new StringBuilder(1000000000);
            string[] _in = Console.ReadLine().Split(' ');
            _n = int.Parse(_in[0].ToString());
            _m = int.Parse(_in[1].ToString());

            _in = Console.ReadLine().Split(' ');
            _arr = new int[_n];

            for (int i = 0; i < _in.Length; ++i)
                _arr[i] = Int32.Parse(_in[i]);

            List<int> _tempInt = new List<int>(_arr);
            _tempInt.Sort();
            _arr = _tempInt.ToArray();

            _per = new int[_m];
            BT(0, ref _per, 0, 0);

            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                writer.AutoFlush = true; 
                Console.SetOut(writer);  // Console.Out을 StreamWriter로 대체

                // 이제 Console.WriteLine은 StreamWriter를 통해 콘솔에 출력
                Console.Write(_sb.ToString());
            }
        }
        public int Sorted(int n, int m)
        {
            return n.CompareTo(m);
        }

        public void BT(int pos, ref int[] c, int cnt, int depth)
        {
            if (cnt >= _m)
            {
                for (int i = 0; i < cnt; ++i)
                {
                    _sb.Append(c[i]);

                    if (i != cnt - 1)
                        _sb.Append(" ");
                }

                _sb.AppendLine();
            }
            else if (pos == _arr.Length) return;
            else
            {
                for (int i = 0; i < _arr.Length; ++i)
                {
                    c[pos] = _arr[i];
                    BT(pos + 1, ref c, cnt + 1, depth + 1);
                }
            }
        }
    }
}
