using System;
using System.Collections.Generic;

namespace CodingTestProject.Search
{
    public class MazeSearch : IExecute
    {
        private int n;
        private int m;

        public void Execute()
        {
            var inputNums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            n = inputNums[0];
            m = inputNums[1];

            var inputArray = new int[n, m];
            var visitArray = new bool[n, m];

            for(int i=0; i<n; i++)
            {
                var inputValue = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    inputArray[i, j] = inputValue[j] - '0';
                }
            }

            BFS(ref inputArray, ref visitArray, 0, 0);

            Console.WriteLine(inputArray[n-1, m-1]);
        }

        private void BFS(ref int[,] array, ref bool[,] visitArray, int i, int j)
        {
            Queue<int[]> queue = new Queue<int[]>();
            var dx = new int[4] { 0, 0, -1, 1 };
            var dy = new int[4] { -1, 1, 0, 0 };

            if (array[i, j] == 1 && !visitArray[i, j])
            {
                queue.Enqueue(new int[] { i, j });
            }

            while(queue.Count>0)
            {
                var dequeue = queue.Dequeue();
                var x = dequeue[0];
                var y = dequeue[1];

                visitArray[x, y] = true;

                for (int k=0; k<4; k++)
                {
                    var ax = x + dx[k];
                    var ay = y + dy[k];

                    if (ax >= 0 && ay >= 0 && ax < n && ay < m)
                    {
                        if(array[ax, ay] !=0 && !visitArray[ax, ay])
                        {
                            queue.Enqueue(new int[] { ax, ay });
                            array[ax, ay] = array[x,y]+1;
                            visitArray[ax, ay] = true;

                            if(ax == n-1 && ay == m-1)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
