////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.ComponentModel.Design;
////using System.Linq;
////using System.Linq.Expressions;
////using System.Text;
////using System.Threading;
////using System.Threading.Tasks;
////using System.Web;
////using System.Xml.Linq;

////namespace CodingTestProj
////{
////    internal class Program
////    {
////        static List<int> resultCollector = new List<int>();
////        static void Main(string[] args)
////        {
////            string s;
////            // 입력 
////            s = Console.ReadLine();

////            int[] numberArr = new int[s.Length];
////            bool[] isVisit = new bool[10] ;

////            // 분리
////            for (int i = 0; i < s.Length; ++i)
////                numberArr[i] = s[i] - 48;

////            string newString = string.Empty;
////            int answer = 0;
////            DFS(numberArr, isVisit, 0, newString, ref answer);

////            //return answer;
////        }

////        public static void DFS(int[] arr,bool[] isVisit, int depth, string numberString,  ref int answerCnt) 
////            // DFS 로 찾는다.
////        {
////            for(int i = depth; i < arr.Length; ++i) 
////            {
////                var element = arr[i];

////                //if (isVisit[element] == true)
////                //    continue; // 1,3,5 루프에서 사용한다. 이후 다른 루프에서도 같이 사용하니, 재귀에서 해제해준다.

////                //isVisit[element] = true;
////                SwapCharacter(arr, i, depth);
////                DFS(arr, isVisit, depth+1, numberString + element, ref answerCnt);

////                int parseInt = int.Parse(numberString + element);
////                if(resultCollector.Contains(parseInt)== false && isPrimeCheck(parseInt) == true)
////                {
////                    resultCollector.Add(parseInt);
////                    ++answerCnt;
////                }

////                SwapCharacter(arr, depth, i);

////                //isVisit[element] = false;
////            }
////        }

////        public static void SwapCharacter(int[] arr, int x, int y)
////        {
////            int temp = arr[x];
////            arr[x] = arr[y];
////            arr[y] = temp;
////        }

////        public static bool isPrimeCheck(int number)
////        {
////            if (number == 0) return false;
////            if (number == 1) return false;
////            // 0, 1 은 소수가 아니다.

////            if (number == 2) return true;
////            // 2는 소수다.

////            for(int i = 2; i < number; ++i)
////            {
////                if (number % i == 0)
////                    return false;
////            }
////            // 0 으로 나눠진다면 소수가 아니다.

////            return true;
////        }
////    }

////    public static void dd()
////    {

////    }
////}
//using System;
//using System.Collections.Generic;

//public class Solution
//{
//    static List<int> resultCollector = new List<int>();
//    public int solution(string numbers)
//    {

//        bool[] isVisit = new bool[10];
//        int[] numberArr = new int[numbers.Length];
//        for (int i = 0; i < numbers.Length; ++i)
//            numberArr[i] = numbers[i] - 48;

//        string newString = string.Empty;
//        int answer = 0;
//        DFS(numberArr, isVisit, 0, newString, ref answer);

//        return answer;
//    }

//    public void DFS(int[] arr, bool[] isVisit, int depth, string numberString, ref int answerCnt)
//    // DFS 로 찾는다.
//    {
//        for (int i = depth; i < arr.Length; ++i)
//        {
//            var element = arr[i];

//            //if (isVisit[element] == true)
//            //    continue; // 1,3,5 루프에서 사용한다. 이후 다른 루프에서도 같이 사용하니, 재귀에서 해제해준다.

//            //isVisit[element] = true;
//            SwapCharacter(arr, i, depth);
//            DFS(arr, isVisit, depth + 1, numberString + element, ref answerCnt);

//            int parseInt = int.Parse(numberString + element);
//            if (resultCollector.Contains(parseInt) == false && isPrimeCheck(parseInt) == true)
//            {
//                resultCollector.Add(parseInt);
//                ++answerCnt;
//            }

//            SwapCharacter(arr, depth, i);

//            //isVisit[element] = false;
//        }
//    }

//    public void SwapCharacter(int[] arr, int x, int y)
//    {
//        int temp = arr[x];
//        arr[x] = arr[y];
//        arr[y] = temp;
//    }

//    public bool isPrimeCheck(int number)
//    {
//        if (number == 0) return false;
//        if (number == 1) return false;
//        // 0, 1 은 소수가 아니다.

//        if (number == 2) return true;
//        // 2는 소수다.

//        for (int i = 2; i < number; ++i)
//        {
//            if (number % i == 0)
//                return false;
//        }
//        // 0 으로 나눠진다면 소수가 아니다.

//        return true;
//    }






//}

