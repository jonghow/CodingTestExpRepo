//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Authentication;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
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
//            // 입력 
//            s = Console.ReadLine();
//            string[] split = s.Split(' ');
//            int[] citations = new int[split.Length];

//            for (int i = 0; i < split.Length; i++)
//            {
//                citations[i] = int.Parse(split[i]);
//            }

//            s = Console.ReadLine();
//            // 타겟 넘버 입력
//            int targetNumber = int.Parse(s);
//            int answer = 0;

//            calc(citations, 0, 0, targetNumber, ref answer);
//            Console.WriteLine(answer);
//        }

//        public static void calc(int[] arr, int sum, int depth, int target, ref int answer)
//        {
//            if((arr.Length == depth))
//            {
//                if(sum == target) ++answer;
//                return;
//            } // 뎁스가 마지막에 도달했으며, 여기서 타겟넘버와 값이 같을때, ++ 한다

//            calc(arr, sum + arr[depth], depth + 1, target, ref answer); // + 의 경우
//            calc(arr, sum + (arr[depth] * -1), depth + 1, target, ref answer);
//        }
//    }
//}



