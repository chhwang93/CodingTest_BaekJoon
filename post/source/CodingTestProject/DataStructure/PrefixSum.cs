using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    public class PrefixSum : IExecute
    {
        public void Execute()
        {
            var nums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            var inputArray = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            var prefixSum = CommonUtil.GetPrefixSum(inputArray);

            if (nums.Length==2 && nums[0] == inputArray.Length)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < nums[1]; i++)
                {
                    var inputNums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));

                    if(inputNums.Length == 2)
                    {
                        sb.Append(prefixSum[inputNums[1]] - prefixSum[inputNums[0] - 1]);
                        sb.AppendLine();
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
