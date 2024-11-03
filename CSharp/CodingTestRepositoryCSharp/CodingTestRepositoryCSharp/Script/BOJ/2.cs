//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();

//            int node = 4;

//            /*
//             * 4 4
//             * 1 3
//             * 4 3
//             * 4 2 
//             * 1 2
//             */



//            List<int> from = new List<int>();
//            //from.Add(1);
//            //from.Add(4);
//            //from.Add(4);
//            //from.Add(1);

//            List<int> to = new List<int>();
//            //to.Add(3);
//            //to.Add(3);
//            //to.Add(2);
//            //to.Add(2);

//            ss.solve(node, from, to);
//        }
//    }

//    public class MyGraph
//    {
//        public int _count;
//        public List<int>[] _list;

//        public bool[] _visited;

//        public List<int> _collectCycle = new List<int>();

//        public MyGraph(int _nodes)
//        {
//            _count = _nodes;
//            _list = new List<int>[_nodes+1];

//            for(int i = 1; i <=_count; ++i)
//            {
//                _list[i] = new List<int>();
//            }

//            _visited = new bool[_nodes+1];
//        }

//        public void AddEdge(int from, int to)
//        {
//            _list[from].Add(to);
//        }

//        public void Generate()
//        {
//            for(int i = 1; i <= _count; ++i)
//            {
//                var _number = i;
//                if (FindCycle(_number, -1))
//                {
//                    if (_collectCycle.Contains(_number) == false)
//                        _collectCycle.Add(_number);
//                }
//            }
//        }

//        public bool FindCycle(int _nodeNumber, int _prev)
//        {


//            _visited[_nodeNumber] = true;

//            for(int i = 1; i < _list[_nodeNumber].Count; ++i)
//            {
//                foreach(var next in _list[_nodeNumber])
//                {
//                    if (_visited[next]== false)
//                    {
//                        if(FindCycle(next, _nodeNumber))
//                            return true;
//                    }
//                    else if (next != _prev)
//                    {
//                        return true;
//                    }
//                }
//            }

//            return false;
//        }

//        public List<int> GetCycleCollection() => _collectCycle;

//        public void Clear()
//        {
//            _visited = new bool[_count+1];
//        }

//        public void DFS(ref int distance, int startNode, int _curNode, ref List<int> _collectList)
//        {
//            if (_visited[_curNode] == true)
//                return;

//            if (_collectCycle.Contains(_curNode) == true)
//                return;

//            _visited[_curNode] = true;

//            if (startNode != _curNode)
//                ++distance;

//            for(int i = 0; i < _list[_curNode].Count; ++i)
//            {
//                var nextNode = _list[_curNode][i];
//                distance += 1;
//                DFS(ref distance, startNode, nextNode, ref _collectList);
//            }
//        }
//    }

//    public class Solution
//    {
//        public int[] _ret;
//        public int _edgeCount;

//        public int _node;

//        public List<int> solve(int node, List<int> from, List<int> to)
//        {
//            _node = node;
//            _edgeCount = from.Count;
//            _ret = new int[node];

//            var _graph = new MyGraph(_node);

//            for(int i = 0; i < _edgeCount; ++i)
//            {
//                var edgeFrom = from[i];
//                var edgeTo = to[i];

//                _graph.AddEdge(edgeFrom, edgeTo);
//                _graph.AddEdge(edgeTo, edgeFrom);
//            }

//            _graph.Generate(); // cycle 구하고

//            var collect = _graph.GetCycleCollection();

            

//            for(int i = 1; i<= _node; ++i)
//            {
//                if (collect.Contains(i) == true) continue;
//                _graph.Clear();

//                int dst = 0;
//                _graph.DFS(ref dst, i, i, ref collect);
//                _ret[i-1] = dst;
//            }

//            return new List<int>(_ret);
//        }


//        public void Print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}
