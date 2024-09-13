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

//    public class Point
//    {
//        public int posX;
//        public int posY;

//        public Point(int x, int y)
//        {
//            posX = x; posY = y;
//        }
//    }

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

//        static int warning;

//        public static List<Point> bombPos = new List<Point>();

//        static void Main(string[] args)
//        {
//            int[,] map = { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 2, 0, 1, 0, 0 } , { 0, 0, 0, 0, 0, 0, 0 } };
//            warning = 0;

//            //int[,] map = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 } };
//            //int[,] map = { { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 } };

//            //TC 3 
//            //[[1, 1, 1, 1, 1], [1, 0, 0, 0, 1], [1, 0, 0, 0, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]] 9

//            solution(map);
//        }
//        static void solution(int[,] maps)
//        {
//            limitXPos = maps.GetLength(0); // X 축 맵 길이
//            limitYPos = maps.GetLength(1); // Y 축 맵 길이

//            isVisited = new bool[limitXPos - 1, limitYPos - 1];
//            GoalPos = new int[2] { limitXPos - 1, limitYPos - 1 };
//            map = maps;

//            int answer = 0;
//            findBomb();

//            for(int i =0; i < bombPos.Count; ++i)
//            {
//                var posX = bombPos[i].posX;
//                var posY = bombPos[i].posY;
//                DFS(posX, posX, 0, 4);
//            }
//        }

//        public static void findBomb()
//        {
//            for (int i = 0; i < map.GetLength(0); i++)
//            {
//                for (int j = 0; j < map.GetLength(1); j++)
//                {
//                    int maps = map[i, j];

//                    if (maps == 1)
//                        bombPos.Add(new Point(i, j));
//                }
//            }
//        }

//        public static void DFS(int x, int y, int type, int count)
//        {
//            if (0 > x || 0 > y || x >= limitXPos-1 || y >= limitYPos-1)
//                return;

//            if (count == 0)
//                return;

//            isVisited[x, y] = true;

//            if (map[x, y] == 2)
//                return;

//            int NextPosX = 0;
//            int NextPosY = 0;
//            ++warning;

//            if (type == 0)
//            {
//                NextPosX = (x + dx[0]);
//                NextPosY = (y + dy[0]);
//                count = 4;
//                DFS(NextPosX, NextPosY, 1, --count);

//                NextPosX = (x + dx[1]);
//                NextPosY = (y + dy[1]);
//                count = 4;
//                DFS(NextPosX, NextPosY, 2, --count);

//                NextPosX = (x + dx[2]);
//                NextPosY = (y + dy[2]);
//                count = 4;
//                DFS(NextPosX, NextPosY, 3, --count);

//                NextPosX = (x + dx[3]);
//                NextPosY = (y + dy[3]);
//                count = 4;
//                DFS(NextPosX, NextPosY, 4, --count);
//            }

//            if (type == 1)
//            {
//                NextPosX = (x + dx[0]);
//                NextPosY = (y + dy[0]);
//                DFS(NextPosX, NextPosY, 1, --count);
//            }

//            if (type == 2)
//            {
//                NextPosX = (x + dx[1]);
//                NextPosY = (y + dy[1]);
//                DFS(NextPosX, NextPosY, 2, --count);
//            }

//            if (type == 3)
//            {
//                NextPosX = (x + dx[2]);
//                NextPosY = (y + dy[2]);
//                DFS(NextPosX, NextPosY, 3, --count);
//            }

//            if (type == 4)
//            {
//                NextPosX = (x + dx[3]);
//                NextPosY = (y + dy[3]);
//                DFS(NextPosX, NextPosY, 4, --count);
//            }
//            return;
//        }
//    }
//}




