using System;
using System.Text;

namespace CodingTestProject.Sort
{
    public class NumberSort2 : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            var numArray = new int[n + 1];
            var tempArray = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                numArray[i] = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            }

            SortManager.MergeSort(numArray, tempArray, 1, n);

            var sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine(numArray[i].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
