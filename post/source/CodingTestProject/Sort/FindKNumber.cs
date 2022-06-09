using System;
using System.IO;

namespace CodingTestProject.Sort
{
    /// <summary>
    /// 자바에서는 퀵정렬로 처리가 되지만 C#에서는 시간초과 발생
    /// 힙 정렬 또는 병합정렬을 사용해야 될 것으로 보임
    /// </summary>
    public class FindKNumber : IExecute
    {
        public void Execute()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var inputNums = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));
            var n = inputNums[0];
            var k = inputNums[1];

            var numArray = CommonUtil.GetIntArrayFromStringArray(sr.ReadLine().Split(' '));

            //퀵 정렬
            QuickSort(numArray, 0, numArray.Length - 1, k - 1);

            sw.WriteLine(numArray[k - 1]);

            sr.Dispose();
            sw.Dispose();
        }

        private void QuickSort(int[] array, int start, int end, int k)
        {
            if (start < end)
            {
                var pivot = Partition(array, start, end);

                //pivot와 k가 동일하다면 종료
                if (pivot == k)
                {
                    return;
                }
                //k보다 pivot이 작은 경우 pivot + 1 ~ end 정렬
                else if (pivot < k)
                {
                    //재귀 수행
                    QuickSort(array, pivot + 1, end, k);
                }
                //k보다 pivot이 큰 경우 start ~ pivot - 1 정렬
                else
                {
                    //재귀 수행
                    QuickSort(array, start, pivot - 1, k);
                }
            }
        }

        private int Partition(int[] array, int start, int end)
        {
            var center = (start + end) / 2;
            Swap(array, start, center);
            var pivot = array[start];
            var i = start;
            var j = end;

            while (i < j)
            {
                //피봇보다 end 인덱스 배열 값이 크다면 end 감소
                while (pivot < array[j])
                {
                    j--;
                }

                //i가 j보다 작고 피봇보다 start 인덱스 배열 값이 작다면 start 증가
                while (i < j && pivot >= array[i])
                {
                    i++;
                }

                Swap(array, i, j);
            }

            array[start] = array[i];
            array[i] = pivot;
            return i;
        }

        private static void Swap(int[] array, int indexA, int indexB)
        {
            var temp = array[indexB];
            array[indexB] = array[indexA];
            array[indexA] = temp;
        }
    }
}
