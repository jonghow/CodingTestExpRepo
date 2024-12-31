using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CodingTestProj.Program;
using System.Text;

///*
// * Difficulty : 
// * URL : https://www.acmicpc.net/problem/6230
//  * Time : 1h +
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

        public int _left;
        public int _right;

        public void solve()
        {
            string[] _input = Console.ReadLine().Split(' ');
            _n = int.Parse(_input[0]);
            _m = int.Parse(_input[1]);

            _arrN = new int[_n];
            _arrM = new int[_m];

            for (int i = 0; i < _n; ++i)
                _arrN[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < _m; ++i)
                _arrM[i] = int.Parse(Console.ReadLine());

            /*
             *  A크기 건초베일 하나 살때 B 크기의 건초베일 무료로
             *  N 고품질 배일 , M 저품질 베일
             */
            _left = 0;
            _right = _n - 1;

            // 제일 큰 수에서 가져오면 된다.

            //Array.Sort(_arrN, (int a, int b) => { return b.CompareTo(a); });
            Array.Sort(_arrN);
            Array.Sort(_arrM);

            int _retResult = 0;

            for(int i = 0; i < _arrN.Length; ++i)
            {
                int val = _arrN[i];
                int retVal = BinarySearch(_arrM, val);
                _retResult = Math.Max(_retResult, retVal+1);
            }

            Console.WriteLine(_retResult);
        }

        public int BinarySearch(int[] smallArr, int value)
        {
            int left = 0;
            int right = smallArr.Length;

            while(left < right)
            {
                int mid = (left + right) / 2;

                if (smallArr[mid] < value)
                    left = mid +1;
                else
                    right = mid;
            }

            return left;
        }
    }
}
 