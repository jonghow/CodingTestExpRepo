using System;
using System.Collections.Generic;
using static CodingTestProj.Program;

/*
 * Difficulty : Easy ~ Middle
 * URL : https://www.acmicpc.net/problem/2635
  * Time : 27m
 */


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
        int input;

        List<int>[] list;

        List<int> ret = new List<int>();

        int count = 0;

        public void Solve()
        {
            input = Int32.Parse(Console.ReadLine());
            list = new List<int>[input + 1];

            for(int i = 0; i < input +1; ++i)
                list[i] = new List<int>();

            for(int i = 1; i <= input; ++i)
            {
                var retList = list[i];
                retList.Add(input);
                fibbo(input, i, ref retList);
            }

            print();
        }
        
        public int fibbo(int o, int n, ref List<int> list)
        {
            if (n < 0)
            {
                if(count < list.Count)
                {
                    count = list.Count;
                    ret = list;
                }
                return 0;
            }
            else
            {
                list.Add(n);
            }
            

            return fibbo(n, o - n, ref list);
        }

        public void print()
        {
            Console.WriteLine(ret.Count);

            for (int i = 0; i < ret.Count; ++i)
                Console.Write(ret[i]+" ");
        }
    }
}

