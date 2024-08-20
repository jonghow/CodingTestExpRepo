//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

//public class Solution
//{
//    public int solution(int[] citations)
//    {
//        int answer = 0;
//        Array.Sort(citations);
//        List<int> list = new List<int>();

//        if (citations.Length == 1)
//            return citations[0];

//        for (int i = 0; i < citations.Length; ++i)
//            list.Add(citations[i]);

//        list.Sort((int a, int b) => { return b.CompareTo(a); });

//        for (int i = 0; i < list.Count; ++i)
//        {
//            int index = i + 1;
//            int count = list.FindAll(rhs => rhs >= index).Count;

//            if (index <= count)
//                answer = index;
//        }


//        return answer;
//    }
//}



