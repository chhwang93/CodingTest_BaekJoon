using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestProject.DataStructure
{
    /// <summary>
    /// TODO: Deque 구현 후 알고리즘 구현 예정
    /// </summary>
    public class FindMinimum : IExecute
    {
        public class Node
        {
            public int Index { get; set; }
            public int Value { get; set; }

            public Node(int index, int value)
            {
                this.Index = index;
                this.Value = value;
            }
        }

        public void Execute()
        {
            var inputNums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            var n = inputNums[0];
            var l = inputNums[1];
            var inputValues = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            Queue<Node> queue = new Queue<Node>();
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var node = new Node(i + 1, inputValues[i]);
                queue.Enqueue(node);
                
                if(queue.Count==1)
                {
                    sb.Append(node.Value);
                }
            }
        }

    }
}
