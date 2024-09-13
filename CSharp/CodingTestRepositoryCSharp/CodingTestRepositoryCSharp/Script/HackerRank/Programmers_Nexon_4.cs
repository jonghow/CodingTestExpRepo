//using System;
//using System.Collections.Generic;
//using System.Threading;

//class Graph
//{
//    // Dictionary를 사용한 인접 리스트
//    Dictionary<int, List<int>> adjList;
//    public Graph()
//    {
//        adjList = new Dictionary<int, List<int>>();
//    }

//    public void AddEdge(int u, int v)
//    {
//        if (!adjList.ContainsKey(u))
//        {
//            adjList[u] = new List<int>();
//        }
//        adjList[u].Add(v);

//        if (!adjList.ContainsKey(v))
//        {
//            adjList[v] = new List<int>();
//        }
//        adjList[v].Add(u);
//    }

//    public List<int> BFS(int start, HashSet<int> visited)
//    {
//        Queue<int> queue = new Queue<int>();
//        List<int> group = new List<int>();

//        queue.Enqueue(start);
//        visited.Add(start);

//        while (queue.Count > 0)
//        {
//            int node = queue.Dequeue();
//            group.Add(node);

//            foreach (int neighbor in adjList[node])
//            {
//                if (!visited.Contains(neighbor))
//                {
//                    visited.Add(neighbor);
//                    queue.Enqueue(neighbor);
//                }
//            }
//        }

//        return group; // 탐색한 노드들이 속한 그룹을 반환
//    }

//    public List<List<int>> FindAllGroups()
//    {
//        HashSet<int> visited = new HashSet<int>(); // 방문 체크
//        List<List<int>> groups = new List<List<int>>();

//        foreach (var node in adjList.Keys)
//        {
//            if (!visited.Contains(node))
//            {
//                List<int> group = BFS(node, visited);
//                groups.Add(group);
//            }
//        }

//        return groups; // 그룹 반환
//    }

//    public void PrintAdjList()
//    {
//        foreach (var node in adjList)
//        {
//            Console.Write($"{node.Key}: ");
//            foreach (var neighbor in node.Value)
//            {
//                Console.Write($"{neighbor} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//public class Program
//{
//    public static int maxValue = 0;
//    public static void Main()
//    {
//        string input = Console.ReadLine();
//        string[] inputArr = input.Split(' ');

//        int count= int.Parse(inputArr[0]);
//        int n= int.Parse(inputArr[1]);

//        Graph graph = new Graph();

//        for(int i = 0; i < count; ++i)
//        {
//            input = Console.ReadLine();
//            inputArr = input.Split(' ');

//            int start = int.Parse(inputArr[0]);
//            int end = int.Parse(inputArr[1]);

//            if(maxValue <= start)
//                maxValue = start;

//            if (maxValue <= end)
//                maxValue = end;

//            graph.AddEdge(start, end);
//        }

//        var retList = graph.FindAllGroups();
//        retList.RemoveAll(rhs => rhs.Count > n);

//        int ret = 0;
//        for(int i = 0; i < retList.Count; ++i)
//            ret += retList[i].Count;

//        Console.WriteLine(ret);
//    }
//}