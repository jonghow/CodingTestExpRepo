using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : 
// * URL : https://www.acmicpc.net/problem/19637
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
        public int _titleCnt;
        public int _chrCnt;
        public Dictionary<int, string> _dct_title;

        public int[] _arr;

        public StringBuilder _sb; 

        public void solve()
        {
            _sb = new StringBuilder();

            _dct_title = new Dictionary<int, string>();
            string[] _input;
            _input = Console.ReadLine().Split(' ');
            _titleCnt = int.Parse(_input[0]);
            _chrCnt = int.Parse(_input[1]);
            _arr = new int[_chrCnt];

            for (int i= 0; i < _titleCnt; i++){
                _input = Console.ReadLine().Split(' ');
                int _val = int.Parse(_input[1]);

                _dct_title.Add(_val, _input[0]);
            }// title

            for(int i = 0; i < _chrCnt; ++i){
                _arr[i] = int.Parse(Console.ReadLine());
            }
            //_chrCnt



        }

        public int BinarySearch(int[] arr, int val){
            int _ret = -1;
            return _ret;
        }
    }
}



