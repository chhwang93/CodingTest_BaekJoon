using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.Sort
{
    public class BubbleSortProgram2 : IExecute
    {
        public void Execute()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var n = CommonUtil.GetConvertValue<long>(sr.ReadLine());
            var inputArray = CommonUtil.GetLongArrayFromStringArray(sr.ReadLine().Split(' '));

            var intArray = new long[n + 1];
            var tempArray = new long[n + 1];

            Array.Copy(inputArray, 0, intArray, 1, n);

            long totalCount = 0;
            SortManager.MergeSort(intArray, tempArray, 1, n, ref totalCount);

            sw.WriteLine(totalCount);

            sr.Dispose();
            sw.Dispose();
        }
    }
}
