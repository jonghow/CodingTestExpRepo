//using System;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * URL : https://www.acmicpc.net/problem/16918
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        public static int row;
//        public static int vertical;
//        public static int sec;

//        static void Main(string[] args)
//        {
//            string read = Console.ReadLine();
//            string[] splitRead = read.Split(' ');

//            row = Int32.Parse(splitRead[0]);
//            vertical = Int32.Parse(splitRead[1]);
//            sec = Int32.Parse(splitRead[2]);

//            Solution solu = new Solution();
//            solu.Solve();
//        }
//    }

//    public struct Point
//    {
//        public int x;
//        public int y;

//        public Point(int x,int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    public class Solution
//    {
//        public bool[,] isVisited;
//        public int[] dx = new int[4] { 0, 0, -1, 1 };
//        public int[] dy = new int[4] { 1, -1, 0, 0 }; // 상하좌우

//        public int[,] maps;

//        Queue<Point> queuebomb = new Queue<Point>();
//        // R,C,N 은 모두 1 <= R C N <= 200

//        public Solution()
//        {
//            isVisited = new bool[row, vertical];
//            maps = new int[row, vertical];

//            for (int i = 0; i < row; ++i)
//            {
//                string readChar = Console.ReadLine();

//                for (int j = 0; j < vertical; ++j)
//                {
//                    char chr = readChar[j];

//                    if(chr == 'O')
//                    {
//                        maps[i, j] = 3; // 3은 카운트
//                    }
//                    else
//                    {
//                        maps[i, j] = -1; // -1 빈칸,
//                        //queuebomb.Enqueue(new Point(i, j));
//                    }
//                }
//            }

//            SetBomb();
//            --sec;
//        }

//        public void printInitTypeBomb()
//        {
//            for (int i = 0; i < maps.GetLength(0); ++i)
//            {
//                for (int j = 0; j < maps.GetLength(1); ++j)
//                {
//                    if(maps[i,j] < 0)
//                    {
//                        Console.Write('.');
//                    }
//                    else
//                    {
//                        Console.Write('O');
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//        public void printRowColumbAllBomb()
//        {
//            for(int i = 0; i < row; ++i)
//            {
//                for(int j = 0; j < vertical; ++j)
//                {
//                    Console.Write('O');
//                }

//                Console.WriteLine();
//            }
//        }

//        public void Solve()
//        {
//            int devide = (sec+1) % 2;

//            if(devide == 0 )
//            {
//                // 모든 폭탄이 다 있는거
//                printRowColumbAllBomb();
//            }
//            else
//            {
//                devide = (sec + 1) % 4;

//                if(devide == 3)
//                {
//                    loop();
//                    printBaseVisited();
//                }
//                else if (devide == 1)
//                {
//                    printInitTypeBomb();
//                }
//            }
//        }

//        public void loop()
//        {
//            for (int i = 0; i < sec; ++i)
//            {



//                for (int j = 0; j < row; ++j)
//                {
//                    for (int k = 0; k < vertical; ++k)
//                    {
//                        if (maps[j, k] == -1)
//                            continue;

//                        if (maps[j, k] > 0)
//                            --maps[j, k];

//                        if (maps[j, k] == 0)
//                        {
//                            maps[j, k] = -1;
//                            queuebomb.Enqueue(new Point(j, k));
//                        }
//                    }
//                }

//                while (queuebomb.Count > 0)
//                {
//                    Point pt = queuebomb.Peek();
//                    queuebomb.Dequeue();

//                    for (int m = 0; m < 4; ++m)
//                    {
//                        int newPosX = pt.x + dx[m];
//                        int newPosY = pt.y + dy[m];

//                        if (newPosX < 0 || newPosY < 0 || newPosX >= row || newPosY >= vertical)
//                            continue;

//                        maps[newPosX, newPosY] = -1;
//                    }
//                }
//                if (i % 2 == 0 && i != 0)
//                {
//                    SetBomb();
//                }

//            }
//        }

//        public void SetBomb()
//        {
//            for(int i = 0; i < row; ++i)
//            {
//                for(int j = 0; j < vertical; ++j)
//                {
//                    if(maps[i,j] == -1)
//                    {
//                        maps[i, j] = 3;
//                    }
//                }
//            }
//        }

//        public void printBaseVisited()
//        {
//            for (int i = 0; i < maps.GetLength(0); ++i)
//            {
//                for (int j = 0; j < maps.GetLength(1); ++j)
//                {
//                    if(maps[i,j]  > 0)
//                    {
//                        Console.Write('O');
//                    }
//                    else
//                    {
//                        Console.Write('.');
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//        //1t : 1h 56m
//    }
//}


