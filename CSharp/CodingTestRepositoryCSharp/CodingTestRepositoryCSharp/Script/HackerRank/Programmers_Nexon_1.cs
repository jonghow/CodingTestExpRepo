//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics.SymbolStore;
//using System.IO;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography;
//using System.Text;

//namespace Solution
//{
//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            /* Enter your code here. Read input from STDIN. Print output to STDOUT */

//            // 문자열 정렬 체크
//            int loopCnt = Int32.Parse(Console.ReadLine());
//            string input = string.Empty;

//            List<Tuple<int, int>> cutLine = new List<Tuple<int, int>>();
//            input = Console.ReadLine();

//            if (input.Length == 0 || input == null)
//            {
//                Console.WriteLine(0);
//                return;
//            }

//            loopCnt = Int32.Parse(Console.ReadLine());

//            for (int i = 0; i < loopCnt; i++)
//            {
//                string[] divide = Console.ReadLine().Split(' ');
//                cutLine.Add(new Tuple<int, int>(Int32.Parse(divide[0]), Int32.Parse(divide[1])));
//            }

//            for (int i = 0; i < cutLine.Count; ++i)
//            {
//                var start = (int)cutLine[i].Item1;
//                var end = (int)cutLine[i].Item2;
//                Console.WriteLine(Func.GetValueFunc(input, start, end));
//            }


//        }
//    }

//    static class Func
//    {
//        public static int GetValueFunc(string a, int start, int end)
//        {
//            bool fstflag = false;
//            int ret = 0;
//            int virtualCalc = 0;

//            for (int i = start; i <= end; i++)
//            {
//                char chrFlag = a[i];

//                if (chrFlag == 42)
//                {
//                    if (fstflag == true)
//                    {
//                        ret += virtualCalc;
//                        virtualCalc = 0;
//                        --i;
//                    }

//                    fstflag = !fstflag;
//                    continue;
//                }

//                if (fstflag == true && chrFlag != 42)
//                {
//                    virtualCalc += chrFlag - '0';
//                }
//            }

//            if (fstflag == false && virtualCalc != 0)
//                ret += virtualCalc;

//            return ret;
//        }
//    }
//}