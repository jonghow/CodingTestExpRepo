//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * Difficulty : Easy
// * URL : https://www.acmicpc.net/problem/5555
//  * Time : 7m
// */


////mobitel
//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();
//            ss.Solve();
//        }
//    }

//    public class Solution
//    {
//        public int n;
//        public int ret;

//        public string target;

//        public void Solve()
//        {
//            ret = 0;
//            target = string.Empty;

//            target = Console.ReadLine();
//            n = Int32.Parse(Console.ReadLine());

//            for(int i  = 0; i < n; ++i)
//            {
//                string input = Console.ReadLine();
//                input += input;


//                if (input.Contains(target) == true)
//                    ++ret;
//            }

//            print();
//        }

//        public void print()
//        {
//            Console.WriteLine(ret);
//        }
//    }
//}