using System;
using System.IO;

namespace CodingTestProject.Search
{
    public class FindOddPrimeNumbers : IExecute
    {
        protected StreamReader sr;
        protected StreamWriter sw;

        public void Execute()
        {
            sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var n = CommonUtil.GetConvertValue<int>(sr.ReadLine());

            DFS(2, 1, n);
            DFS(3, 1, n);
            DFS(5, 1, n);
            DFS(7, 1, n);

            sr.Dispose();
            sw.Dispose();
        }

        /// <summary>
        /// 깊이우선탐색
        /// </summary>
        /// <param name="value">숫자</param>
        /// <param name="digit">변경될 자리수 값</param>
        /// <param name="n">자리수 값</param>
        private void DFS(int value, int digit, int n)
        {
            //자리수가 정한 자리수와 동일하고 소수인 경우 소수 출력
            if(digit == n)
            {
                if(CommonUtil.CheckIsPrimeNumber(value))
                {
                    sw.WriteLine(value);
                }
                return;
            }

            for(int i=0; i<10; i++)
            {
                //짝수인 경우 제외
                if (i % 2 == 0)
                    continue;

                if(CommonUtil.CheckIsPrimeNumber(value * 10 + i))
                {
                    DFS(value * 10 + i, digit+1, n);
                }
            }
        }
    }
}
