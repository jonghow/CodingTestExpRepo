//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static CodingTestProj.Program;

//namespace CodingTestProj
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var ss = new Solution();
//            List<int> input = new List<int>();
//            //input.Add(8);
//            //input.Add(1);
//            //input.Add(4);
//            //input.Add(7);

//            input.Add(4);
//            input.Add(13);
//            input.Add(10);
//            input.Add(21);
//            input.Add(20);

//            ss.solve(input);
//        }
//    }

//    public class Solution
//    {
//        public int _ret;

//        public int _left;
//        public int _right;

//        public void solve(List<int> arr)
//        {
//            Init();

//            _ret = 0;
//            _left = 0;
//            _right = arr.Count - 1;

//            while (_left < _right)
//            {
//                var _val1 = arr[_left];
//                var _val2 = arr[_right];

//                while (_left < _right && _val1 % 2 == 0)
//                {
//                    ++_left;
//                    _val1 = arr[_left];
//                }
//                // 짝수 찾기 

//                while (_left < _right && _val2 % 2 == 1)
//                {
//                    --_right;
//                    _val2 = arr[_right];
//                }
//                // 홀수 찾기

//                if(_left < _right)
//                    Swap(ref arr, _left, _right);
//            }
//        }

//        public void Swap(ref List<int> _arr,int _left, int _right)
//        {
//            int temp = _arr[_left];
//            _arr[_left] = _arr[_right];
//            _arr[_right] = temp;

//            ++_ret;
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
