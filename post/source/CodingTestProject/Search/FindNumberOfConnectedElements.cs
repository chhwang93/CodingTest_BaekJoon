using System;
using System.Collections.Generic;
using System.IO;

namespace CodingTestProject.Search
{
    public class FindNumberOfConnectedElements : IExecute
    {
        public void Execute()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));

            var n = inputNums[0];
            var m = inputNums[1];

            //방문 배열
            var visitArray = new bool[n];
            var arrayList = new List<List<int>>();

            //배열 리스트 초기화
            for(int i=0; i<n; i++)
            {
                arrayList.Add(new List<int>());
            }

            //인접 리스트 저장
            for(int i=0; i<m; i++)
            {
                inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));
                var u = inputNums[0]-1;
                var v = inputNums[1]-1;

                arrayList[u].Add(v);
                arrayList[v].Add(u);
            }

            var count = 0;
            for(int i=0; i<n; i++)
            {
                //방문 배열 확인
                if(!visitArray[i])
                {
                    count++;
                    DFS(arrayList, ref visitArray, i);
                }
            }

            sw.WriteLine(count);

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
            if(visit[v])
            {
                return;
            }

            //방문했다면 true 변경
            visit[v] = true;

            //노드 리스트를 돌면서 방문하지 않은 노드를 DFS 재귀 수행
            for(int i=0; i<arrayList[v].Count; i++)
            {
                //노드 연결된 값을 방문했는지 확인함
                if(visit[arrayList[v][i]] == false)
                {
                    DFS(arrayList, ref visit, arrayList[v][i]);
                }
            }
        }
    }
}
