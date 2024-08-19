////using System;
////using System.Collections.Generic;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml;
//using System.Xml.Linq;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution s = new Solution();
//            List<int> arr = new List<int>();
//            arr.Add(1);
//            arr.Add(1);
//            arr.Add(3);
//            arr.Add(3);
//            arr.Add(0);
//            arr.Add(1);
//            arr.Add(1);

//            s.solution(arr);
//        }
//    }



//    public class Solution
//    {
//        //public List<int> solution(List<int> arr)
//        //{
//        //    List<int> answer = new List<int>();
//        //    answer.Add(arr[0]);

//        //    for (int i = 1; i < arr.Count; ++i)
//        //    {
//        //        if (answer[i + 1] == answer[i])
//        //            continue;

//        //        answer.Add(arr[i]);
//        //    }


//        //    return answer;
//        //}

//        public List<int> solution(List<int> arr)
//        {
//            List<int> answer = new List<int>();
//            Stack<int> st = new Stack<int>();

//            st.Push(arr[0]);

//            int counter = 1;

//            while (counter < arr.Count)
//            {
//                int topValue = st.Peek();
//                //st.Pop();

//                if (arr[counter] == topValue)
//                {
//                    ++counter;
//                    continue;
//                }


//                st.Push(arr[counter]);

//                ++counter;
//            }

//            List<int> dummy = new List<int>() ;

//            while (true)
//            {
//                if (st.Count == 0)
//                    break;

//                int value = st.Peek();
//                st.Pop();

//                dummy.Add(value);
//            }

//            for (int i = dummy.Count - 1; i >= 0; --i)
//            {
//                answer.Add(dummy[i]);
//            }





//            return answer;
//        }

//    }

//    //public class Solution
//    //{
//    //    public int solution(string[,] clothes)
//    //    {
//    //        int answer = 1;
//    //        List<Tuple<string, int>> categories = new List<Tuple<string, int>>();

//    //        for (int i = 0; i < clothes.GetLength(0); ++i)
//    //        {
//    //            var category = clothes[i, 1];
//    //            if (categories.Exists(rhs => rhs.Item1 == category) == false)
//    //                categories.Add(new Tuple<string, int>(category, 1));
//    //            else
//    //            {
//    //                Tuple<string, int> tuples = categories.Find(rhs => rhs.Item1 == category);
//    //                categories.Remove(tuples);

//    //                Tuple<string, int> newTuples = new Tuple<string, int>(tuples.Item1, tuples.Item2 + 1);
//    //                categories.Add(newTuples);
//    //            }
//    //        }

//    //        for (int i = 0; i < categories.Count; ++i)
//    //            answer *= (categories[i].Item2 + 1);

//    //        return answer - 1;
//    //    }
//    //}
//}



