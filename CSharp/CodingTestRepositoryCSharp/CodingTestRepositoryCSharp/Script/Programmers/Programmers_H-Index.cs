//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
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
//            string s;
//            s = Console.ReadLine(); // 
//            string[] split = s.Split(' ');
//            int[] citations = new int[split.Length];
//            int answer = 0;

//            for (int i = 0; i < split.Length; i++)
//            {
//                citations[i] = int.Parse(split[i]);
//            }

//            Array.Sort(citations, (a, b) =>
//            {
//                return a.CompareTo(b);
//            });

//            for(int  i = 0;i < 1000; i++)
//            {
//                int[] getReference = Array.FindAll(citations, rhs => rhs >= i); // 인용 논문, N회 이상
//                int getRefCnt = getReference.Length;
//                // N 번 이상 레퍼런스 된 논문

//                int[] getBalance = Array.FindAll(citations, rhs => rhs < i); // 남은 논문, N회 이하
//                int getBalanceCnt = getBalance.Length;

//                if(i <= getRefCnt && i >= getBalanceCnt)
//                {
//                    answer = i;
//                }
//            }
//        }
//    }
//}



