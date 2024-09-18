//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Xml.Linq;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //int n = 4;
//            int n = 7;
//            //int q = 2;
//            int q = 6;
//            //int[] a = new int[3] { 1, 1, 3 };
//            int[] a = new int[6] { 1, 2, 1, 4, 4, 5};

//            //int[,] question = new int[2, 2] { { 4, 2 }, { 4, 3 } };
//            int[,] question = new int[6, 2] { { 2, 1 }, { 5, 4}, { 4,3},{ 5,7},{ 3,2},{ 7,4} };
//            Solution.solution(n, q, a, question);





















//        }
//    }

//    public static class Solution
//    {
//        public static string[] solution(int n, int q, int[] a, int[,] question)
//        {
//            var answer = new List<string>();
//            int curSkillNumb = 2; // 2 부터 시작

//            Graph graph = new Graph();

//            for (int i = 0; i < a.Length; ++i)
//            {
//                graph.AddEdge(curSkillNumb, a[i]);
//                curSkillNumb++;
//            }

//            graph.FindAllGroups();

//            return answer.ToArray();
//        }
//    }

//    class Graph
//    {
//        // Dictionary를 사용한 인접 리스트
//        Dictionary<int, List<int>> adjList;
//        public Graph()
//        {
//            adjList = new Dictionary<int, List<int>>();
//        }

//        public void AddEdge(int u, int v)
//        {
//            if (!adjList.ContainsKey(u))
//            {
//                adjList[u] = new List<int>();
//            }
//            adjList[u].Add(v);

//            if (!adjList.ContainsKey(v))
//            {
//                adjList[v] = new List<int>();
//            }
//            adjList[v].Add(u);
//        }

//        public List<int> BFS(int start, HashSet<int> visited)
//        {
//            Queue<int> queue = new Queue<int>();
//            List<int> group = new List<int>();

//            queue.Enqueue(start);
//            visited.Add(start);

//            while (queue.Count > 0)
//            {
//                int node = queue.Dequeue();
//                group.Add(node);

//                foreach (int neighbor in adjList[node])
//                {
//                    if (!visited.Contains(neighbor))
//                    {
//                        visited.Add(neighbor);
//                        queue.Enqueue(neighbor);
//                    }
//                }
//            }

//            return group; // 탐색한 노드들이 속한 그룹을 반환
//        }

//        public List<string> FindAllGroups()
//        {
//            HashSet<int> visited = new HashSet<int>(); // 방문 체크
//            List<string> groups = new List<string>();

//            foreach (var node in adjList.Keys)
//            {
//                if (!visited.Contains(node))
//                {
//                    List<int> group = BFS2(node, adjList[node]);
//                    groups.Add(group);
//                }
//            }

//            return groups; // 그룹 반환
//        }

//        public string BFS2(int start,int goal, HashSet<int> visited)
//        {
//            Queue<int> queue = new Queue<int>();
//            List<int> group = new List<int>();

//            queue.Enqueue(start);
//            visited.Add(start);

//            while (queue.Count > 0)
//            {
//                int node = queue.Dequeue();
//                group.Add(node);

//                foreach (int neighbor in adjList[node])
//                {
//                    if (!visited.Contains(neighbor))
//                    {
//                        visited.Add(neighbor);
//                        queue.Enqueue(neighbor);
//                    }
//                }
//            }

//            if (visited.Contains(goal) == false)
//                return "no";

//            return "yes";
//        }

//        public void PrintAdjList()
//        {
//            foreach (var node in adjList)
//            {
//                Console.Write($"{node.Key}: ");
//                foreach (var neighbor in node.Value)
//                {
//                    Console.Write($"{neighbor} ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }




//}



