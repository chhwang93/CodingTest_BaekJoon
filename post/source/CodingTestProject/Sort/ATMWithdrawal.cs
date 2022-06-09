using System;
using System.Linq;

namespace CodingTestProject.Sort
{
    public class ATMWithdrawal : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            var timeArray = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));

            SortManager.InsertionSort(ref timeArray);

            var sum = 0;
            var totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += timeArray[i];

                totalSum += sum;
            }
            Console.WriteLine(totalSum);
        }
    }
}
