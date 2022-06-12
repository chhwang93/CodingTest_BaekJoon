using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodingTestProject.Search
{
    public class DFSAndBFS : IExecute
    {
        private StreamWriter sw = null;
        private StreamReader sr = null;
        private StringBuilder dfsSb = new StringBuilder();
        private StringBuilder bfsSb = new StringBuilder();

        public void Execute()
        {
            sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));
            var n = inputNums[0];
            var m = inputNums[1];
            var v = inputNums[2];

            var visitArray = new bool[n];
            var arrayList = new List<List<int>>();

            for(int i=0; i<n; i++)
            {
                arrayList.Add(new List<int>());
            }

            for(int i=0; i<m; i++)
            {
                inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));
                var s = inputNums[0] - 1;
                var e = inputNums[1] - 1;

                arrayList[s].Add(e);
                arrayList[e].Add(s);
            }

            //인접 리스트 정렬
            for(int i=0; i<n; i++)
            {
                arrayList[i].Sort();
            }

            DFS(arrayList, ref visitArray, v-1);
            visitArray = new bool[n];
            BFS(arrayList, ref visitArray, v - 1);

            sw.WriteLine(dfsSb.ToString());
            sw.WriteLine(bfsSb.ToString());

            sr.Dispose();
            sw.Dispose();
        }

        /// <summary>
        /// 깊이 우선 탐색
        /// </summary>
        /// <param name="arrayList">노드 리스트</param>
        /// <param name="visit">방문 배열</param>
        /// <param name="v">시작 인덱스</param>
        private void DFS(List<List<int>> arrayList, ref bool[] visit, int v)
        {
            //방문했으면 종료
            if (visit[v])
            {
                return;
            }

            //방문했다면 true 변경
            visit[v] = true;
            dfsSb.Append(v + 1 + " ");

            //노드 리스트를 돌면서 방문하지 않은 노드를 DFS 재귀 수행
            for (int i = 0; i < arrayList[v].Count; i++)
            {
                //노드 연결된 값을 방문했는지 확인함
                if (visit[arrayList[v][i]] == false)
                {
                    DFS(arrayList, ref visit, arrayList[v][i]);
                }
            }
        }

        private void BFS(List<List<int>> arraylist, ref bool[] visit, int v)
        {
            //큐를 활용해 노드 탐색
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(v);
            visit[v] = true;

            while (queue.Count > 0)
            {
                var value = queue.Dequeue();
                bfsSb.Append(value + 1 + " ");

                for(int i=0; i<arraylist[value].Count; i++)
                {
                    if (!visit[arraylist[value][i]])
                    {
                        visit[arraylist[value][i]] = true;
                        queue.Enqueue(arraylist[value][i]);
                    }
                }
            }
        }
    }
}
