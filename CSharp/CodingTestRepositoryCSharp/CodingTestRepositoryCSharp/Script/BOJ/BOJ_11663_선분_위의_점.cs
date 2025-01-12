using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

/*
 * Difficulty : 
 * URL : https://www.acmicpc.net/problem/11663
 * Time : 
 */

public struct Point
{
    public int a;
    public int b;

    public Point(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}

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
        public int _n;
        public int _m;

        public int[] _dot;
        public Point[] _point;

        public StringBuilder _sb;

        public void solve(){
            _sb = new StringBuilder();
            string[] _input = Console.ReadLine().Split(' ');
            _n = int.Parse(_input[0]);
            _m = int.Parse(_input[1]);

            _dot = new int[_n];
            Array.Sort(_dot);

            _input = Console.ReadLine().Split(' ');
            for(int i = 0; i < _n; ++i)
                _dot[i] = int.Parse(_input[i]);

            _point = new Point[_m];

            for(int i = 0; i < _m; ++i)
            {
                _input = Console.ReadLine().Split(' ');
                _point[i].a = int.Parse(_input[0]);
                _point[i].b = int.Parse(_input[1]);
            }

            for(int i = 0; i < _point.Length; ++i)
            {
                int _ret = BinarySearch(_dot, _point[i]);
                _sb.AppendLine(_ret.ToString());
            }
 
            Console.WriteLine(_sb.ToString());
        }

        public int BinarySearch(int[] _arr, Point _pt)
        {
            int left = 0;
            int right = _arr.Length - 1;
            int _ret = 0;

            while(left < right)
            {
                int mid = (left + right) / 2;

                int calcleft = (left == 0) ? 0 : left - 1;

                if (_arr[calcleft] <= _pt.a && _arr[right] >= _pt.b)
                {
                    _ret = right - left +1;
                    break;
                }
                else if (_arr[left] < _pt.a)
                {
                    left = left + 1;
                }
                else
                    right = mid + 1;
            }

            return _ret;
        }
    }
}



