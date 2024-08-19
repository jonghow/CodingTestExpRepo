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
// * URL : https://leetcode.com/problems/all-paths-from-source-to-target/
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        public class Graph
//        {

//        } // 그래프 풀이도 가능할 것 같다.

//        // Q

//        const int s_iMaxNodeCount = 20;
//        public static int s_ipathIndex = 0;
//        public static int s_iGoalPos = 0;

//        public static List<List<int>> maps = new List<List<int>>();
//        public static Stack<int> recordPath = new Stack<int>();

//        static void Main(string[] args)
//        {
//            int[][] graph = new int[][]
//            {
//                new int[] { 1, 2 , },
//                new int[] { 3 },
//                new int[] { 3 },
//                new int[] {}
//            };



//            Program mm = new Program();
//            mm.AllPathsSourceTarget(graph);

//            int[][] graph2 = new int[][]
//{
//                new int[] { 4, 3 , 1},
//                new int[] { 3, 2, 4 },
//                new int[] { 3 },
//                new int[] { 4} ,
//                new int[] {} ,
//};

//            mm.AllPathsSourceTarget(graph2);

//        }
//        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
//        {
//            maps.Clear();
//            recordPath.Clear();
//            s_ipathIndex = 0;
//            IList<IList<int>> resultList = new List<IList<int>>();
//            resultList.Clear();

//            int NodeCount = graph.GetLength(0);
//            s_iGoalPos = NodeCount - 1; // 목적지

//            for (int i = 0; i < NodeCount; ++i)
//            {
//                maps.Add(new List<int>()); // 0 은 0 라벨 노드
//                var mapsIndex = i;

//                for (int j = 0; j < graph[i].Length; ++j)
//                {
//                    var edge = graph[i][j];
//                    maps[mapsIndex].Add(edge);
//                }
//            }
//            // 맵 매핑 완료

//            bool[] isVisit = new bool[s_iMaxNodeCount];
//            for (int i = 0; i < s_iMaxNodeCount; ++i)
//            {
//                isVisit[i] = false;
//            }

//            DFS(ref resultList, 0, ref isVisit);
//            return resultList;
//        }


//        public void DFS(ref IList<IList<int>> result, int currentNode, ref bool[] isVisit)
//        {
//            if (isVisit[currentNode] == true)
//            {
//                if (recordPath.Count > 0) recordPath.Pop();
//                return; // 방문했다면 종료
//            }

//            isVisit[currentNode] = true;
//            recordPath.Push(currentNode);

//            if (result.Count <= s_ipathIndex)
//                result.Add(new List<int>());

//            if (currentNode == s_iGoalPos)
//            {
//                result[s_ipathIndex].Clear();

//                for (int i = recordPath.Count - 1; i >= 0; --i)
//                {
//                    var node = recordPath.ElementAt(i);
//                    result[s_ipathIndex].Add(node);
//                }

//                ++s_ipathIndex;
//                return;
//            }

//            for (int i = 0; i < maps[currentNode].Count; ++i)
//            {
//                var node = maps[currentNode][i];

//                DFS(ref result, node, ref isVisit);
//                isVisit[node] = false;
//                recordPath.Pop();
//            }
//        }
//    }
//}




