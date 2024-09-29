using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
 * Difficulty : 
 * URL : https://www.acmicpc.net/problem/1926
 * Time : 01h 10m , Failed
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
        int n;
        int m;

        int[,] maps;
        bool[,] visited;

        int[] dx = new int[4] { 0, 0, -1, 1 };
        int[] dy = new int[4] { 1, -1, 0, 0 };

        List<int> retList = new List<int>();

        public void solve()
        {
            string input = Console.ReadLine().Replace(" ", string.Empty);

            n = Convert.ToInt32(input[0].ToString());
            m = Convert.ToInt32(input[1].ToString());

            maps = new int[n, m];
            visited = new bool[n, m];

            for (int i = 0; i < maps.GetLength(0); i++)
            {
                input = Console.ReadLine().Replace(" ", string.Empty);

                for (int j = 0; j < input.Length; ++j)
                {
                    maps[i, j] = Convert.ToInt32(input[j].ToString());

                    if (maps[i, j] == 0)
                        visited[i, j] = true;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (visited[i, j] == false)
                    {
                        int posX = i;
                        int posY = j;
                        BFS(posX, posY);
                    }
                }
            }
            Print();
        }
        public void BFS(int posX, int posY)
        {
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

            q.Enqueue(new Tuple<int, int>(posX, posY));
            int ret = 0;
            ++ret;

            while (q.Count > 0)
            {
                var deq = q.Dequeue();

                int curPosX = deq.Item1;
                int curPosY = deq.Item2;

                visited[curPosX, curPosY] = true;

                for (int i = 0; i < 4; ++i)
                {
                    int newPosX = curPosX + dx[i];
                    int newPosY = curPosY + dy[i];

                    if (CheckSafeArea(newPosX, newPosY) == false)
                        continue;

                    if (visited[newPosX, newPosY] == true)
                        continue;

                    visited[newPosX, newPosY] = true;

                    q.Enqueue(new Tuple<int, int>(newPosX, newPosY));
                    ++ret;
                }
            }

            retList.Add(ret);
        }

        public bool CheckSafeArea(int newPosX, int newPosY)
        {
            if (newPosX < 0 || newPosY < 0 || newPosX > (n - 1) || newPosY > (m - 1))
                return false;

            return true;
        }

        public void Print()
        {
            retList.Sort((int a, int b) => { return b.CompareTo(a); });
            Console.WriteLine(retList.Count);
        }
    }
}
