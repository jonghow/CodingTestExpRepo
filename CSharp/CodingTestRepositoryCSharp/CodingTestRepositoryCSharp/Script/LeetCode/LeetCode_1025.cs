//using System;
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

///*
// * URL : https://leetcode.com/problems/divisor-game/description/
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int insert = 9;

//            Solution solu = new Solution();
//            solu.DivisorGame(insert);
//        }
//    }

//    public class Solution
//    {

//        public int nMax = 1001;
//        public bool[] result;
//        public static int Number;

//        public bool DivisorGame(int n)
//        {
//            Init(); // 결과 메모이제이션이라 상관없을 듯,
//                    // 0 < x < n , n % x == 0 

//            Number = n; 

//            if (Number == 0) return false;
//            if (Number == 1) return false;
//            if (Number == 2) return true;
//            if (Number == 3) return false;

//            if (TryGetResult(Number) == true)
//                return true;

//            result[Number] = MakeResult(Number);
//            return result[Number];
//        }

//        public bool MakeResult(int n) // adding 는 가중, count는 
//        {
//            if (n == 1)
//                return false;

//            List<int> SelectedNumbers = new List<int>();

//            MakeSelectedNumber(n, ref SelectedNumbers);

//            for (int i = 0; i < SelectedNumbers.Count; ++i)
//            {
//                if (0 >= n - SelectedNumbers[i]) continue;
//                return !MakeResult(n - SelectedNumbers[i]);
//            }

//            return false;
//        }

//        public void MakeSelectedNumber(int n, ref List<int> selectedNumber)
//        {
//            for (int i = 0; i < n; ++i)
//            {
//                if (i == 0) continue;
//                if (n % i == 0)
//                    selectedNumber.Add(i);
//            }
//        }


//        public void Init()
//        {
//            result = new bool[nMax];

//            result[0] = false; // 있을리도 없지만, False 처리
//            result[1] = false; // 앨리스가 선택할 수 없기때문에 false,
//            result[2] = true;
//            result[3] = false; // 앨리스 패배
//        }

//        public bool TryGetResult(int n)
//        {
//            return result[n];
//        }
//    }

//}




