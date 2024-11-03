//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Xml.Linq;
//using static CodingTestProj.Program;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();

//            List<int> score = new List<int>();
//            score.Add(8);
//            score.Add(21);
//            score.Add(8);
//            score.Add(15);
//            score.Add(5);
//            score.Add(30);
//            score.Add(21);

//            int _gCount = 2;
//            int k = 3;


//            ss.solve(score, _gCount, k);
//        }
//    }

//    public class Solution
//    {
//        public long _ret;
//        int _gCount;
//        int _k;

//        public List<int> _scoreList = new List<int>();
//        public List<int> _removeList = new List<int>();

//        public long solve(List<int> score, int guilder_count, int k)
//        {
//            _scoreList = score;
//            _ret = 0;
//            _scoreList = score;

//            _gCount = guilder_count;
//            _k = k;

//            List<Tuple<int, int>> leftGuilder = new List<Tuple<int, int>>();
//            List<Tuple<int, int>> rightGuilder = new List<Tuple<int, int>>();

//            List<Tuple<int, int>> wholeGuilder = new List<Tuple<int, int>>();

//            while (guilder_count > 0)
//            {
//                int guildCount = _scoreList.Count;

//                bool isOverGuildCount = guildCount > _k;
//                // 많으면 true;

//                if(isOverGuildCount == true)
//                {
//                    leftGuilder.Clear();
//                    rightGuilder.Clear();

//                    // 부분 인원으로
//                    int start = 0;
//                    int end = guildCount - 1;
//                    for (int i = 0; i < k; ++i)
//                    {
//                        leftGuilder.Add(new Tuple<int, int>(start, _scoreList[start]));
//                        rightGuilder.Add(new Tuple<int, int>(end, _scoreList[end]));

//                        ++start;
//                        --end;
//                    }

//                    leftGuilder.Sort((a, b) =>
//                    {
//                        return b.Item2.CompareTo(a.Item2);
//                    });

//                    rightGuilder.Sort((a, b) =>
//                    {
//                        return b.Item2.CompareTo(a.Item2);
//                    });

//                    var val1 = leftGuilder[0];
//                    var val2 = rightGuilder[0];

//                    if (val1.Item2 >= val2.Item2)
//                    {
//                        _scoreList.RemoveAt(val1.Item1);
//                        _removeList.Add(val1.Item2);
//                    }
//                    else
//                    {
//                        _scoreList.RemoveAt(val2.Item1);
//                        _removeList.Add(val2.Item2);
//                    }
//                }
//                else
//                {
//                    wholeGuilder.Clear();

//                    int findIndex = -1;
//                    int value = -9999;

//                    for (int i = 0; i < _scoreList.Count; ++i)
//                    {
//                        var val1 = _scoreList[i];
//                        if (val1 > value)
//                        {
//                            value = val1;
//                            findIndex = i;
//                        }
//                    }

//                    _scoreList.RemoveAt(findIndex);
//                    _removeList.Add(value);
//                }


//                --guilder_count;
//            }



//            for (int i = 0; i < _removeList.Count; ++i)
//                _ret += _removeList[i];

//            return _ret;
//        }
//        public void Print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}
