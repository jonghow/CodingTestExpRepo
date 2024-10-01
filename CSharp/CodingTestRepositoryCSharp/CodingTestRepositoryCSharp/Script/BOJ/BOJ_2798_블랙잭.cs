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
 * Difficulty : Easy
 * URL : https://www.acmicpc.net/problem/2798
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
        public int n;
        public int m;

        public int balance;
        public int ret;

        public void solve()
        {
            ret = 0;
            balance = int.MaxValue;
            var input = Console.ReadLine().Split(' ');
            n = Int32.Parse(input[0]);
            m = Int32.Parse(input[1]);

            List<int> list = new List<int>();

            input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; ++i)
            {
                list.Add(Int32.Parse(input[i]));
            }

            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = i + 1; j < list.Count; ++j)
                {
                    for (int k = j + 1; k < list.Count; ++k)
                    {

                        var value1 = list[i];
                        var value2 = list[j];
                        var value3 = list[k];

                        var sum = value1 + value2 + value3;

                        if (sum > m) continue;

                        var checkRet = Math.Abs(sum - m);



                        if (checkRet < balance)
                        {
                            balance = checkRet;
                            ret = sum;
                        }

                        if (checkRet == 0)
                        {
                            ret = sum;
                            Console.WriteLine(ret);
                            return;
                        }
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}

