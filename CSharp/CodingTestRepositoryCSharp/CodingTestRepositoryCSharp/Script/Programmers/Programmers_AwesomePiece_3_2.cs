//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Diagnostics.SymbolStore;
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

//            int n = 6;
//            int k = 2;
//            int turnK = k;

//            int[] isDanger = new int[6] { 1, 0, 0, 1, 0, 1 };
//            //int[] isDanger = new int[7] {0,0,0,1,1,0,1 };
//            //int[] isDanger = new int[10] {0,0,1,1,0,0,0,1,0,1};

//            List<int> list = new List<int>();

//            for (int i = 0; i < n; ++i)
//            {
//                int start = i;
//                int dst = Math.Min(n, start + (k-1));
//                int elem = isDanger[i];
//                bool readyJump = false;

//                if(i == 0 && elem == 1)
//                {
//                    answer++;
//                    continue;
//                }

//                for (int j = start+1; j <= dst; ++j)
//                {
//                    if (j >= n)
//                    {
//                        readyJump = true;
//                        break;
//                    }

//                    if (isDanger[j] == 1)
//                    {
//                        readyJump = true;
//                        break;
//                    }
//                }

//                if(readyJump == true && dst == n)
//                {
//                    ++answer;
//                    break;
//                }

//                if(readyJump == true  && isDanger[dst] == 0)
//                {
//                    // safety
//                    i = Math.Min(n, (i + (k - 1)));
//                    ++answer;
//                }
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



