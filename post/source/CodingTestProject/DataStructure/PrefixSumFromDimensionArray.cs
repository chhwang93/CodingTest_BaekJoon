using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    public class PrefixSumFromDimensionArray : IExecute
    {
        public void Execute()
        {
            //첫 째줄 입력
            var inputNums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));

            if (inputNums.Length == 2)
            {
                var n = inputNums[0];
                var m = inputNums[1];
                int[,] dimentionArray = new int[n+1,n+1];

                //행렬 할당
                for (int i = 1; i <= n; i++)
                {
                    var lineValues = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
                    for (int j = 1; j <= n; j++)
                    {
                        dimentionArray[i, j] = lineValues[j-1];
                    }
                }

                var prefixSum = CommonUtil.GetPrefixSumFromMatrix(dimentionArray, n, n);
                var sb = new StringBuilder();

                //합 질의
                for(int i=0; i<m; i++)
                {
                    var lineValues = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
                    if (lineValues.Length == 4)
                    {
                        var x1 = lineValues[0];
                        var y1 = lineValues[1];
                        var x2 = lineValues[2];
                        var y2 = lineValues[3];

                        sb.Append(prefixSum[x2,y2] - prefixSum[x1 - 1, y2] - prefixSum[x2, y1-1] + prefixSum[x1- 1, y1-1]);
                        sb.AppendLine();
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
