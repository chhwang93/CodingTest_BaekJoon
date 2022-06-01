using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    public class FindTheSumOfNumbers5 : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());

            //연속된 배열 할당
            var numArray = new int[n];
            for (int i = 1; i <= n; i++)
            {
                numArray[i - 1] = i;
            }

            //시작점, 종료점
            var startIndex = 1;
            var endIndex = 1;
            var count = 1;
            var sum = 1;

            while (endIndex != n)
            {
                if (sum == n)
                {
                    count++;
                    endIndex++;
                    sum += endIndex;
                }
                else if (sum > n)
                {
                    sum -= startIndex;
                    startIndex++;
                }
                else
                {
                    endIndex++;
                    sum += endIndex;
                }
            }

            Console.WriteLine(count);
        }
    }
}
