//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/1920
////  * Time : 
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

//        public int[] _candidate;

//        public HashSet<int> _hs;
//        public void solve()
//        {
//            _hs = new HashSet<int>();
//            _n = int.Parse(Console.ReadLine());

//            string[] _input = Console.ReadLine().Split(' ');

//            for(int i = 0;  i < _input.Length; ++i)
//                _hs.Add(int.Parse(_input[i]));

//            _m = int.Parse(Console.ReadLine());
//            _candidate = new int[_m];

//            _input = Console.ReadLine().Split(' ');

//            for (int i = 0; i < _input.Length; ++i)
//                _candidate[i] = int.Parse(_input[i]);
//            // Input..

//            StringBuilder sb = new StringBuilder();

//            for(int i = 0; i < _candidate.Length; ++i)
//            {
//                if(_hs.Contains(_candidate[i]) == true)
//                    sb.Append(1);
//                else
//                    sb.Append(0);

//                sb.AppendLine();
//            }

//            Console.WriteLine(sb.ToString());
//        }
//    }
//}
