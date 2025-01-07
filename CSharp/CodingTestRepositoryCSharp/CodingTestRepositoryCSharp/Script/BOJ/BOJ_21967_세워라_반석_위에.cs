using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/21967
//  * Time : 1h 14m
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
        public int _n;
        public int[] _arr;
        public void solve()
        {
            _n = int.Parse(Console.ReadLine());
            _arr = new int[_n];

            string[] _in = Console.ReadLine().Split(' ');

            for (int i = 0; i < _in.Length; ++i)
                _arr[i] = int.Parse(_in[i]);

            int _ret = int.MinValue;
            //Array.Sort(_arr); // 오름차순 정렬

            for (int i = 0; i < _arr.Length; ++i)
            {
                int _val = _arr[i];
                int _bsIdx = BinarySearch(_arr, i, _val);

                if (_bsIdx >= _ret)
                    _ret = _bsIdx;
            }

            Console.WriteLine(_ret);
        }

        public int BinarySearch(int[] arr, int left, int val)
        {
            int sleft = left;
            int right = _arr.Length - 1;

            while (sleft < right)
            {
                int mid = (sleft + right) / 2;

                int min = Math.Min(val, arr[mid]);
                int cur = Math.Max(val, arr[mid]);

                if(min +2 <= cur)
                    right = mid;
                else
                    sleft = mid + 1;
            }

            return sleft-left+1;
        }
    }
}
