using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestProject.DataStructure
{
    public class StackSort : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            var sb = new StringBuilder();
            var count = 0;
            var compareValue = 0;
            bool isRepeat = true;

            for (int i=0; i<n; i++)
            {
                var inputValue = CommonUtil.GetConvertValue<int>(Console.ReadLine());

                if (isRepeat)
                {
                    while (compareValue != inputValue)
                    {
                        if (stack.Count > 0 && stack.Peek() == inputValue)
                        {
                            compareValue = stack.Pop();
                        }

                        if (compareValue < inputValue)
                        {
                            count++;
                            stack.Push(count);
                            sb.AppendLine("+");
                        }
                        else if (compareValue == inputValue)
                        {
                            sb.AppendLine("-");
                        }
                        else if (compareValue > inputValue)
                        {
                            sb.Clear();
                            sb.AppendLine("NO");
                            isRepeat = false;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
