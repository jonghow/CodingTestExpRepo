//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution.solve();
//        }
//    }

//    public static class Solution
//    {
//        public static List<int> _retList = new List<int>();
//        public static int _ret;

//        public static int _day;

//        public static List<Tuple<int,int>> _keyValue = new List<Tuple<int,int>>();

//        public static void solve()
//        {
//            _day = int.Parse(Console.ReadLine());
//            for (int i = 0; i < _day; ++i)
//            {
//                string[] input = Console.ReadLine().Split(' ');
//                int useDay = int.Parse(input[0]);
//                int money = int.Parse(input[1]);

//                _keyValue.Add(new Tuple<int,int>(useDay, money));
//            }



//        }
//    }
//}
