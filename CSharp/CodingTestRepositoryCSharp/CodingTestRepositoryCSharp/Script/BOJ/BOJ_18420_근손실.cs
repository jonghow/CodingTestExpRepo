using System;
using System.Collections;
using System.Collections.Generic;
using static CodingTestProj.Program;

/*
 * Difficulty : Middle
 * URL : https://www.acmicpc.net/problem/18429
  * Time : 
 */


//mobitel
namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ss = new Solution();
            ss.solve();
        }
    }

    public class Solution
    {
        public int _n;
        public int _k;
        public int _declineProtain;

        public bool[] _isSelected;
        public int[] _numbers;

        public int _ret;

        public int _permuteCnt;
        public int _nowWeight;

        public int _dic_index;
        public Dictionary<int, int> _dicKitVal = new Dictionary<int, int>();
        public List<KeyValuePair<int, List<int>>> _listPermute = new List<KeyValuePair<int, List<int>>>();

        public void solve()
        {
            Init();

            string[] input = Console.ReadLine().Split(' ');
            _n = Int32.Parse(input[0]);
            _k = Int32.Parse(input[1]);

            _isSelected = new bool[_n];
            _numbers = new int[_n];

            for (int i = 0; i < _n; ++i)
                _numbers[i] = i + 1;

            input = Console.ReadLine().Split(' ');

            for (int i = 1; i <= _n; ++i)
                _dicKitVal.Add(i, Int32.Parse(input[i - 1]));

            int[] arr = new int[_n];
            Permutation(0, 0, ref arr);
            MainSolution();

            Print();
        }

        public void Init()
        {
            _n = 0;
            _k = 0;
            _declineProtain = 0;
            _dic_index = 0;
            _nowWeight = 500;
        }

        public void Permutation(int _depth, int _pos, ref int[] arr)
        {
            if (_depth == (_n))
            {
                List<int> _mList = new List<int>();
                _mList.AddRange(arr);

                _listPermute.Add(new KeyValuePair<int, List<int>>(_dic_index, _mList));

                //for (int i = 0; i < _mList.Count; ++i)
                //    Console.Write(_mList[i] + " ");

                //Console.WriteLine();

                ++_dic_index;
            }
            else
            {
                for (int i = 0; i < _numbers.Length; ++i)
                {
                    if (_isSelected[i] == false)
                    {
                        _isSelected[i] = true;
                        arr[_depth] = _numbers[i];
                        Permutation(_depth + 1, _pos, ref arr);
                        _isSelected[i] = false;
                    }
                }
            }
        }

        public void MainSolution()
        {
            for (int i = 0; i < _listPermute.Count; ++i)
            {
                var val = _listPermute.Find(rhs => rhs.Key == i).Value;
                if (val == null) continue;

                _nowWeight = 500;
                bool isFail = false;

                for (int j = 0; j < val.Count; ++j)
                {
                    var kitNumb = val[j];
                    var kitVal = _dicKitVal[kitNumb];

                    _nowWeight = _nowWeight - (_k) + kitVal;

                    if (_nowWeight < 500)
                    {
                        isFail = true;
                        break;
                    }
                }

                if (isFail) continue;

                ++_ret;
            }
        }

        public void Print()
        {
            Console.WriteLine(_ret);
        }
    }
}
