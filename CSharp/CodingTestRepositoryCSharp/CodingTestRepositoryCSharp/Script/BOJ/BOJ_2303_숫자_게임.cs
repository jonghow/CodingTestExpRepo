using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using static CodingTestProj.Program;

/*
 * Difficulty : 
 * URL : https://www.acmicpc.net/problem/2303
  * Time : 
 */


namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ss = new Solution();
            ss.Solve();
        }
    }

    public class Solution
    {
        public int n;

        public List<int>[] _list;

        int _lastNumb; // 일의 자리 숫자
        int _ret;

        public int[,] _arr;

        public void Solve()
        {
            _ret = 0;
            _lastNumb = 0;
            int n = Int32.Parse(Console.ReadLine());
            _arr = new int[n, 5];

            for (int i = 0; i < n; i++)
            {
                string[] _input = Console.ReadLine().Split(' ');

                for (int j= 0; j < _input.Length; ++j)
                    _arr[i,j] = int.Parse(_input[j]);
            }








        }

        public void combination(int[] _arr, int[] _com, int r, int pos,int depth)
        {
            if (r == 0)
                return;

            //com[depth] = _arr[pos];
            //combination(_arr, _com)


        }


        public void print()
        {

        }
    }
}

