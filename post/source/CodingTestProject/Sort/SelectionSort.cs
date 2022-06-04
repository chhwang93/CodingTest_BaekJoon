using System;
using System.Text;

namespace CodingTestProject.Sort
{
    public class SelectionSort : IExecute
    {
        public void Execute()
        {
            var inputValue = Console.ReadLine();

            var numArray = new int[inputValue.Length];

            for(int i=0; i<inputValue.Length; i++)
            {
                numArray[i] = CommonUtil.GetConvertValue<int>(inputValue[i]) - '0';
            }

            SortManager.SelectionSort(ref numArray);

            var sb = new StringBuilder();
            for(int i=numArray.Length-1; i>=0; i--)
            {
                sb.Append(numArray[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
