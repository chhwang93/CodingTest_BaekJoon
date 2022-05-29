using System;
using System.Collections.Generic;

namespace CodingTestProject
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FindTheSumOfRemainder remainder = new FindTheSumOfRemainder();
            remainder.Execute();
        }

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

                        for(int i=0; i<m; i++)
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

        public static class CommonUtil
        {
           
            public static long[] GetLongArrayFromStringArray(string[] input)
            {
                return Array.ConvertAll(input, long.Parse);
            }

            public static long[] GetPrefixSum(long[] array)
            {
                var result = new long[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = result[i] + array[i];
                }

                return result;
            }
        }
    }
}
