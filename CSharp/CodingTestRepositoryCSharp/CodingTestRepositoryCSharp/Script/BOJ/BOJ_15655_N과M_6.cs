//using System;
//using System.Collections.Generic;
//using System.Text;

///////*
////// * Difficulty : 
////// * URL : https://www.acmicpc.net/problem/15655
//////  * Time : 
////// */
/////
//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution solution = new Solution();
//            solution.solve();
//        }
//    }

//    public class Solution
//    {
//        public const int _max = 9;
//        public const int _valmax = 10001;
//        public int _n;
//        public int _m;
//        public int[] _arr;
//        public int[] _per;

//        public bool[] _isVisit;

//        public HashSet<string> _ret;

//        public void solve()
//        {
//            _ret = new HashSet<string>();
//            string[] _in = Console.ReadLine().Split(' ');
//            _n = int.Parse(_in[0].ToString());
//            _m = int.Parse(_in[1].ToString());
//            _isVisit = new bool[_valmax];

//            _in = Console.ReadLine().Split(' ');
//            _arr = new int[_max];

//            for (int i = 0; i < _in.Length; ++i)
//                _arr[i] = Int32.Parse(_in[i]);

//            _per = new int[_m];

//            List<int> _temp = new List<int>(_arr);
//            _temp.Sort(Sorted);
//            _arr = _temp.ToArray();

//            BT(ref _arr, ref _per, 0, 0);

//            int index = 0;
//            foreach (string s in _ret)
//            {
//                Console.Write(s);

//                if (index != _ret.Count - 1)
//                    Console.WriteLine();
//            }
//        }

//        public int Sorted(string _item1, string _item2)
//        {
//            bool _isEmptyitem1 = _item1 == null || _item1.Length == 0 ? true : false;
//            bool _isEmptyitem2 = _item2 == null || _item2.Length == 0 ? true : false;

//            if (_item1 == null)
//                _item1 = " ";

//            if (_item2 == null)
//                _item2 = " ";

//            if (_isEmptyitem1 != _isEmptyitem2)
//                return _isEmptyitem1.CompareTo(_isEmptyitem2);

//            return _item1.CompareTo(_item2);
//        }

//        public int Sorted(int _item1, int _item2)
//        {
//            bool _isEmptyitem1 = _item1 == 0 ? true : false;
//            bool _isEmptyitem2 = _item2 == 0 ? true : false;

//            if (_isEmptyitem1 != _isEmptyitem2)
//                return _isEmptyitem1.CompareTo(_isEmptyitem2);

//            return _item1.CompareTo(_item2);
//        }

//        public void BT(ref int[] _arr, ref int[] _per, int _cnt, int _pos)
//        {
//            if (_cnt >= _m)
//            {
//                string _st = string.Empty;

//                for (int i = 0; i < _cnt; ++i)
//                {
//                    _st += _per[i];

//                    if (i != _cnt - 1)
//                        _st += " ";
//                }

//                if (_ret.Contains(_st) == false)
//                    _ret.Add(_st);
//            }
//            else
//            {
//                for (int i = 0; i < _n; ++i)
//                {
//                    if (_isVisit[Int32.Parse(_arr[i].ToString())] == false)
//                    {
//                        _isVisit[Int32.Parse(_arr[i].ToString())] = true;
//                        _per[_pos] = _arr[i];
//                        BT(ref _arr, ref _per, _cnt + 1, _pos + 1);

//                        _isVisit[Int32.Parse(_arr[i].ToString())] = false;
//                    }
//                }
//            }
//        }
//    }
//}

