using System;

namespace CodingTestProject.DataStructure
{
    public class FindTheSumOfRemainder
    {
        public void Execute()
        {
            var inputNums = CommonUtil.GetLongArrayFromStringArray(Console.ReadLine().Split(' '));

            if (inputNums.Length == 2)
            {
                var n = inputNums[0];//주어진 개수
                var m = inputNums[1];//나누는 수

                var inputValues = CommonUtil.GetLongArrayFromStringArray(Console.ReadLine().Split(' '));
                if (n == inputValues.Length)
                {
                    var prefixSum = CommonUtil.GetPrefixSum(inputValues);
                    long totalSum = 0;
                    var remainderArray = new long[m];

                    for (int i = 1; i < prefixSum.Length; i++)
                    {
                        var remainder = prefixSum[i] % m;
                        if (remainder == 0)
                        {
                            totalSum++;
                        }

                        remainderArray[remainder]++;
                    }

                    for (int i = 0; i < m; i++)
                    {
                        if (remainderArray[i] > 1)
                        {
                            totalSum += (remainderArray[i] * (remainderArray[i] - 1) / 2);
                        }
                    }

                    Console.WriteLine(totalSum);
                }
            }
        }
    }
}
