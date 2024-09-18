//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static int Main(string[] args)
//        {
//            int answer = 0;

//            int n = 7;
//            int k = 3;

//            //int[] isDanger = new int[6] { 1, 0, 0, 1, 0, 1 };
//            //int[] isDanger = new int[7] {0,0,0,1,1,0,1 };
//            int[] isDanger = new int[7] {0,0,0,1,1,0,1 };

//            int isAirCount = 0;
//            int obsLength = 0;

//            for(int i = 0; i < n; ++i)
//            {
//                var elem = isDanger[i];

//                isAirCount = Math.Max(0, isAirCount-1);

//                if (elem == 1 && isAirCount == 0)
//                {
//                    isAirCount = k-1;
//                    ++answer;

//                    obsLength = 0;
//                    for (int j = i; j < n; ++j)
//                    {
//                        var nextElem = isDanger[j];
//                        if (nextElem == 1)
//                        {
//                            ++obsLength;
//                            continue;   
//                        }

//                        break;
//                    }

//                    if (obsLength > (k - 1))
//                        return -1;
//                }

//                if (elem == 1 && isAirCount ==0)
//                    return -1;
//            }

//            return answer;
//        }
//    }

//    public static class Solution
//    {
//        public static int Prog(int a, int b, int n)
//        {
//            int ret = 0;
//            int mok = 0;

//            for (int i = 0; i < n; ++i)
//            {
//                a = (a % b) * 10;
//                mok = (a / b);
//            }

//            ret = mok;
//            return ret;
//        }
//    }
//}



