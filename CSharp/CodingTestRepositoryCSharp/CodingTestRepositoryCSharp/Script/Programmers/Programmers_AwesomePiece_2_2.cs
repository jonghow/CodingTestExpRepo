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
//            int answer = 0;

//            Dictionary<string, Dictionary<int, int>> _dic = new Dictionary<string, Dictionary<int, int>>();

//            for (int i = 0; i < cnt; ++i)
//            {
//                int id = ids[i];
//                string log = logs[i];

//                if(_dic.ContainsKey(log) == false)
//                {
//                    _dic[log] = new Dictionary<int, int>();
//                    _dic[log].Add(id, 0);
//                }

//                if (_dic[log].ContainsKey(id) == false)
//                {
//                    _dic[log].Add(id, 0);
//                }


//                var multiply = _dic[log][id];

//                _dic[log].Remove(id);
//                _dic[log].Add(id, ++multiply);
//            }

            

//            foreach (var pair in _dic)
//            {
//                foreach (var item in pair.Value)
//                {
//                    if (banCounter <= item.Value)
//                    {
//                        ++answer;
//                    }
//                }
//            }

//            Console.WriteLine(answer);
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



