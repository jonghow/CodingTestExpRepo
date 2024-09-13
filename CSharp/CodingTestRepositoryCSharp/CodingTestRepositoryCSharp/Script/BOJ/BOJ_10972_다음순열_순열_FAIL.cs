using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
 * URL : https://www.acmicpc.net/submit/10972
 */

namespace CodingTestProj
{
    internal class Program
    {
        public static string input;
        public static int _standardIndex; // (n) < (n-1) 가 되는 기준

        static void Main(string[] args)
        {
            _standardIndex = -1;
            int cnt = Int32.Parse(Console.ReadLine());
            input = Console.ReadLine().Trim().Replace(" ", "");

            for (int i = input.Length - 1; i > 0; --i)
            {
                int n = Int32.Parse(input[i].ToString());
                int prevn = Int32.Parse(input[i - 1].ToString());

                if (n > prevn)
                {
                    _standardIndex = i - 1;
                    break;
                }
            }
            // 분리되는 기준점 찾기

            if (_standardIndex == -1)
            {
                Console.Write("-1");
                return;
            }
            // 못 찾았다면, -1 출력 및 종료

            string leftStr = input.Substring(0, _standardIndex + 1);
            string rightStr = input.Substring(_standardIndex + 1);

            // 찾았다면 왼쪽 오른쪽 영역 분리

            bool _isChange = false;

            for (int i = rightStr.Length - 1; i >= 0; --i)
            {
                for (int j = leftStr.Length - 1; j >= 0; --j)
                {
                    if (Convert.ToInt32(rightStr[i]) > Convert.ToInt32(leftStr[j]))
                    {
                        char[] rightArr = rightStr.ToCharArray();
                        char[] leftArr = leftStr.ToCharArray();

                        char temp = rightArr[i];
                        rightArr[i] = leftArr[j];
                        leftArr[j] = temp;

                        rightStr = new string(rightArr);
                        leftStr = new string(leftArr);
                        _isChange = true;
                        break;
                    }
                }

                if (_isChange == true)
                    break;
            }
            // 오른쪽 영역의 오른쪽 원소부터 왼쪽 영역의 오른쪽 원소부터 차례로 큰 부분을 찾는 로직

            char[] rightArr2 = rightStr.ToCharArray();
            Array.Sort(rightArr2);
            rightStr = new string(rightArr2);
            // 오른쪽 영역을 오름차순 정렬

            for (int i = 0; i < leftStr.Length; ++i)
            {
                Console.Write($"{Int32.Parse(leftStr[i].ToString())}");
                Console.Write($" ");
            }

            for (int i = 0; i < rightStr.Length; ++i)
            {
                Console.Write($"{Int32.Parse(rightStr[i].ToString())}");

                if (i != rightStr.Length - 1)
                    Console.Write($" ");
            }

            // 왼쪽 먼저 출력하고, 오른쪽 영역 차례로 출력.
        }
    }
}




