namespace CodingTestProject
{
    public static class SortManager
    {
        #region 버블 정렬
        /// <summary>
        /// 버블 정렬
        /// </summary>
        /// <param name="array">정수 배열</param>
        public static void BubbleSort(ref int[] array)
        {
            var count = array.Length - 1;
            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    var a = array[i];
                    var b = array[i + 1];

                    if (a > b)
                    {
                        Swap(ref a, ref b);
                        array[i] = a;
                        array[i + 1] = b;
                    }
                }
                count--;
            }
        }
        #endregion

        #region 선택 정렬
        public static void SelectionSort(ref int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                var minValue = int.MaxValue;
                var minIndex = 0;

                for(int j=i + 1; j<array.Length; j++)
                {
                    var value = array[j];
                    if(minValue > value)
                    {
                        minValue = value;
                        minIndex = j;
                    }
                }

                if (array[i] > minValue)
                {
                    var temp = array[i];
                    array[i] = minValue;
                    array[minIndex] = temp;
                }
            }
        }
        #endregion

        #region 삽입 정렬
        public static void InsertionSort(ref int[]  array)
        {
            if (array.Length > 0)
            {
                for(int i=1; i<array.Length; i++)
                {
                    var keyValue = array[i];
                    var prev = i - 1;
                    while(prev >= 0 && (array[prev] > keyValue))
                    {
                        array[prev+1] = array[prev];
                        prev--;
                    }

                    array[prev + 1] = keyValue;
                }
            }
        }
        #endregion

        #region 퀵 정렬
        public static void QuickSort(ref int[] array)
        {
            //if (array.Length > 1)
            //{
            //    //가장 오른쪽 값을 피봇으로 설정
            //    var pivotIndex = array.Length - 1;
            //    var pivot = array[pivotIndex];
            //    var start = 0;
            //    var end = array.Length - 2;

            //    while(start < end)
            //    {
            //        if(array[start] < pivot)
            //        {
            //            start++;
            //        }
            //        else if(array[end] > pivot)
            //        {
            //            end--;
            //        }
            //        else if(array[start] > pivot && array[end] < pivot)
            //        {
            //            Swap(ref array[start], ref array[end]);
            //            start++;
            //            end--;
            //        }
            //    }

            //    if(pivot > array[start])
            //    {
            //        Swap(array[pivotIndex], )
            //    }
            //    else
            //    {

            //    }
            //}
        }

        #endregion

        #region 병합 정렬
        public static void MergeSort(int[] array, int[] tempArray, int start, int end)
        {
            //시작점과 종료점이 1보다 낮은 경우 재귀 종료
            if(end - start < 1)
            {
                return;
            }

            //중간 인덱스 구하기
            var middle = start + (end - start) / 2;

            //안 나눠질 때까지 재귀 수행(분할)
            MergeSort(array, tempArray, start, middle);
            MergeSort(array, tempArray, middle + 1, end);

            for(int i=start; i<=end; i++)
            {
                tempArray[i] = array[i];
            }

            var k = start;
            var index1 = start;
            var index2 = middle + 1;

            while (index1 <= middle && index2 <= end)
            {
                //index2 값보다 index1 값이 큰 경우 임시 배열의 값을 정렬할 배열에 대입한다.
                if(tempArray[index1] > tempArray[index2])
                {
                    array[k] = tempArray[index2];
                    k++;
                    index2++;
                }
                //index1 값보다 index2 값이 크거나 같은 경우 임시 배열의 값을 정렬할 배열에 대입한다.
                else
                {
                    array[k] = tempArray[index1];
                    k++;
                    index1++;
                }
            }

            while(index1 <= middle)
            {
                array[k] = tempArray[index1];
                k++;
                index1++;
            }

            while(index2<=end)
            {
                array[k] = tempArray[index2];
                k++;
                index2++;
            }
        }
        #endregion

        #region Swap
        private static void Swap(ref int a, ref int b)
        {
            var temp = b;
            b = a;
            a = temp;
        }
        #endregion
    }
}
