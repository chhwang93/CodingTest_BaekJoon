using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.Sort
{
    public class NumberSort : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            var numArray = new int[n];

            for(int i=0; i<n; i++)
            {
                numArray[i] = CommonUtil.GetConvertValue<int>(Console.ReadLine());
            }

            SortManager.BubbleSort(ref numArray);

            for(int i=0; i<n; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
