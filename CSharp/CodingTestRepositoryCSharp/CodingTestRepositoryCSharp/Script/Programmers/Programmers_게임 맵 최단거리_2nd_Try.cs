using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

///*
// * URL : https://school.programmers.co.kr/learn/courses/30/lessons/1844
// */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] map = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 } };
            int[,] map = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 1 } };
            //            //TC 3 
            //int[,] map = { { 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 1 }, { 1, 0, 0, 0, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } }; //9
            Solution s = new Solution();
            s.solution(map);
        }
    }


    class Solution
    {
        //        /*
        //         * [1,0,1,1,1]
        //         * [1,0,1,0,1]
        //         * [1,0,1,1,1]
        //         * [1,1,1,0,1]
        //         * [0,0,0,0,1]
        //         */

        // TC 3
        //        /*
        //         * [1,1,1,1,1]
        //         * [1,0,0,0,1]
        //         * [1,0,0,0,1]
        //         * [1,1,1,1,1]
        //         * [1,1,1,1,1]
        //         */

        public int n;
        public int m;
        // 1 <= n,m <= 100

        public int[] dx = new int[4] { 0, 0, -1, 1 };
        public int[] dy = new int[4] { 1, -1, 0, 0 };
        // 상하좌우 순서

        public int[,] originMaps;
        // 원래 맵, 이것은 Visit, 갈 수 있는 길 모두를 판단가능

        public bool[,] isVisited;

        public int startX;
        public int startY;

        public int solution(int[,] maps)
        {
            n = maps.GetLength(0);
            m = maps.GetLength(1);

            if (n == 1 && m == 1)
                return 1;

            originMaps = maps;
            isVisited = new bool[n, m];

            startX = 0;
            startY = 0;

            BFS(startX, startY);

            return originMaps[n - 1, m - 1] == 1 ? -1 : originMaps[n - 1, m - 1];
        }

        public void BFS(int x, int y)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((x, y));

            while (q.Count > 0)
            {
                var top = q.Dequeue();

                int posX = top.Item1;
                int posY = top.Item2;

                if ((n - 1) == posX && (m - 1) == posY)
                    return;

                for (int i = 0; i < 4; ++i)
                {
                    int newPosX = posX + dx[i];
                    int newPosY = posY + dy[i];

                    if (isSafetyArea(newPosX, newPosY) == false)
                        continue;

                    if (originMaps[newPosX, newPosY] != 1)
                        continue;

                    q.Enqueue((newPosX, newPosY));
                    originMaps[newPosX, newPosY] = originMaps[posX, posY] + 1;
                }
            }
        }

        public bool isSafetyArea(int newX, int newY)
        {
            if (newX < 0 || newX >= n || newY < 0 || newY >= m)
                return false;

            return true;
        }
    }
}



