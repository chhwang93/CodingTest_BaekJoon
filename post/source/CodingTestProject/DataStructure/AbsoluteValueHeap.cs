using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestProject.DataStructure
{
    public class CompareItem : IComparable
    {
        public int Value { get; set; }

        public int CompareTo(object obj)
        {
            if (obj != null && obj is CompareItem otherCompareItem)
            {
                var absValue = Math.Abs(Value);
                var absOtherValue = Math.Abs(otherCompareItem.Value);

                if (absValue == absOtherValue)
                {
                    return absValue > absOtherValue ? otherCompareItem.Value : Value;
                }
                else
                {
                    return absValue - absOtherValue;
                }
            }
            else
            {
                return 0;
            }
        }
    }

    public class AbsoluteValueHeap : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());

            PriorityQueue<CompareItem> priorityQueue = new PriorityQueue<CompareItem>();
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var value = CommonUtil.GetConvertValue<int>(Console.ReadLine());

                if (value != 0)
                {
                    priorityQueue.Add(new CompareItem() { Value = value });
                }
                else
                {
                    if (priorityQueue.Count == 0)
                    {
                        sb.AppendLine("0");
                    }
                    else
                    {
                        sb.AppendLine(priorityQueue.Pop().Value.ToString());
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
