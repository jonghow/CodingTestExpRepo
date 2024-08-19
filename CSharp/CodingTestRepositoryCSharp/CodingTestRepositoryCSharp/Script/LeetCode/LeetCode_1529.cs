//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.IO;
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
//using static CodingTestProj.Program;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution s = new Solution();
//            s.MinFlips("10111");
//            //s.MinFlips("101");
//            //s.MinFlips("00000");
//            //s.MinFlips("001011101");
//        }
//    }
//    public class Solution
//    {
//        public int MinFlips(string target)
//        {
//            int answer = 0;

//            if (target.Contains("1") == false)
//                return answer;

//            char nowChar = '0';

//            for(int i = 0; i < target.Length;++i)
//            {
//                if (target[i]!=nowChar)
//                {
//                    nowChar = target[i];
//                    ++answer;
//                }
//            }

//            return answer;
//        }
//    }
//}




