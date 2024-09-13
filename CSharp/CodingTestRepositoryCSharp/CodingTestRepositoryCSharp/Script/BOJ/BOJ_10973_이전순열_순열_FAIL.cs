//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

///*
// * URL : https://www.acmicpc.net/submit/10973
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        public static int N;
//        static void Main(string[] args)
//        {
//            Solution._set();
//            N = Int32.Parse(Console.ReadLine());
//            string[] inputs = Console.ReadLine().Split(' ');
//            string inputStr = string.Empty;

//            for (int i = 0; i < inputs.Length; ++i)
//            {
//                inputStr += inputs[i];
//            }
//            // 입력 종료

//            // 마지막에서 2번째니까 내림차순하고, 2번만
//            char[] chr = inputStr.ToCharArray();

//            if (Solution.isFirstCheck(chr))
//            {
//                Console.WriteLine($"-1");
//                return;
//            }

//            Array.Sort(chr);
//            Array.Reverse(chr);
//            int[] arr = new int[chr.Length];

//            for (int i = 0; i < arr.Length; ++i)
//                arr[i] = Int32.Parse(chr[i].ToString());

//            Solution.next_permutation(arr, N, 4, 0);
//            Solution.print();
//        }
//    }

//    public static class Solution
//    {
//        public static List<int>[] _permutaionList;
//        public static int _permuteCnt;

//        public static void _set()
//        {
//            _permuteCnt = 0;
//            _permutaionList = new List<int>[2];
//            // 2개만
//        }

//        public static void next_permutation(int[] arr, int current, int r, int depth)
//        {
//            if (r == depth)
//            {
//                if (_permuteCnt > 1)
//                    return;

//                if (_permutaionList[_permuteCnt] == null)
//                    _permutaionList[_permuteCnt] = new List<int>();

//                for (int i = 0; i < arr.Length; ++i)
//                    _permutaionList[_permuteCnt].Add(arr[i]);

//                ++_permuteCnt;
//                return;
//            }

//            for (int i = depth; i < current; ++i)
//            {
//                swap(ref arr[depth], ref arr[i]);
//                next_permutation(arr, current, r, depth + 1);
//                swap(ref arr[i], ref arr[depth]);
//            }
//        }

//        public static void swap(ref int a, ref int b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }

//        public static void print()
//        {
//            for (int i = 0; i < _permutaionList[1].Count; ++i)
//            {
//                Console.Write(_permutaionList[1][i]);
//                if (i != _permutaionList[1].Count - 1)
//                    Console.Write(' ');
//            }
//        }

//        public static bool isFirstCheck(char[] chr)
//        {
//            // 제공한 숫자와 같은지 체크
//            char[] origin = new char[chr.Length];
//            chr.CopyTo(origin, 0);

//            Array.Sort(chr);
//            bool ret = true;

//            for (int i = 0; i < chr.Length; ++i)
//            {
//                if (origin[i] != chr[i])
//                {
//                    ret = false;
//                    break;
//                }
//            }
//            return ret;
//        }
//    }
//}




