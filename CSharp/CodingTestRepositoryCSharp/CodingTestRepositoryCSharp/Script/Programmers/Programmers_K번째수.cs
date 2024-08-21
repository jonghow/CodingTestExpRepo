////using System;
////using System.Collections.Generic;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml;
//using System.Xml.Linq;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            
//            Solution s = new Solution();
//            int[] arr = new int[7] { 1 , 5, 2, 6, 3, 7, 4 };

//            int[,] com = new int[3, 3] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

//            s.solution(arr, com);
//        }
//    }

//    public class Solution
//    {
//        public int[] solution(int[] array, int[,] commands)
//        {
//            int count = commands.GetLength(0);
//            int[] answer;

//            List<int> list = new List<int>();

//            int loop = 0;

//            for(int i = 0; i < commands.GetLength(0); ++i)
//            {
//                var fst = commands[i,0] -1 ;
//                var snd = commands[i, 1] - 1;
//                var findIndex = commands[i, 2];

//                var makeArrCount = snd - fst + 1;

//                int[] processArr = new int[makeArrCount];

//                int index = 0;
//                for(int j = fst; j <= snd; ++j)
//                {
//                    processArr[index] = array[j];
//                    ++index;
//                }

//                Array.Sort(processArr);
//                list.Add(processArr[findIndex - 1]);

//                ++loop;
//            }
//            answer = list.ToArray();
//            return answer;
//        }
//    }
//}



