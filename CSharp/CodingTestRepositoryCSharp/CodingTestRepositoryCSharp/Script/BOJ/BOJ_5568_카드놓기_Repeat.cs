//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

/////*
//// * Difficulty : 
//// * URL : https://www.acmicpc.net/problem/15655
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
//        public List<int> _retList = new List<int>();
//        public int[] _arr;
//        public int _ret;

//        public int n;
//        public int k;
//        public bool[] _isVisit;

//        public void solve()
//        {
//            _isVisit = new bool[10];
//            n = int.Parse(Console.ReadLine());
//            k = int.Parse(Console.ReadLine());
//            _arr = new int[n];

//            for (int i = 0; i < n; ++i)
//            {
//                int _val = Int32.Parse(Console.ReadLine());
//                _arr[i] = _val;
//            }

//            int[] com = new int[k];
//            _isVisit[0] = true;
//            Combination(0, ref com, 0, 0);
//            _ret = _retList.Count;
//            Print();
//        }

//        public void Combination(int _Pos, ref int[] _rCom, int _r, int _Dst)
//        {
//            if (_r >= k)
//            {
//                int _val = 0;
//                string _ret = string.Empty;

//                for (int i = 0; i < k; ++i)
//                {
//                    _ret += _rCom[i].ToString();
//                }
//                _val = Int32.Parse(_ret);

//                if (_retList.Contains(_val) == false)
//                    _retList.Add(_val);

//                return;
//            }
//            else if (_arr.Length == _Dst)
//                return;
//            else
//            {
//                _rCom[_Pos] = _arr[_Dst];

//                for (int i = 0; i < n; ++i)
//                {
//                    if (_isVisit[i] == true) continue;
//                    _isVisit[i] = true;
//                    Combination(_Pos + 1, ref _rCom, _r + 1, _Dst + 1);
//                    _isVisit[i] = false;
//                }


//            }
//        }

//        public void Print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}
