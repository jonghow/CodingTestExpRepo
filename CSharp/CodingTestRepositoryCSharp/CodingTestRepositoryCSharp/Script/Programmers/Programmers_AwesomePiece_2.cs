//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] ids = new int[7] { 1, 3, 2, 2, 3, 3, 1 };
//            string[] logs = new string[7] { "Hello", "Hi", "Awesomepiece", "Awesomepiece", "Awesomepiece", "awesomepiece", "Hello" };
//            int cnt = 7;
//            int banCounter = 2;

//            List<Data> list = new List<Data>();


//            for (int i = 0; i < cnt; ++i)
//            {
//                int id = ids[i];
//                string log = logs[i];

//                list.Add(new Data(id, log));
//            }

//            list.Sort((x, y) => string.Compare(x.logs, y.logs));

//            int banPlayerCount = 0;
//            int currentCounter = 0;
//            for(int i = 0; i < list.Count-1; ++i)
//            {
//                Data prev = list[i];
//                Data next = list[i+1];

//                if(prev.ids == next.ids && prev.logs == next.logs)
//                {
//                    ++currentCounter;

//                    if(currentCounter >= banCounter-1)
//                    {
//                        ++banPlayerCount;
//                    }
//                }
//                else
//                {
//                    currentCounter = 0;
//                }
//            }

//            Console.WriteLine(banPlayerCount);
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

//    public class Data
//    {
//        public int ids; 
//        public string logs; 
//        public Data(int ids, string logs)
//        {
//            this.ids = ids;
//            this.logs = logs;
//        }
//    }
//}



