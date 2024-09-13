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
//            string a = "ZzZz9Z824";
//            //string a = "aaaaZZZZ)";
//            //string a = "CaCbCgCdC888834A";

//            s.solution(a);
//        }
//    }

//    public class Solution
//    {
//        //public int solution(string s)
//        //{
//        //    int ret = 0;
//        //    int count = 0;

//        //    StringBuilder gr1 = new StringBuilder();
//        //    StringBuilder gr2 = new StringBuilder();
//        //    StringBuilder gr3 = new StringBuilder();
//        //    StringBuilder gr4 = new StringBuilder();

//        //    for (int i = 0; i < s.Length; i++)
//        //    {
//        //        char chr = s[i];

//        //        if('A' <= chr && chr <= 'Z')
//        //        {
//        //            gr1.Append(chr);
//        //        }
//        //        else if ('a' <= chr && chr <= 'z')
//        //        {
//        //            gr2.Append(chr);
//        //        }
//        //        else if ('0' <= chr && chr <= '9')
//        //        {
//        //            gr3.Append(chr);
//        //        }
//        //        else if (
//        //            chr == '~' ||
//        //            chr == '!' ||
//        //            chr == '@' ||
//        //            chr == '#' ||
//        //            chr == '$' ||
//        //            chr == '%' ||
//        //            chr == '^' ||
//        //            chr == '&' ||
//        //            chr == '*' ||
//        //            chr == '(' ||
//        //            chr == ')' ||
//        //            chr == '-' ||
//        //            chr == '_' ||
//        //            chr == '=' ||
//        //            chr == '+')
//        //        {
//        //            gr4.Append(chr);
//        //        }
//        //    }

//        //    if (gr1.ToString().Length != 0)
//        //        ++count;
//        //    if (gr2.ToString().Length != 0)
//        //        ++count;
//        //    if (gr3.ToString().Length != 0)
//        //        ++count;
//        //    if (gr4.ToString().Length != 0)
//        //        ++count;

//        //    if((count >= 3 ) == false)
//        //            ret = 3;

//        //    return ret;
//        //}

//        public int solution(string s) // 2
//        {
//            int ret = 0;

//            for (int i = 0; i < s.Length; i++)
//            {
//                char chr = s[i];

//                if (('A' <= chr && chr <= 'Z') == false)
//                {
//                    ret = 2;
//                    break;
//                }
//                else if (('a' <= chr && chr <= 'z' ) == false)
//                {
//                    ret = 2;
//                    break;
//                }
//                else if (('0' <= chr && chr <= '9') == false)
//                {
//                    ret = 2;
//                    break;
//                }
//                else if (
//                    chr == '~' ||
//                    chr == '!' ||
//                    chr == '@' ||
//                    chr == '#' ||
//                    chr == '$' ||
//                    chr == '%' ||
//                    chr == '^' ||
//                    chr == '&' ||
//                    chr == '*' )
//                {
//                    ret = 2;
//                    break;
//                }
//            }

//            return ret;
//        }
//    }
//}



