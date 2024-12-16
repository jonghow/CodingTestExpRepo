//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;
//using System.Text;

/////*
//// * Difficulty : Easy ~ Middle
//// * URL : https://www.acmicpc.net/problem/2992
////  * Time : 29m
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
//        public bool[] _visit;
//        public int _Count; // 자릿수

//        public int[] _c;

//        public List<int> _Lt_= new List<int>();
//        public HashSet<int> _hs_ret = new HashSet<int>();

//        public void solve()
//        {
//            _Count = 0;
//            _n = int.Parse(Console.ReadLine());
//            int _copyN = _n;

//            while(true)
//            {
//                if (_copyN == 0)
//                    break;

//                int _val = _copyN % 10;
//                _copyN /= 10;
//                _Lt_.Add(_val);
//                ++_Count;
//            }

//            _Lt_.Reverse();
//            _c = new int[_Lt_.Count];
//            _m = _Lt_.Count;

//            BT(0, ref _c);

//            List<int> _a = new List<int>();
//            int _ret = 1000000;

//            foreach(var pair in _hs_ret)
//            {
//                if(pair > _n)
//                {
//                    _a.Clear();

//                    int _v = pair;
//                    while (true)
//                    {
//                        if (_v == 0)
//                            break;

//                        int _val = _v % 10;
//                        _v /= 10;
//                        _a.Add(_val);
//                    }

//                    for(int i = 0; i < _Lt_.Count; ++i)
//                    {
//                        if (_a.Contains(_Lt_[i]) == true)
//                        {
//                            _a.Remove(_Lt_[i]);
//                        }
//                    }

//                    if (_a.Count != 0)
//                        continue;

//                    if(_n < _ret && _ret > pair)
//                    {
//                        _ret = pair;
//                    }
//                }
//            }

//            _ret = _ret == 1000000 ? 0 : _ret;
//            Console.WriteLine(_ret);
//        }

//        public void BT(int cnt, ref int[] _c)
//        {
//            if(cnt == _m)
//            {
//                int val = (int)Math.Pow(10, _Count-1);
//                int _retVal = 0;

//                for(int i = 0; i < cnt; ++i)
//                {
//                    _retVal += _c[i] * val;
//                    val /= 10;
//                }

//                if(!_hs_ret.Contains(_retVal))
//                    _hs_ret.Add(_retVal);
//            }
//            else
//            {
//                for(int i = 0; i < _Lt_.Count; ++i)
//                {
//                    _c[cnt] = _Lt_[i];
//                    BT(cnt + 1, ref _c);
//                }
//            }
//        }
//    }
//}