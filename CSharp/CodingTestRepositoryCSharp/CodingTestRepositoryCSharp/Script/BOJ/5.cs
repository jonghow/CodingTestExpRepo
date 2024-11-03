//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = "programmerxxxprozmerqgram";
//            //string input = "progxrammerrxproxgrammer";
//            Solution.solve($"{input}");
//        }
//    }

//    public static class Solution
//    {
//        public static int _ret;
//        public static string _s;

//        public static List<char> _wordList = new List<char>();

//        public static int solve(string s)
//        {
//            _s = s;
//            chargeWord();

//            int nowIndex = 0;
//            int leftEndIndex = 0;
//            int rightStartIndex = 0;

//            char[] toArr = _s.ToCharArray();
//            while(true)
//            {
//                if (s.Length == 0) break;

//                char _c = toArr[nowIndex];

//                if(_wordList.Contains(_c) == true)
//                {
//                    _wordList.Remove(_c);

//                    if(_wordList.Count == 0)
//                    {
//                        leftEndIndex = nowIndex+1;
//                        chargeWord();
//                        toArr[nowIndex] = '\0';
//                        nowIndex = 0;
//                        break;
//                    }
//                    else
//                    {
//                        toArr[nowIndex] = '\0';
//                        nowIndex = 0;
//                    }

//                    continue;
//                }

//                ++nowIndex;
//            }

//            nowIndex = _s.Length - 1;

//            while (true)
//            {
//                if (s.Length == 0) break;

//                char _c = toArr[nowIndex];

//                if (_wordList.Contains(_c) == true)
//                {
//                    _wordList.Remove(_c);

//                    if (_wordList.Count == 0)
//                    {
//                        rightStartIndex = nowIndex;
//                        break;
//                    }
//                    else
//                    {
//                        toArr[nowIndex] = '\0';
//                        nowIndex = _s.Length - 1;
//                    }

//                    continue;
//                }
//                --nowIndex;
//            }

//            _ret = rightStartIndex - leftEndIndex;
//            return _ret;
//        }

//        public static void chargeWord()
//        {
//            _wordList.Add('p');
//            _wordList.Add('r');
//            _wordList.Add('o');
//            _wordList.Add('g');
//            _wordList.Add('r');
//            _wordList.Add('a');
//            _wordList.Add('m');
//            _wordList.Add('m');
//            _wordList.Add('e');
//            _wordList.Add('r');
//        }
//    }
//}
