//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/19637
//  * Time : 1h 26m
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution solu = new Solution();
//            solu.solve();
//        }
//    }

//    public class Solution
//    {
//        public int _titleCnt;
//        public int _chrCnt;
//        public Dictionary<int, string> _dct_title;
//        public const int CTCnt = 10000001;

//        public int[] _arr;

//        public StringBuilder _sb; 

//        public void solve()
//        {
//            _sb = new StringBuilder();

//            _dct_title = new Dictionary<int, string>();
//            for(int i = 0; i < CTCnt; i++)
//                _dct_title.Add(i, string.Empty);

//            string[] _input;
//            _input = Console.ReadLine().Split(' ');
//            _titleCnt = int.Parse(_input[0]);
//            _chrCnt = int.Parse(_input[1]);
//            _arr = new int[_chrCnt];

//            int min = 0; 
//            for (int i= 0; i < _titleCnt; i++){
//                _input = Console.ReadLine().Split(' ');
//                int _val = int.Parse(_input[1]);

//                for(; min <= _val; ++min)
//                {
//                    _dct_title[min] =_input[0];
//                }
//            }// title


//            for(int i = 0; i < _chrCnt; ++i){
//                _arr[i] = int.Parse(Console.ReadLine());
//            }
//            //_chrCnt

//            for(int i = 0; i < _arr.Length; ++i)
//            {
//                _sb.AppendLine(BinarySearch(_arr[i]));
//            }

//            Console.WriteLine(_sb.ToString());
//        }

//        public string BinarySearch(int val){
//            return _dct_title[val];
//        }
//    }
//}



