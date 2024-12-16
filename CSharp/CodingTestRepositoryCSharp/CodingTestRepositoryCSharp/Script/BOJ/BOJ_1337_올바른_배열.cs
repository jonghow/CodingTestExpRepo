using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : 
// * URL : https://www.acmicpc.net/problem/1337
//  * Time : 
// */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            solu.solve();
        }
    }

    public class Solution
    {
        int _n;
        int[] _arr;
        public void solve()
        {
            _n = int.Parse(Console.ReadLine());
            _arr = new int[_n];

            for (int i = 0; i < _n; i++)
                _arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(_arr);

            int _left = 0;
            int _right = _arr.Length - 1;
            int _ret = int.MaxValue;

            bool _isSwitching = false;

            HashSet<int> _hs_Candidate = new HashSet<int>();

            while(_left < _right)
            {
                _hs_Candidate.Clear();

                int _val = _arr[_left];

                for(int i = 0; i < 5; ++i)
                {
                    if (_left + i > _right)
                        break;

                    int _target = _arr[_left+ i];

                    if(_val <= _target && _target < (_val + 5))
                    {
                        if(!_hs_Candidate.Contains(_target))
                            _hs_Candidate.Add(_target);
                    }
                }
                
                if(_ret > 5 - _hs_Candidate.Count)
                    _ret = 5- _hs_Candidate.Count;

                _hs_Candidate.Clear();
                //left

                _val = _arr[_right];

                for (int i = 0; i < 5; ++i)
                {
                    if (_right - i < _left)
                        break;

                    int _target = _arr[_right- i];

                    if (_val >= _target && _target > (_val - 5))
                    {
                        if (!_hs_Candidate.Contains(_target))
                            _hs_Candidate.Add(_target);
                    }
                }
                //right

                if (_isSwitching == true)
                {
                    _isSwitching = !_isSwitching;
                    ++_left;
                }
                else
                {
                    _isSwitching = !_isSwitching;
                    --_right;
                }
            }

            Console.WriteLine(_ret);
        }
    }
}