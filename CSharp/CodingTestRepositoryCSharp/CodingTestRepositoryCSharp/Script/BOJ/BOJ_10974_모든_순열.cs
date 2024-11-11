using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/10974
//  * Time : 1h over
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
        public List<int> _retList = new List<int>();
        public int[] _arr;
        public int _ret;

        public int n;
        public bool[] _isVisited;

        public List<string> _list   = new List<string>();

        public void solve()
        {
            n = int.Parse(Console.ReadLine());
            _arr = new int[n];
            _isVisited = new bool[n];

            for (int i = 0; i < n; ++i)
                _arr[i] = i + 1;

            int[] com = new int[n];
            Combination(ref _arr, 0, ref com, n, 0);

            _list.Sort();
            for(int i = 0; i< _list.Count; ++i)
                Console.WriteLine(_list[i]); 
        }
        public void Combination(ref int[] arr, int _pos, ref int[] com, int r, int _depth)
        {
            if (r <= 0)
            {
                string s = string.Empty;
                for (int i = 0; i < com.Length; ++i)
                {
                    var val = com[i];
                    s += val.ToString() + " ";

                    if (i == com.Length - 1)
                    {
                        //Console.Write($"{com[i]}");
                        //Console.WriteLine();
                    }
                    else
                    {
                        //Console.Write($"{com[i]} ");
                    }
                }
                _list.Add(s);
                return;
            }
            else if (com.Length == _depth) return;
            else
            {
                for (int i = _pos; i < n; ++i)
                {
                    swap(ref _arr, i, _depth);
                    com[_pos] = arr[_depth];
                    Combination(ref arr, _pos + 1, ref com, r - 1, _depth + 1);
                    swap(ref _arr, i, _depth);
                }
            }
        }

        public void swap(ref int[] arr, int i , int j )
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
