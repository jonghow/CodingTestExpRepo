using System;
using System.CodeDom;
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
 * Difficulty : Middle
 * URL : https://www.acmicpc.net/problem/16953
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
        public int maxValue;

        public int start;
        public int target;

        public int ret;

        public int[] maps;

        public void solve()
        {
            maxValue = (int)Math.Pow(10, 9);
            ret = Int32.MaxValue;

            string[] input = Console.ReadLine().Split(' ');

            start = Convert.ToInt32(input[0].ToString());
            target = Convert.ToInt32(input[1].ToString());

            maps = new int[target];

            BFS();
            Print();
        }

        public void BFS()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            maps[start] = 1;

            while (q.Count > 0)
            {
                var cur = q.Dequeue();

                if (cur == target)
                    break;

                if (cur > target)
                    continue;

                var calc1 = cur * 2;
                var calc2 = Int32.Parse(cur.ToString() + "1");

                if (calc1 <= target)
                {
                    q.Enqueue(calc1);
                    maps[calc1] = (int)(maps[cur] + 1);
                }

                if (calc2 <= target)
                {
                    q.Enqueue(calc2);
                    maps[calc2] = (int)(maps[cur] + 1);
                }
            }
        }

        public void Print()
        {
            ret = maps[target] == 0 ? -1 : maps[target];
            Console.WriteLine(ret);
        }
    }
}

