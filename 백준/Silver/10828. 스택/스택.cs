using System;
using System.Collections.Generic;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack
            int orders = int.Parse(Console.ReadLine());

            List<int> stack = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i<orders; i++)
            {
                string[] orderArr = Console.ReadLine().Split(' ');
                switch (orderArr[0])
                {
                    case "push":
                        push(int.Parse(orderArr[1]));
                        break;
                    case "pop":
                        sb.AppendLine(pop().ToString());
                        break;
                    case "top":
                        sb.AppendLine(top().ToString());                        
                        break;
                    case "size":
                        sb.AppendLine(size().ToString());
                        break;
                    case "empty":
                        sb.AppendLine(empty().ToString());
                        break;

                }
            }
            Console.Write(sb);

            void push(int num)
            {
                stack.Add(0);
                for (int i = stack.Count -1; i>0; i--)
                {
                    stack[i] = stack[i - 1];
                }
                stack[0] = num;
            }

            int top()
            {
                if (stack.Count > 0) return stack[0];
                return -1;
            }

            int size()
            {
                return stack.Count;
            }

            int pop()
            {
                if (stack.Count == 0) return -1;

                int output = stack[0];

                for(int i = 1; i<stack.Count; i++)
                {
                    stack[i - 1] = stack[i];
                }
                stack.RemoveAt(stack.Count - 1);
                return output;
            }

            int empty()
            {
                if (stack.Count > 0) return 0;
                return 1;
            }
        }
    }
}