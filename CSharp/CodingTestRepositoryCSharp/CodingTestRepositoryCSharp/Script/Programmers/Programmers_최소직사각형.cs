//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Authentication;
//using System.Security.Cryptography;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

///*
// * Difficulty : Easy ~ Middle
// * URL : https://school.programmers.co.kr/learn/courses/30/lessons/86491
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution s = new Solution();

//            int[,] arr = new int[5, 2] {
//                { 10, 7 },
//                { 12,3},
//                { 8,15},
//                { 14,7},
//                {7,11 } };

//            s.solution(arr);
//        }
//    }

//    public class Solution
//    {
//        public int solution(int[,] sizes)
//        {
//            int answer = 0;
//            List<Tuple<int, int>> list = new List<Tuple<int, int>>();

//            for(int i = 0; i < sizes.GetLength(0); ++i)
//            {
//                int width = sizes[i, 0];
//                int height = sizes[i, 1];

//                if(width < height)
//                {
//                    int temp = height;
//                    height = width;
//                    width = temp;
//                }

//                list.Add(new Tuple<int, int>(width, height));
//            }

//            int maxWidth = Int32.MaxValue;
//            int maxHeight = Int32.MaxValue;

//            for(int i = 0; i < list.Count; ++i)
//            {
//                var element = list[i];
//                var width = element.Item1;
//                var height = element.Item2;

//                var countfst = list.FindAll(rhs => rhs.Item1 <= width).Count;
//                var countsnd = list.FindAll(rhs => rhs.Item2 <= height).Count;

//                if(list.Count == countfst)
//                {
//                    if(maxWidth >= width)
//                        maxWidth = width;
//                }

//                if(list.Count == countsnd)
//                {
//                    if (maxHeight >= height)
//                        maxHeight = height;
//                }
//            }

//            answer = maxWidth * maxHeight;
//            return answer;
//        }
//    }
//}



