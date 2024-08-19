//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.AccessControl;
//using System.Security.Authentication;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

///*
// * URL : https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            Result solution = new Result();
//            int a = 19;

//            List<int> b = new List<int>();
//            List<int> c = new List<int>();

//            List<int> nums1 = new List<int>();
//            List<int> nums2 = new List<int>();

//            nums1.Add(1);
//            nums1.Add(2);
//            nums1.Add(3);

//            nums2.Add(4);
//            nums2.Add(5);
//            nums2.Add(6);

//            int m = 3;

//            for (int i = 0; i < m; ++i)
//                nums1.Add(0);

//            for (int i = 0; i < m; ++i)
//            {
//                nums1[m + i] = nums2[i];
//            }

//            nums1.Sort();


//            //Console.WriteLine(Result.isHappy(a));
//        }
//    }

//    class Result
//    {

//        /*
//         * Complete the 'isHappy' function below.
//         *
//         * The function is expected to return a BOOLEAN.
//         * The function accepts INTEGER n as parameter.
//         */

//        public static bool isHappy(int n)
//        {
//            if (n == 1) return true;

//            while (true)
//            {
//                // Seperate Value
//                var listValue = SeparateValue(n);

//                int SumValue = 0;

//                // Sum
//                for (int i = 0; i < listValue.Count(); ++i)
//                {
//                    int element = listValue[i];
//                    if (element == 0) continue;

//                    SumValue += (int)Math.Pow((double)element, (double)2);
//                }

//                if (SumValue == 1)
//                    return true;

//                // 사이클링 되는 변수

//                if (SumValue < 7)
//                    break;



//                n = CombineValue(SeparateValue((int)SumValue));
//            }

//            return false;
//        }

//        public static List<int> SeparateValue(int n)
//        {
//            List<int> newList = new List<int>();
//            int balance = 0;

//            while (n != 0)
//            {
//                // 82 라고할때, 앞에서부터 잘라서 넣으면 좋으나, 편의를 위해 뒤부터 잘라서 앞으로 넣는다.
//                balance = n % 10;
//                newList.Insert(0, balance);
//                n /= 10;
//            }

//            return newList;
//        }

//        public static int CombineValue(List<int> list)
//        {
//            int ret = 0;

//            for (int i = 0; i < list.Count(); ++i)
//            {
//                var element = list[i];
//                ret = (ret * 10) + element;
//            }

//            return ret;
//        }
//    }
//}







