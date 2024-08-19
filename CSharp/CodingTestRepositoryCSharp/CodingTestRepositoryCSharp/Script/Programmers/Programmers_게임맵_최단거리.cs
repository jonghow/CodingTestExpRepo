//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
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

///*
// * URL : https://school.programmers.co.kr/learn/courses/30/lessons/1844
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        /*
//         * [1,0,1,1,1]
//         * [1,0,1,0,1]
//         * [1,0,1,1,1]
//         * [1,1,1,0,1]
//         * [0,0,0,0,1]
//         */

//        static public bool[,] isVisited;
//        static public int[] dx = new int[4] { 0, 0, -1, 1 }; // 
//        static public int[] dy = new int[4] { 1, -1, 0, 0 }; // 
//        static public int[] GoalPos;
//        static public int limitXPos = 0;
//        static public int limitYPos = 0;
//        static int[,] map;

//        static void Main(string[] args)
//        {
//            //int[,] map = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 } };
//            //int[,] map = { { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 } };

//            //TC 3 
//            //[[1, 1, 1, 1, 1], [1, 0, 0, 0, 1], [1, 0, 0, 0, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]] 9

//            //solution(map);
//        }
//        static void solution(int[,] maps)
//        {
//            limitXPos = maps.GetLength(0); // X 축 맵 길이
//            limitYPos = maps.GetLength(1); // Y 축 맵 길이

//            GoalPos = new int[2] { limitXPos -1, limitYPos -1};
//            map = maps;

//            int answer = 0;
//            BFS(0,0,out answer);
//        }

//        public static void BFS(int x, int y, out int result)
//        {
//            result = - 1;
//            Queue<(int, int)> q = new Queue<(int, int)> ();
//            q.Enqueue((0, 0));

//            while(q.Count > 0)
//            {
//                var curPos = q.Dequeue();

//                if(curPos.Item1 == GoalPos[0] && curPos.Item2 == GoalPos[1])
//                {
//                    result = map[curPos.Item1, curPos.Item2];
//                    return;
//                }

//                for(int i = 0; i < 4; ++i)
//                {
//                    int NextPosX = (curPos.Item1 + dx[i]);
//                    int NextPosY = (curPos.Item2 + dy[i]);

//                    if ((NextPosX >= map.GetLength(0)) || (NextPosX < 0) || (NextPosY >= map.GetLength(1) || (NextPosY < 0)))
//                        continue;

//                    if (map[NextPosX, NextPosY] != 1) continue;

//                    q.Enqueue((NextPosX, NextPosY));
//                    map[NextPosX, NextPosY] = (map[curPos.Item1, curPos.Item2] +1);
//                }
//            }
//            return;
//        }
//    }
//}




