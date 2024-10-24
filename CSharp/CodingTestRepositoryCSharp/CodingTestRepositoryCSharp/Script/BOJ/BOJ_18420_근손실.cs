using System;
using System.Collections;
using System.Collections.Generic;
using static CodingTestProj.Program;

/*sdsd
 * Difficulty : 
 * URL : https://www.acmicpc.net/problem/18429
  * Time : 
 */


//mobitel
namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ss = new Solution();
            ss.Solve();
        }
    }

    public class Solution
    {
        public int n;
        public int ret;

        public string target;

        public void Solve()
        {
            ret = 0;
            n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                string strN = i.ToString();

                while(true)
                {
                    if (strN.Contains("3") == false &&
                        strN.Contains("6") == false &&
                        strN.Contains("9") == false)
                        break;

                    if(strN.Contains("3") == true)
                    {
                        int index = strN.IndexOf("3");
                        strN = strN.Remove(index, 1);
                        ++ret;
                        continue;
                    }

                    if (strN.Contains("6") == true)
                    {
                        int index = strN.IndexOf("6");
                        strN = strN.Remove(index, 1);
                        ++ret;
                        continue;
                    }

                    if (strN.Contains("9") == true)
                    {
                        int index = strN.IndexOf("9");
                        strN = strN.Remove(index, 1);
                        ++ret;
                        continue;
                    }
                }
            }

            print();
        }

        public void print()
        {
            Console.WriteLine(ret);
        }
    }
}