using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : Easy 
// * URL : https://www.acmicpc.net/problem/7795
//  * Time : 36m
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
        public int _n;
        public int _m;

        public int[] _arrN;
        public int[] _arrM;

        public HashSet<string> _hs_ret;
        
        public void solve()
        {
            int _case = int.Parse(Console.ReadLine());
            string[] _input;
            _hs_ret = new HashSet<string>();

            for (int i = 0; i < _case; ++i)
            {
                _hs_ret.Clear();

                _input = Console.ReadLine().Split(' ');
                _n = int.Parse(_input[0]);
                _m = int.Parse(_input[1]);
                _arrN = new int[_n];
                _arrM = new int[_m];

                _input = Console.ReadLine().Split(' ');

                for(int j = 0; j < _input.Length; ++j)
                    _arrN[j] = int.Parse(_input[j]);

                Array.Sort(_arrN);
                // A 집합

                _input = Console.ReadLine().Split(' ');

                for (int j = 0; j < _input.Length; ++j)
                    _arrM[j] = int.Parse(_input[j]);

                Array.Sort(_arrM);
                // B 집합

                int _ret = 0;

                for (int j = 0; j < _arrN.Length;++j)
                {
                    int _elem =  _arrN[j];

                    int _gB_left = 0;
                    int _gB_right = _arrM.Length - 1;

                    while (_gB_left <= _gB_right)
                    {
                        int _gB_L_elem = _arrM[_gB_left];
                        int _gB_R_elem = _arrM[_gB_right];

                        if(_gB_left ==  _gB_right)
                        {
                            if(_elem > _gB_L_elem)
                            {
                                ++_ret;
                            }
                        }
                        else
                        {
                            if (_elem > _gB_L_elem)
                            {
                                ++_ret;
                            }
                            // 그룹 B 의 왼쪽 처리

                            if (_elem > _gB_R_elem)
                            {
                                ++_ret;
                            }
                            // 그룹 B 의 오른쪽 처리
                        }

                        ++_gB_left;
                        --_gB_right;
                    }
                }
                //Console.WriteLine(_hs_ret.Count);
                Console.WriteLine(_ret);
                // 출력
            }
        }
    }
}
