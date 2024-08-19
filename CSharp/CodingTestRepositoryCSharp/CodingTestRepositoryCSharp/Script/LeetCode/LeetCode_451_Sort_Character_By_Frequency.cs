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
//            //s.FrequencySort("tree");
//            //s.FrequencySort("cccaaa");
//            s.FrequencySort("Aabb");
//        }
//    }

//    public class PairCharCount
//    {
//        public char key;
//        public int count;

//        public PairCharCount()
//        {
//            this.key = 'a';
//            this.count = 0;
//        }// Default Creator

//        public PairCharCount(char key)
//        {
//            this.key = key;
//            this.count = 0;
//        }

//        public void SetChar(char key)
//        {
//            this.key = key;
//        }

//        public void PlusCount()
//        {
//            ++this.count;
//        }
//    }

//    public class Solution
//    {

//        List<PairCharCount> charList = new List<PairCharCount>();

//        public string FrequencySort(string s)
//        {
//            StringBuilder sb = new StringBuilder();
//            string answer = string.Empty;

//            for (int i = 0; i < s.Length; ++i)
//            {
//                char element = s[i];

//                if (charList.Exists(rhs => rhs.key == element) == false)
//                    charList.Add(new PairCharCount(element));

//                var elementPair = charList.Find(rhs => rhs.key == element);
//                elementPair.PlusCount();
//            }

//            charList.Sort((a1, a2) => a2.count.CompareTo(a1.count));

//            for (int i = 0; i < charList.Count; ++i)
//            {
//                var element = charList[i];

//                for (int j = 0; j < element.count; ++j)
//                    sb.Append(element.key);
//            }

//            answer = sb.ToString();
//            return answer;
//        }
//    }
//}




