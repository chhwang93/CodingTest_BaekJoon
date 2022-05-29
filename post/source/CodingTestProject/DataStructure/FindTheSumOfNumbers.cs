using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    /// <summary>
    /// 숫자의 합 구하기
    /// </summary>
    public class FindTheSumOfNumbers
    {
        public void Execute()
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if (CommonUtil.GetConvertValue<long>(input1) == input2.Length)
            {
                Console.WriteLine(CommonUtil.FindSumOfLong(input2));
            }
        }
    }
}
