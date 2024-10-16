using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using static CodingTestProj.Program;

/*
 * Difficulty : Easy ~ Middle
 * URL : https://www.acmicpc.net/problem/1065
  * Time : 
 */


namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ss = new Solution();
            ss.Solve();
        }
    }

    public class Solution
    {
        public int n;
        public int _ret;
        public int[] _arr;

        public void Solve()
        {
             n = Int32.Parse(Console.ReadLine());

            if(n < 100)
            {
                _ret = n;
            }
            else
            {
                _ret += 99; // 99 이상부터 시작
                int d = 0;
                for(int i = 100; i <= n; ++i)
                {
                    // 100 ~ n 까지 반복
                    string _input = i.ToString();
                    int _length = _input.Length;

                    int a = Convert.ToInt32(_input[0].ToString());
                    d = Convert.ToInt32(_input[1].ToString())- Convert.ToInt32(_input[0].ToString());

                    for (int j = 1; j < _length; ++j)
                    {
                        int _val = Convert.ToInt32(_input[j].ToString());

                        if (_val != (a + (j * d)))
                            break;

                        if (j == (_length - 1))
                            ++_ret;
                    }
                }
            }


            print();
        }

        public void print()
        {
            Console.WriteLine(_ret);
        }
    }
}

