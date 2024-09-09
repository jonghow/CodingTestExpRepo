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
//using System.Collections.Generic;

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

//    public class Solution
//    {
//        public bool[,] isVisited;
//        public int[] dx = new int[4] { 0, 0, -1, 1 };
//        public int[] dy = new int[4] { 1, -1, 0, 0 }; // 상하좌우

//        public char[,] maps;

//        List<Tuple<int, int>> bomb = new List<Tuple<int, int>>(); 
//        // R,C,N 은 모두 1 <= R C N <= 200
//        public Solution()
//        {
//            isVisited = new bool[row, vertical];
//            maps = new char[row, vertical];

//            for (int i = 0; i < row; ++i)
//            {
//                string readChar = Console.ReadLine();

//                for (int j = 0; j < vertical; ++j)
//                {
//                    maps[i, j] = readChar[j];

//                    if (readChar[j] == 'O')
//                    {
//                        bomb.Add(new Tuple<int, int>(i, j));
//                    }
//                }
//            }
//        }

//        public void printInitTypeBomb()
//        {
//            for (int i = 0; i < isVisited.GetLength(0); ++i)
//            {
//                for (int j = 0; j < vertical; ++j)
//                {
//                    char chr = maps[i, j];
//                    Console.Write(chr);

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
//            int devide = sec % 2;

//            if(devide == 0 )
//            {
//                // 모든 폭탄이 다 있는거
//                printRowColumbAllBomb();
//            }
//            else
//            {
//                devide = sec % 4;

//                if(devide == 3)
//                {
//                    for (int i = 0; i < bomb.Count; ++i)
//                    {
//                        var bombPair = bomb[i];
//                        var posx = bombPair.Item1;
//                        var posy = bombPair.Item2;

//                        dfs(posx, posy, 1, false);
//                    }

//                    printBaseVisited();
//                }
//                else if (devide == 1)
//                {
//                    printInitTypeBomb();
//                }
//            }
//        }

//        public void dfs(int x , int y, int count, bool isbomb)
//        {
//            if (x < 0 || y < 0 || x >= row || y >= vertical)
//                return; // 영엮밖이라면 종료

//            if (count < 0)
//                return;

//            isVisited[x, y] = true;

//            if (isbomb == true)
//                return; // 폭탄이라면 내 자리만 폭발

//            for (int i = 0; i < 4; ++i)
//            {
//                int newPosX = x + dx[i];
//                int newPosY = y + dy[i];
//                int cnt = count - 1;

//                char nextTileisInfo = 'a';

//                if (newPosX < 0 || newPosY < 0 || newPosX >= row || newPosY >= vertical) { }
//                else
//                {
//                    nextTileisInfo = maps[newPosX, newPosY];
//                }

//                bool isNextBomb = nextTileisInfo == 'O' ? true : false;
//                dfs(newPosX, newPosY, cnt, isNextBomb);
//            }
//        }

//        public void printBaseVisited()
//        {
//            for (int i = 0; i < isVisited.GetLength(0); ++i)
//            {
                
//                for (int j = 0; j < isVisited.GetLength(1); ++j)
//                {
//                    if(isVisited[i,j] == true)
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

//        //1t : 1h 56m

//    }

//}

////
////3 3 5
////OO.
////OOO
////OOO
////
////



