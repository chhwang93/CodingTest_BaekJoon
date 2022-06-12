using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestProject.Search
{
    public class GetFrendship : IExecute
    {
        private bool arrive = false;

        public void Execute()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));
            var n = inputNums[0];
            var m = inputNums[1];
            var visitArray = new bool[n];
            var arrayList = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arrayList.Add(new List<int>());
            }

            for (int i = 0; i < m; i++)
            {
                inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));
                var a = inputNums[0];
                var b = inputNums[1];

                arrayList[a].Add(b);
                arrayList[b].Add(a);
            }

            for (int i = 0; i < n; i++)
            {
                var count = 1;
                if (!visitArray[i])
                {
                    DFS(arrayList, ref visitArray, i, count);

                    //완료되었으면 종료
                    if (arrive)
                    {
                        break;
                    }
                }
            }

            if (arrive)
            {
                sw.WriteLine(1);
            }
            else
            {
                sw.WriteLine(0);
            }

            sr.Dispose();
            sw.Dispose();
        }

        private void DFS(List<List<int>> array, ref bool[] visit, int index, int count)
        {
            //방문했거나 재귀 반복횟수가 5번이상인 경우 종료
            if (count == 5 || visit[index])
            {
                arrive = true;
                return;
            }

            visit[index] = true;

            for (int i = 0; i < array[index].Count; i++)
            {
                if (!visit[array[index][i]])
                {
                    DFS(array, ref visit, array[index][i], count + 1);
                }
            }

            //종료된 경우 방문 노드를 false 처리
            visit[index] = false;
        }
    }
}
