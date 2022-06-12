using System;
using System.IO;

namespace CodingTestProject.Sort
{
    /// <summary>
    /// 기수정렬로 풀어야 되지만 문제 메모리 제한으로 인해 다르게 문제를 풀었음
    /// </summary>
    public class NumberSort3 : IExecute
    {
        public void Execute()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var n = CommonUtil.GetConvertValue<int>(sr.ReadLine());
            var intArray = new int[10001];
            
            for(int i =0; i<n; i++)
            {
                intArray[CommonUtil.GetConvertValue<int>(sr.ReadLine())]++;
            }

            for(int i=0; i<10001; i++)
            {
                for (int j = 0; j < intArray[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }

            sr.Dispose();
            sw.Dispose();
        }
    }
}
