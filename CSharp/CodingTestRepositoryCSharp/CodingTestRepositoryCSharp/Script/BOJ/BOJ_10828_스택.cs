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
 * URL : https://www.acmicpc.net/submit/10828
 */


/*
 * 
 * 
14
push 1
push 2
top
size
empty
pop
pop
pop
size
empty
pop
push 3
empty
top
 * 
 * 
 */

namespace CodingTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = Int32.Parse(Console.ReadLine());
            var solutions = new Solution();
            solutions.Prog(loop);

            print.printRet();
        }
    }

    public static class print
    {
        public static List<int> _list = new List<int>();

        public static void printRet()
        {
            for (int i = 0; i < _list.Count; ++i)
                Console.Write(_list[i] + $"\n");
        }
    }

    public class Solution
    {
        const int _arrCount = 10000;
        public int[] _arr = new int[_arrCount];
        public int _count = 0;

        public void Prog(int loop)
        {
            for(int i = 0; i < loop; ++i)
            {
                string[] commandArr = Console.ReadLine().Split(' ');
                string command = commandArr[0];
                

                if (command.Equals("push"))
                {
                    int IntValue = Int32.Parse(commandArr[1]);
                    push(IntValue);
                }
                else if (command.Equals("top"))
                {
                    top();
                }
                else if (command.Equals("size"))
                {
                    size();
                }
                else if (command.Equals("empty"))
                {
                    empty();
                }
                else if (command.Equals("pop"))
                {
                    pop();
                }
                else { }
            }
        }

        private void push(int x)
        {
            for(int i = 1; i <= _count; ++i)
            {
                _arr[i] = _arr[i - 1];
            }// 밀기

            _arr[0] = x;
            _count++;
        }

        public void top()
        {
            if (_count == 0)
            {
                //print._list.Add(-1);
                Console.Write(-1 + $"\n");
            }
            else
            {
                //print._list.Add(_arr[0]);
                Console.Write(_arr[0] + $"\n");
            }
        }

        public void size()
        {
            //print._list.Add(_count);
            Console.Write(_count + $"\n");
        }

        public void empty()
        {
            if(_count == 0)
            {
                //print._list.Add(1);
                Console.Write(1 + $"\n");
            }
            else
            {
                //print._list.Add(0);
                Console.Write(0 + $"\n");
            }
        }

        public void pop()
        {
            if(_count == 0)
            {
                //print._list.Add(-1);
                Console.Write(-1 + $"\n");
            }
            else
            {
                var _popValue = _arr[0];
                _arr[0] = 0;

                for(int i = _count -1; i > 0; --i)
                {
                    _arr[i - 1] = _arr[i];
                    _arr[i] = 0;
                }// 당기기

                _count--;
                //print._list.Add(_popValue);
                Console.Write(_popValue + $"\n");
            }
        }
    }
}
