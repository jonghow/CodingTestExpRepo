//using System;
//using System.Collections.Generic;
//using System.Diagnostics.SymbolStore;
//using System.IO;
//using System.Linq;

//namespace Solution
//{
//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            /* Enter your code here. Read input from STDIN. Print output to STDOUT */

//            // 문자열 정렬 체크
//            int loopCnt = Int32.Parse(Console.ReadLine());
//            List<string> wordList = new List<string>();
//            List<string> printList = new List<string>();

//            for (int i = 0; i < loopCnt; ++i)
//            {
//                string badWord = Console.ReadLine();
//                char[] chrArr = badWord.ToCharArray();
//                //Array.Sort(chrArr);

//                if (wordList.Count == 0)
//                {
//                    wordList.Add(badWord);
//                    continue;
//                }

//                for (int j = 0; j < wordList.Count; ++j)
//                {
//                    string innerbadWord = wordList[j];
//                    char[] innerchrArr = innerbadWord.ToCharArray();
//                    //Array.Sort(innerchrArr);

//                    bool isCheck = MatchStringFunc.isMatchString(innerchrArr, chrArr);
//                    if(isCheck == true)
//                    {
//                        printList.Add(badWord);
//                    }
//                }

//                wordList.Add(badWord);
//            }

//            for(int i = 0;i < printList.Count; ++i)
//            {
//                Console.WriteLine(printList[i]);
//            }
//        }
//    }

//    static class MatchStringFunc
//    {
//        public static bool isMatchString(char[] a, char[] b)
//        {
//            bool ischeck = false;

//            for (int i =0; i < b.Length; ++i)
//            {
//                char fstCheck = a[0];
//                char bElement = b[i];

//                if (bElement == fstCheck)
//                {
//                    ischeck = true;

//                    for (int j = 0; j < a.Length; ++j)
//                    {
//                        char aElement = a[j];

//                        if (i + j >= b.Length)
//                        {
//                            ischeck  = false;
//                            break;
//                        }

//                        bElement = b[i + j];

//                        if (aElement != bElement)
//                        {
//                            ischeck = false;
//                            break;
//                        }
//                    }
//                }
//                else
//                    continue;

//                if (ischeck == true)
//                    break;
//            }

//            return ischeck;
//        }
//    }
//}