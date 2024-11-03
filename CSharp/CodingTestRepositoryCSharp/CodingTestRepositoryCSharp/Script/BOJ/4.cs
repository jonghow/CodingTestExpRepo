//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

///*
// * Difficulty : Middle
// * URL : https://www.acmicpc.net/problem/1213
//  * Time : 
// */

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();
//            ss.solve();
//        }
//    }

//    public class Solution
//    {
//        public string _ret;
//        public string _wrongRet;

//        public void solve()
//        {
//            _wrongRet = "I'm Sorry Hansoo";

//            Init();
//            string input = Console.ReadLine();
//            if(input.Length == 0)
//            {
//                _ret = _wrongRet;
//                Print();
//                return;
//            }

//            char[] chr = input.ToCharArray();

//            Array.Sort(chr);

//            string _newInput = new string(chr);
//            string _s1 = string.Empty;
//            string _s2 = string.Empty;
//            bool _isCenter = false;
//            List<char> _chr =  new List<char>();

//            //BBAACDAA
//            while (_newInput.Length > 0)
//            {
//                if(_newInput.Length % 2 == 0) // 짝수
//                {
//                    if (_newInput[0] != _newInput[1])
//                    { 
//                        // 짝수인데 다르면 실패
//                        _isCenter = false;
//                        _s1 = "";
//                        _s2 = "";
//                        break;
//                    }
//                }

//                if (_newInput.Length == 1)
//                {
//                    _isCenter = true;
//                    _chr.Add(_newInput[0]);
//                    _newInput = _newInput.Remove(0, 1);
//                    break;
//                }

//                if ((_newInput[0] != _newInput[1]) && _newInput.Length % 2 == 1)
//                {
//                    if( _isCenter == true) 
//                        break;

//                    _isCenter = true;
//                    _chr.Add(_newInput[0]);
//                    _newInput = _newInput.Remove(0, 1);
//                    continue;
//                }

//                char _a = _newInput[0];
//                _newInput = _newInput.Remove(0, 1);

//                char _b = _newInput[0];
//                _newInput = _newInput.Remove(0, 1);

//                _s1 += _a;
//                _s2 += _b;
//            }

//            if ((_s1 == "" && _s2 == "") == false && (_s1 == _s2))
//            {
//                char[] reverse_s2 = _s2.ToCharArray();
//                Array.Reverse(reverse_s2);
//                string _new_s2 = new string(reverse_s2);

//                if (_isCenter)
//                    _newInput = _chr[0].ToString();

//                _ret = _s1 + _newInput + _new_s2;
//            }
//            else if (_s1 == "" && _s2 == "" && _isCenter == true)
//            {
//                _newInput = chr[0].ToString();
//                _ret = _newInput;
//            }
//            else
//                _ret = _wrongRet;

//            Print();
//        }

//        public void Init()
//        {
//        }
//        public void Print()
//        {
//            Console.WriteLine(_ret);
//        }
//    }
//}
