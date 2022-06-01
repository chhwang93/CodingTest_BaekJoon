using System;

namespace CodingTestProject.DataStructure
{
    public class Jumong : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            var m = CommonUtil.GetConvertValue<int>(Console.ReadLine());

            var inputArray = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            Array.Sort(inputArray);
            var count = 0;
            var start = 0;
            var end = n - 1;

            while (start < end)
            {
                var sum = inputArray[start] + inputArray[end];

                if (sum < m)
                {
                    start++;
                }
                else if (sum > m)
                {
                    end--;
                }
                else if (sum == m)
                {
                    count++;
                    end--;
                }
            }

            Console.WriteLine(count);
        }
    }
}
