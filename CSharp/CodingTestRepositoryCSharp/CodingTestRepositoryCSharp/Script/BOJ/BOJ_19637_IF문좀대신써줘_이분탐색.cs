//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Middle
//// * URL : https://www.acmicpc.net/problem/19637
////  * Time : 1h 26m
//// */

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
//        public List<KeyValuePair<int, string>> _lst_kvt;
//        public const int CTCnt = 10000001;

//        public int[] _arr;

//        public StringBuilder _sb; 

//        public void solve()
//        {
//            _sb = new StringBuilder();

//            _lst_kvt = new List<KeyValuePair<int, string>>();
//            _lst_kvt.Add(new KeyValuePair<int, string>(0, string.Empty));

//            string[] _input;
//            _input = Console.ReadLine().Split(' ');
//            _titleCnt = int.Parse(_input[0]);
//            _chrCnt = int.Parse(_input[1]);
//            _arr = new int[_chrCnt];

//            for (int i= 0; i < _titleCnt; i++){
//                _input = Console.ReadLine().Split(' ');
//                string _title = _input[0];
//                int _val = int.Parse(_input[1]);
//                _lst_kvt.Add(new KeyValuePair<int, string>(_val, _title));
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
//            string _ret = string.Empty;
//            int _left = 0;
//            int _right = _lst_kvt.Count - 1;

//            while(_left <= _right)
//            {
//                int mid = (_left + _right) / 2;

//                if (_left == mid || _right == mid)
//                {
//                    _ret = _lst_kvt[_right].Value;
//                    break;
//                }
//                else if (_lst_kvt[_left].Key <= val && _lst_kvt[mid].Key >= val)
//                {
//                    _right = mid;
//                }
//                else
//                    _left = mid;
//            }

//            return _ret;
//        }
//    }
//}



