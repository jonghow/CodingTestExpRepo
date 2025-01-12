using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

/*
 * Difficulty : 
 * URL : https://www.acmicpc.net/problem/11663
 * Time : 1h 28m ++
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

//10 5
//1 3 7 10 15 16 20 28 39 40
//1 2
//1 4
//1 10
//10 11
//15 20



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
                int _ret = 0;
                int _maxDot = _dot.Length - 1;
                if (_point[i].a > _dot[_maxDot] || _point[i].b < _dot[0])
                {

                }
                else
                {
                    _ret = BinarySearch(_dot, _point[i]);
                }
                _sb.Append(_ret.ToString());
                _sb.Append('\n');
            }
 
            Console.WriteLine(_sb.ToString());
        }

        public int BinarySearch(int[] _arr, Point _pt)
        {
            int left = 0;
            int right = _arr.Length - 1;

            int _leftIdx = 0;
            int _rightIdx = 0;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (_arr[mid] < _pt.a)
                {
                    left = mid + 1;
                }
                else
                {
                    _leftIdx = mid;
                    right = mid - 1;
                }
            }

            left = 0;
            right = _arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (_arr[mid] > _pt.b)
                {
                    right = mid -1;
                }
                else
                {
                    _rightIdx = mid;
                    left = mid + 1;
                }
            }

            return _rightIdx - _leftIdx +1;
        }
    }
}



