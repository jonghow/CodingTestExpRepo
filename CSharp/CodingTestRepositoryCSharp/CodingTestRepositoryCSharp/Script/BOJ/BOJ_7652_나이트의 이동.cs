using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static CodingTestProj.Program;

/*
 * Difficulties : Easy ~ Middle
 * URL : https://www.acmicpc.net/source/84283179
 */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solve();
        }
    }

    public class Solution
    {
        public int mapLength;
        public bool[,] isVisited;
        public int[,] maps;
        public int knightPosX;
        public int knightPosY;

        public int goalPosX;
        public int goalPosY;

        public int[] dx = new int[8] { 2, 1, -1, -2, -2, -1, 1, 2 };
        public int[] dy = new int[8] { 1, 2, 2, 1, -1, -2, -2, -1 };

        /*
 * TC 는 3줄 
 * 첫줄 : 체스판 한변의 길이 4 <= a <= 300
 * 크기 : a * a
 * 
 * 체스판은 두 수의 쌍({0,0} ~ {(a-1),(a-1)}) 으로 나타낼 수 있음
 * 
 * 둘째줄 : 나이트의 현재 칸
 * 
 * 셋째줄 : 나이트가 이동하려고 하는 칸
 * 
 */

        public void solve()
        {
            int tc = Int32.Parse(Console.ReadLine());
            mapLength = 0;

            for (int i = 0; i < tc; ++i)
            {
                mapLength = Int32.Parse(Console.ReadLine());
                Init(mapLength);

                string[] curPos = Console.ReadLine().Split(' ');
                knightPosX = Int32.Parse(curPos[0]);
                knightPosY = Int32.Parse(curPos[1]);

                string[] goalPos = Console.ReadLine().Split(' ');
                goalPosX = Int32.Parse(goalPos[0]);
                goalPosY = Int32.Parse(goalPos[1]);

                BFS();
                Console.WriteLine(maps[goalPosX, goalPosY]);
            }
        }

        public void Init(int tc)
        {
            isVisited = new bool[tc, tc];
            maps = new int[tc, tc];

            knightPosX = 0;
            knightPosY = 0;
            goalPosX = 0;
            goalPosY = 0;
        }

        public void BFS()
        {
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

            q.Enqueue(new Tuple<int, int>(knightPosX, knightPosY));

            while (q.Count > 0)
            {
                var pos = q.Dequeue();

                if (isVisited[pos.Item1, pos.Item2] == true)
                    continue;

                isVisited[pos.Item1, pos.Item2] = true;

                if (pos.Item1 == goalPosX && pos.Item2 == goalPosY)
                    break;
                // 목적지 도착 시

                for (int i = 0; i < 8; ++i)
                {
                    var newPosX = pos.Item1 + dx[i];
                    var newPosY = pos.Item2 + dy[i];

                    if (isCheckSection(newPosX, newPosY) == false)
                        continue;

                    if (isVisited[newPosX, newPosY] == true)
                        continue;

                    maps[newPosX, newPosY] = maps[pos.Item1, pos.Item2] + 1;
                    q.Enqueue(new Tuple<int, int>(newPosX, newPosY));
                }
            }
        }

        public bool isCheckSection(int newPosX, int newPosY)
        {
            if (newPosX < 0 || newPosY < 0 || newPosX > mapLength - 1 || newPosY > mapLength - 1)
                return false;

            return true;
        }
    }
}
