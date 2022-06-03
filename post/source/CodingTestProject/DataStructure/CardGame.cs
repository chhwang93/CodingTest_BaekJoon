using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.DataStructure
{

    public class CardGame : IExecute
    {
        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            //q에 할당
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(i + 1);
            }

            while (queue.Count > 1)
            {
                queue.Dequeue();
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(queue.Dequeue());
        }
    }
}
