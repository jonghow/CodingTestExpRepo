//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Diagnostics.SymbolStore;
//using System.IO;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography;
//using System.Text;

//namespace Solution
//{
//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            CharGroup.setChar();
//            List<string> _candidate = Candidate.makeCandidate();

//            int guessCount = Int32.Parse(Console.ReadLine());

//            while (guessCount > 0 && _candidate.Count > 1)
//            {
//                string[] lines = Console.ReadLine().Split(' ');
//                string guess = lines[0];
//                int strike = Int32.Parse(lines[1]);
//                int ball = Int32.Parse(lines[2]);

//                // 현재 스트라이크와 볼 값을 포함한 Tuple
//                var hint = Tuple.Create(strike, ball);

//                _candidate.RemoveAll(candidate =>
//                {
//                    var result = BBGGenerator.Generate(candidate, guess);
//                    return !result.Equals(hint);
//                });

//                --guessCount;
//            }

//            if (_candidate.Count == 1)
//            {
//                Console.WriteLine(_candidate[0]);
//            }
//            else
//            {
//                Console.WriteLine('x');
//            }
//        }
//    }

//    static class CharGroup
//    {
//        public static char[] _charGroup1;
//        public static char[] _charGroup2;

//        public static int _candidateCount;

//        public static void setChar()
//        {
//            _charGroup1 = new char[8]{ 'b', 'd', 'g', 'n', 'p', 'r', 's', 't' };
//            _charGroup2 = new char[5] { 'a', 'e', 'i', 'o', 'u' };

//            _candidateCount = _charGroup1.Length * _charGroup2.Length * _charGroup1.Length * _charGroup2.Length;
//        }
//    }
//    static class Candidate
//    {
//        public static List<string> makeCandidate()
//        {
//            List<string> ret = new List<string>();

//            StringBuilder sb = new StringBuilder();

//            for(int i = 0; i < CharGroup._charGroup1.Length; i++)
//            {
//                for (int j = 0; j < CharGroup._charGroup2.Length; j++)
//                {
//                    for (int k = 0; k < CharGroup._charGroup1.Length; k++)
//                    {
//                        if (CharGroup._charGroup1[i] == CharGroup._charGroup1[k]) continue;

//                        for (int m = 0; m < CharGroup._charGroup2.Length; m++)
//                        {
//                            if (CharGroup._charGroup2[j] == CharGroup._charGroup2[m]) continue;

//                            sb.Clear();
//                            sb.Append(CharGroup._charGroup1[i]);
//                            sb.Append(CharGroup._charGroup2[j]);
//                            sb.Append(CharGroup._charGroup1[k]);
//                            sb.Append(CharGroup._charGroup2[m]);

//                            ret.Add(sb.ToString());
//                        }
//                    }
//                }
//            }

//            return ret;
//        }
//    }
//    static class BBGGenerator
//    {
//        public static Tuple<int, int> Generate(string candidate, string guess)
//        {
//            int strikes = 0, balls = 0;
//            char[] candidateChrArr = candidate.ToCharArray();
//            char[] guessChrArr = guess.ToCharArray();

//            // 1. 스트라이크 계산
//            for (int i = 0; i < guess.Length; ++i)
//            {
//                if (candidateChrArr[i] == guessChrArr[i])
//                {
//                    strikes++;
//                    candidateChrArr[i] = '-'; // Mark as used
//                    guessChrArr[i] = '-';
//                }
//            }

//            // 2. 볼 계산
//            for (int i = 0; i < guessChrArr.Length; ++i)
//            {
//                if (guessChrArr[i] == '-') continue;

//                for (int j = 0; j < candidateChrArr.Length; ++j)
//                {
//                    if (candidateChrArr[j] == '-') continue;

//                    if (guessChrArr[i] == candidateChrArr[j])
//                    {
//                        balls++;
//                        candidateChrArr[j] = '-'; // Mark as used
//                        break;
//                    }
//                }
//            }
//            return new Tuple<int, int>(strikes, balls);
//        }
//    }
//}


