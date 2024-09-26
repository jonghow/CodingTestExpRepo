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
 * Difficulty : Easy ~ Middle
 * URL : https://www.acmicpc.net/problem/21736
 */


namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Case 0 _ Short
            Solution solution = new Solution();
            solution.solve();
        }
    }

    public class Solution
    {
        public int n;
        public int m;

        public char[,] maps;
        public bool[,] visited;

        public int[] dx = new int[4] { 0, 0, -1, 1 };
        public int[] dy = new int[4] { 1, -1, 0, 0 };

        public int startPosX;
        public int startPosY;

        int ret;
        public void solve()
        {
            ret = 0;

            string[] inputs = Console.ReadLine().Split(' ');

            n = Int32.Parse(inputs[1]);
            m = Int32.Parse(inputs[0]);
            // 좌우 바꾸기

            maps = new char[m, n];
            visited = new bool[m, n];

            for (int i =0; i < m;++i)
            {
                string inputLine = Console.ReadLine();

                for(int j = 0; j < inputLine.Length; ++j)
                {
                    char chr = inputLine[j];

                    maps[i, j] = chr;

                    if(chr == 'I')
                    {
                        startPosX = i;
                        startPosY = j;
                    }

                    if (chr == 'X')
                    {
                        visited[i, j] = true;
                    }
                }
            }

            BFS();

            Console.Write(ret == 0 ? "TT" : ret.ToString());
        }

        public void BFS()
        {
            var q = new Queue<Tuple<int, int>>();

            q.Enqueue(new Tuple<int, int>(startPosX, startPosY));

            while(q.Count > 0)
            {
                var dequeue = q.Dequeue();

                var posX = dequeue.Item1;
                var posY = dequeue.Item2;

                if (visited[posX, posY] == true)
                    continue;

                visited[posX, posY] = true;

                if (maps[posX, posY] == 'P')
                    ++ret;

                for(int i = 0; i < 4; ++i)
                {
                    int newPosX = posX + dx[i];
                    int newPosY = posY + dy[i];

                    if (isCheckSafeArea(newPosX, newPosY) == false)
                        continue;

                    if (visited[newPosX, newPosY] == true)
                        continue;

                    q.Enqueue(new Tuple<int,int>(newPosX ,newPosY));
                }
            }
        }

        public bool isCheckSafeArea(int posX, int posY)
        {
            if (posX < 0 || posX > (m - 1) || posY < 0 || posY > (n - 1))
                return false;

            return true;
        }
    }
}
