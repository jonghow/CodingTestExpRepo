using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
 * URL : https://www.acmicpc.net/problem/2231
  * Time : 미측정
 */


namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            int ret = 0;

            for (int i = input - 1; i > 0; --i)
            {
                int divSum = 0;
                for (int j = 0; j < i.ToString().Length; ++j)
                {
                    char ss = i.ToString()[j];
                    divSum += Int32.Parse(ss.ToString());
                }
                divSum += i;

                if (divSum == input)
                {
                    ret = i;
                }
            }
            Console.WriteLine(ret);
        }
    }
}

