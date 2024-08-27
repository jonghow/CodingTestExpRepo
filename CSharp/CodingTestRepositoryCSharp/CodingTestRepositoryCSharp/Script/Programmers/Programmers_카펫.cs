using System;
using System.Collections.Generic;

/*
 * Difficulty : Middle
 * URL : https://school.programmers.co.kr/learn/courses/30/lessons/42842?language=csharp
 */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brown = 12;
            int yellow = 4;

            Solution s = new Solution();
            s.solution(brown, yellow);

        }
    }

 public class Solution
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[] { };

            List<int> list = make(yellow);

            if (yellow == 1)
            {
                int horizon = list[0] + 2;
                int vertical = list[0] + 2;

                answer = new int[2] { horizon, vertical };
                return answer;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = 0; j < list.Count; ++j)
                {
                    int horizon = list[i] >= list[j] ? list[i] : list[j];
                    int vertical = list[i] >= list[j] ? list[j] : list[i];

                    if (brown == (((horizon + 2) * 2) + (vertical * 2)))
                    {
                        if (horizon * vertical != yellow)
                            continue;

                        answer = new int[2] { horizon+2, vertical +2};
                        return answer;
                    }
                }
            }

            return answer;
        }

        public List<int> make(int a)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= a; ++i)
            {
                int div = a % i;

                if (div == 0)
                    list.Add(i);
            }

            return list;
        }
    }

}



