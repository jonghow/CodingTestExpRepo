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
 * Difficulty : Easy
 * URL : https://www.acmicpc.net/submit/1427
 */


namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Case 0 _ Short
            char[] convertC = Console.ReadLine().ToCharArray();
            Array.Sort(convertC, (x, y) => { return y.CompareTo(x); });
            Console.WriteLine(convertC);

            //Case 1
            //string input = Console.ReadLine();
            //char[] convertC = input.ToCharArray();
            //Array.Sort(convertC,(x,y) => { return y.CompareTo(x); });
            //Console.WriteLine(convertC);

            //Case2
            //string input = Console.ReadLine();
            //char[] convertC = input.ToCharArray();
            //var revertC = convertC.Reverse();
            //foreach(var element in revertC)
            //{
            //    Console.Write(element);
            //}
        }
    }
}
