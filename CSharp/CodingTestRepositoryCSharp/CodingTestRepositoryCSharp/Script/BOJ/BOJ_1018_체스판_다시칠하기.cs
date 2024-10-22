//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/1018
//  * Time : 35m
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();
//            ss.Solve();
//        }
//    }

//    public class Solution
//    {
//        public int x;
//        public int y;

//        public int ret;

//        public char[,] _arr_v1 = new char[8, 8]
//        {
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//        };

//        public char[,] _arr_v2 = new char[8, 8]
//        {
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//            { 'W' ,'B','W','B','W','B','W','B'},
//            { 'B' ,'W','B','W','B','W','B','W'},
//        };

//        public char[,] _board;

//        public void Solve()
//        {
//            ret = int.MaxValue;
//            string[] input = Console.ReadLine().Split(' ');

//            x = Int32.Parse(input[0]);
//            y = Int32.Parse(input[1]);

//            _board = new char[x, y];

//            for (int i = 0; i < x; ++i)
//            {
//                string inBoard = Console.ReadLine();
//                for(int j = 0; j < inBoard.Length; ++j)
//                {
//                    _board[i,j] = inBoard[j];
//                }
//            }

//            int curPosX = 0;
//            int curPosY = 0;

//            for(int i = 0; i < y - 7;  ++i)
//            {
//                for(int j = 0; j < x - 7; ++j)
//                {
//                    curPosX = j;
//                    curPosY = i;

//                    Find(curPosX, curPosY);
//                }
//            }

//            print();
//        }

//        public void Find(int posX, int posY)
//        {
//            char[,] useCopyBoard = new char[y, x];
//            useCopyBoard = _arr_v1;

//            int _ret = 0;

//            for (int i = 0; i < 8; ++i)
//            {
//                for(int j = 0; j < 8;++j)
//                {
//                    int newPosX = posX + j;
//                    int newPosY = posY + i;

//                    if (_board[newPosX, newPosY] == useCopyBoard[j, i])
//                        continue;

//                    ++_ret;
//                }
//            }

//            if (ret >= _ret)
//                ret = _ret;

//            useCopyBoard = _arr_v2;
//            _ret = 0;
//            for (int i = 0; i < 8; ++i)
//            {
//                for (int j = 0; j < 8; ++j)
//                {
//                    int newPosX = posX + j;
//                    int newPosY = posY + i;

//                    if (_board[newPosX, newPosY] == useCopyBoard[j, i])
//                        continue;

//                    ++_ret;
//                }
//            }

//            if (ret >= _ret)
//                ret = _ret;
//        }

//        public void print()
//        {
//            Console.WriteLine(ret);
//        }
//    }
//}