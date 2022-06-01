using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{
    public class DNAPassword : IExecute
    {
        public void Execute()
        {
            var inputNums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            var inputValue = Console.ReadLine();

            var dicString = new Dictionary<string, int>();
            var inputLength = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));

            dicString.Add("A", inputLength[0]);
            dicString.Add("C", inputLength[1]);
            dicString.Add("G", inputLength[2]);
            dicString.Add("T", inputLength[3]);

            var count = 0;

            for(int i=0; i<inputNums[1]; i++)
            {
                
            }
        }
    }
}
