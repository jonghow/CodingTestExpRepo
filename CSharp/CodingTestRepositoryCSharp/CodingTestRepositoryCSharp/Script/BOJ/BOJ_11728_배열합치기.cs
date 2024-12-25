//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy
//// * URL : https://www.acmicpc.net/problem/11728
////  * Time : 21m 
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
//        public int _n;
//        public int _m;

//        public int[] _arr;

//        public HashSet<int> _hs_arr;
//        public StringBuilder _sb;

//        public void solve()
//        {
//            _sb = new StringBuilder();
//            _hs_arr = new HashSet<int>();
//            string[] input = Console.ReadLine().Split(' ');
//            _n = int.Parse(input[0]);
//            _m = int.Parse(input[1]);

//            _arr = new int[_n+_m];

//            input = Console.ReadLine().Split(' ');

//            int Index = 0;
//            for (; Index < _n; ++Index)
//            {
//                _arr[Index] = int.Parse(input[Index]);
//            }

//            input = Console.ReadLine().Split(' ');

//            for (int i = 0; i < _m; ++i)
//            {
//                _arr[i+Index] = int.Parse(input[i]);
//            }

//            Array.Sort( _arr);

//            for(int i = 0; i < _arr.Length; ++i)
//                _sb.Append($" {_arr[i]}");

//            Console.Write(_sb.ToString().Remove(0,1));
//        }
//    }
//}
