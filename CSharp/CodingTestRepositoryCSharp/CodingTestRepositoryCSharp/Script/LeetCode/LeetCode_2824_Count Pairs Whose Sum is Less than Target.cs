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
// * Difficulty : Easy
// * URL : https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/
// */

//public class Solution
//{
//    public int CountPairs(IList<int> nums, int target)
//    {

//        int answer = 0;

//        for (int i = 0; i < nums.Count; ++i)
//        {
//            for (int j = i + 1; j < nums.Count; ++j)
//            {
//                int fst = nums[i];
//                int snd = nums[j];

//                if (fst + snd < target)
//                    ++answer;
//            }
//        }

//        return answer;
//    }
//}



