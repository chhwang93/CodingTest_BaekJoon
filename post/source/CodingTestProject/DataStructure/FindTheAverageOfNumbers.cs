using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    public class FindTheAverageOfNumbers
    {
        public void Execute()
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if(!string.IsNullOrEmpty(input1) && !string.IsNullOrEmpty(input2))
            {
                var input1Length = CommonUtil.GetConvertValue<long>(input1);
                var input2Result = CommonUtil.GetInputStrings(input2, ' ');
                
                if(input1Length == input2Result.Length)
                {
                    //최대값 구하기
                    

                    Console.WriteLine(GetTotalAverage(input2Result, input1Length));
                }
            }
        }

        private float GetTotalAverage(string[] input, long length)
        {
            float sum = 0;
            long max = long.MinValue;
            long[] array = CommonUtil.GetLongArrayFromStringArray(input);
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            sum = (float)((sum / max) * 100)/length;

            return sum;
        }
    }
}
