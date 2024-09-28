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
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static CodingTestProj.Program;

/*
 * Difficulty : Middle
 * URL : https://www.acmicpc.net/problem/2583
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

    public class ColoringPos
    {
        public ColoringPos(int startX, int startY, int endX, int endY)
        {
            this.coloringStartPosX = startX;
            this.coloringStartPosY = startY;
            this.coloringEndPosX = endX;
            this.coloringEndPosY = endY;
        }

        public int coloringStartPosX;
        public int coloringStartPosY;

        public int coloringEndPosX;
        public int coloringEndPosY;
    }

    public class Solution
    {
        int n;
        int m;
        int k;

        bool[,] visited;

        int[] dx = new int[4] { 0, 0, -1, 1 };
        int[] dy = new int[4] { 1, -1, 0, 0 };

        List<ColoringPos> list = new List<ColoringPos>();

        List<int> sectorList = new List<int>();

        public void solve()
        { 
            string[] inputs = Console.ReadLine().Split(' ');
            n = Int32.Parse(inputs[0]);
            m = Int32.Parse(inputs[1]);
            k  = Int32.Parse(inputs[2]);

            visited = new bool[m, n];

            for(int i = 0; i < k; ++i)
            {
                inputs = Console.ReadLine().Split();
                list.Add(new ColoringPos(Int32.Parse(inputs[0]), Int32.Parse(inputs[1]), Int32.Parse(inputs[2]), Int32.Parse(inputs[3])));
            }

            for(int i = 0; i < list.Count; ++i)
            {
                var cor = list[i];

                for(int j = cor.coloringStartPosX; j < cor.coloringEndPosX; ++j)
                {
                    for(int k = cor.coloringStartPosY; k < cor.coloringEndPosY; ++k)
                    {
                        visited[j,k] = true;
                    }
                }
            }// 모눈종이 색칠하기

            for(int i = 0; i < visited.GetLength(0); ++i)
            {
                for(int j = 0; j < visited.GetLength(1); ++j)
                {
                    if(visited[i, j] == false)
                    {
                        int posX = i;
                        int posY = j;
                        BFS(i,j);
                    }
                }
            }

            Console.WriteLine(sectorList.Count);
            sectorList.Sort();

            for (int i = 0; i< sectorList.Count; ++i)
            {
                Console.Write(sectorList[i] + " ");
            }
        }
        
        public void BFS(int curPosX, int curPosY)
        {
            Queue<Tuple<int,int>> q = new Queue<Tuple<int, int>>();

            int sector = 0;
            q.Enqueue(new Tuple<int, int>(curPosX, curPosY));
            ++sector;

            while (q.Count > 0)
            {
                var deq = q.Dequeue();

                int posX = deq.Item1;
                int posY = deq.Item2;

                if (visited[posX, posY] == true)
                    continue;

                visited[posX, posY] = true;

                for(int i = 0; i < 4; ++i)
                {
                    int newPosX = posX + dx[i];
                    int newPosY = posY + dy[i];

                    if (isCheckSafeArea(newPosX, newPosY) == false)
                        continue;

                    if (visited[newPosX, newPosY] == true)
                        continue;

                    if (q.Contains(new Tuple<int, int>(newPosX, newPosY)) == true)
                        continue;

                    q.Enqueue(new Tuple<int,int>(newPosX, newPosY));
                    ++sector;
                }
            }
                sectorList.Add(sector);
        }

        public bool isCheckSafeArea(int posX, int posY)
        {
            if (posX < 0 || posX > (m - 1) || posY < 0 || posY > (n - 1))
                return false;

            return true;
        }
    }
}
