using System;
using System.Collections.Generic;

/*
 * Difficulty : Easy
 * URL : https://school.programmers.co.kr/learn/courses/30/lessons/42840
 */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] answer = new int[5] { 1, 2, 3, 4, 5 };
            int[] answer = new int[5] { 1, 3, 2, 4, 2 };

            Solution s = new Solution();
            s.solution(answer);
        }
    }

    public class point
    {
        public int index;
        public int score;

        public point(int index, int score)
        {
            this.index = index;
            this.score = score;
        }
    }

    public class Solution
    {
        public int[] solution(int[] answers)
        {
            int[] answer = new int[] { };

            int[] fst = new int[5] { 1, 2, 3, 4, 5 };
            int[] snd = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] thd = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            point[] passCount = new point[3];
            passCount[0] = new point(1, 0);
            passCount[1] = new point(2, 0);
            passCount[2] = new point(3, 0);

            int[] idx = new int[3] { 0, 0, 0 };

            for (int i = 0; i < answers.Length; ++i)
            {
                if (fst[idx[0]] == answers[i])
                    ++passCount[0].score;

                if (snd[idx[1]] == answers[i])
                    ++passCount[1].score;

                if (thd[idx[2]] == answers[i])
                    ++passCount[2].score;

                for (int j = 0; j < idx.Length; ++j)
                {
                    ++idx[j];

                    if (j == 0 && fst.Length <= idx[j])
                    {
                        idx[j] = 0;
                    }

                    if (j == 1 && snd.Length <= idx[j])
                    {
                        idx[j] = 0;
                    }

                    if (j == 2 && thd.Length <= idx[j])
                    {
                        idx[j] = 0;
                    }
                }
            }

            Array.Sort(passCount, (point a, point b) => { return a.score.CompareTo(b.score); });

            int retScore = passCount[passCount.Length - 1].score;
            point[] retPt = Array.FindAll(passCount, rhs => rhs.score == retScore);

            Array.Sort(retPt, (point a, point b) => { return a.index.CompareTo(b.index); });

            answer = new int[retPt.Length];
            for (int i = 0; i < retPt.Length; ++i)
            {
                answer[i] = retPt[i].index;
            }

            return answer;
        }
    }

}



