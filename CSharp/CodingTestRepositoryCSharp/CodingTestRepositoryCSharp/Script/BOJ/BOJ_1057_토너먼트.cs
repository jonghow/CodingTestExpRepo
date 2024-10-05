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
 * URL : https://www.acmicpc.net/problem/1057
 * Time : 59m 17s
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
        int people;
        decimal n;
        decimal m;

        decimal nRound;

        public void solve()
        {
            nRound = 1;
            string[] input = Console.ReadLine().Split(' ');

            people = Int32.Parse(input[0]);
            n = decimal.Parse(input[1]);
            m = decimal.Parse(input[2]);

            if(m % 2 == 0 && m -1 == n)
            {
                Console.WriteLine(1);
                return;
            }

            finder(n,m, nRound);

            Console.WriteLine(nRound);
        }

        public void finder(decimal var1 ,decimal var2, decimal round)
        {
            if (nRound > ((people / 2) + 10))
                return;

            if (var1 % 2 == 1 && var2 == var1 +1)
            {
                nRound = round;
                return;
            }

            if (var2 % 2 == 1 && var1 == var2 + 1)
            {
                nRound = round;
                return;
            }

            var var1next = (var1 % 2 == 1) && (var1 != 1) ? var1 + 1 : var1;
            var var2next = (var2 % 2 == 1) && (var2 != 1) ? var2 + 1 : var2;

            var var1Div = (var1 == 1) ? 1 : var1next / 2;
            var var2Div = (var2 == 1) ? 1 : var2next / 2;

            finder(var1Div, var2Div, ++round);
        }
    }
}

