using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/2776
//  * Time : 13m
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
        public int _tc;
        public int _n;
        public int _m;

        public HashSet<int> _hs;
        public void solve(){

            // 수첩 1 => 하루동안 본 숫자
            // 수첩 2 => 봤다고 주장

            StringBuilder sb = new StringBuilder();
            _tc = int.Parse(Console.ReadLine());
            _hs = new HashSet<int>();

            while (_tc > 0)
            {
                _hs.Clear();
                //sb.Clear();
                _n = int.Parse(Console.ReadLine());
                string[] _input = Console.ReadLine().Split(' ');

                for(int i = 0; i < _input.Length; ++i)
                    _hs.Add(int.Parse(_input[i]));

                _m = int.Parse(Console.ReadLine());
                _input = Console.ReadLine().Split(' ');

                for (int i = 0; i < _input.Length; ++i)
                {
                    if (_hs.Contains(int.Parse(_input[i]))){
                        sb.AppendLine("1");
                    }
                    else{
                        sb.AppendLine("0");
                    }
                }

                --_tc;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}



