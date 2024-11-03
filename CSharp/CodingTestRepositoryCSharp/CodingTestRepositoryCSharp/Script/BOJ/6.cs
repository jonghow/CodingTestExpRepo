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
//            List<int> list =  new List<int>();
//            list.Add(30);
//            list.Add(20);
//            list.Add(25);

//            int d = 4;
//            Solution.solve(list,d);
//        }
//    }

//    public static class Solution
//    {
//        public static int _ret;
//        public static int _d;
//        public static List<KeyValuePair<int, List<int>>> _listPermute = new List<KeyValuePair<int, List<int>>>();
//        public static int _dic_index = 0;
//        public static int[] _numbers;
//        public static bool[] _isSelected;

//        public static List<char> _wordList = new List<char>();
//        public static Dictionary<int, int> _dicVal = new Dictionary<int, int>();

//        public static List<int> _retList = new List<int>();

//        public static int solve(List<int> weights, int d)
//        {
//            _d = d;
//            int count = weights.Count;
//            _numbers = new int[count];
//            _isSelected = new bool[count];

//            for (int i = 0; i < count; ++i)
//                _numbers[i] = i + 1;

//            for (int i = 1; i <= count; ++i)
//                _dicVal.Add(i, weights[i-1]);

//            int[] arr = new int[d];
//            Permutation(0, 0, ref arr);
//            // 모든 순열 구했고, 

//            MainSolution();

//            _retList.Sort();
//            _ret = _retList[0];
//            return _ret;
//        }

//        public static void Permutation(int _depth, int _pos, ref int[] arr)
//        {
//            if (_depth == (_d))
//            {
//                List<int> _mList = new List<int>();
//                _mList.AddRange(arr);

//                _listPermute.Add(new KeyValuePair<int, List<int>>(_dic_index, _mList));

//                //for (int i = 0; i < _mList.Count; ++i)
//                //    Console.Write(_mList[i] + " ");

//                //Console.WriteLine();

//                ++_dic_index;
//            }
//            else
//            {
//                for (int i = 0; i < _numbers.Length; ++i)
//                {
//                    arr[_depth] = _numbers[i];
//                    Permutation(_depth + 1, _pos, ref arr);


//                    //if (_isSelected[i] == false)
//                    //{
//                    //    _isSelected[i] = true;

//                    //    _isSelected[i] = false;
//                    //}
//                }
//            }
//        }
//        public static void MainSolution()
//        {
//            for (int i = 0; i < _listPermute.Count; ++i)
//            {
//                var val = _listPermute.Find(rhs => rhs.Key == i).Value;
//                if (val == null) continue;

//                Dictionary<int, int> copy = new Dictionary<int, int>(_dicVal);
//                int ret = 0;
//                for (int j = 0; j < val.Count; ++j)
//                {
//                    var foodNumb = val[j];
//                    var foodVal = copy[foodNumb];

//                    foodVal = (int)Math.Ceiling(foodVal * 0.5f);

//                    copy[foodNumb] = foodVal;
//                }


//                foreach (var pair in copy)
//                {
//                    ret += pair.Value;
//                }

//                _retList.Add(ret);
//            }
//        }
//    }
//}
