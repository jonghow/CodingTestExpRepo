//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
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

//            string input = Console.ReadLine();
//            string[] inputArr = input.Split(' ');

//            int diceNumbPoolCount = Int32.Parse(inputArr[0]);
//            int goals = Int32.Parse(inputArr[1]);

//            List<int> diceNumbList = new List<int>();

//            input = Console.ReadLine();
//            inputArr = input.Split(' ');

//            for (int i = 0; i < diceNumbPoolCount; ++i)
//                diceNumbList.Add(Convert.ToInt32(inputArr[i].ToString()));

//            int[] dpMap = new int[goals + 1];
//            dpMap[0] = 1; // 시작 칸에 도달하는 경우는 1가지

//            // 각 칸에 도달할 수 있는 경우의 수를 계산
//            for (int i = 1; i <= goals; i++)
//            {
//                for (int j = 0; j < diceNumbList.Count; ++j)
//                {
//                    if (i - diceNumbList[j] >= 0)
//                    {
//                        dpMap[i] += dpMap[i - diceNumbList[j]];
//                    }
//                }
//            }

//            Console.WriteLine(dpMap[goals]);
//        }
//    }
//}


