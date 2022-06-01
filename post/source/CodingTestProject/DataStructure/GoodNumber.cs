using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    public class GoodNumber : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<long>(Console.ReadLine());

            var inputArray = CommonUtil.GetLongArrayFromStringArray(Console.ReadLine().Split(' '));
            Array.Sort(inputArray);

            var count = 0;

            for (int i = 0; i < n; i++)
            {
                long find = inputArray[i];
                var startIndex = 0;
                var endIndex = n - 1;
                while (startIndex < endIndex)
                {
                    var sum = inputArray[startIndex] + inputArray[endIndex];
                    if (sum == find)
                    {
                        if (startIndex != i && endIndex != i)
                        {
                            count++;
                            break;
                        }
                        else if (startIndex == i)
                        {
                            startIndex++;
                        }
                        else if (endIndex == i)
                        {
                            endIndex--;
                        }
                    }
                    else if (sum < inputArray[i])
                    {
                        startIndex++;
                    }
                    else
                    {
                        endIndex--;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
