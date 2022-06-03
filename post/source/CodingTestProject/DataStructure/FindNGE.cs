using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestProject.DataStructure
{
    //이진트리 탐색으로 바꿔서 해볼 것
    //시간 초과 발생함
    public class FindNGE : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());

            var inputValues = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            var stack = new Stack<int>();
            var sb = new StringBuilder();
            var result = new int[n];
            stack.Push(0);

            for (int i = 1; i < n; i++)
            {
                var value = inputValues[i];

                while (stack.Count > 0 && inputValues[stack.Peek()] < value)
                {
                    var index = stack.Pop();
                    result[index] = value;
                }

                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                var index = stack.Pop();
                result[index] = -1;
            }

            for (int i = 0; i < n; i++)
            {
                var value = i != n - 1 ? $"{result[i]} " : result[i].ToString();
                Console.Write(value);
            }

            Console.WriteLine();
        }
    }
}
