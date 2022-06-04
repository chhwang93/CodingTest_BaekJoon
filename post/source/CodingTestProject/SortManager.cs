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

        private static void Swap(ref int a, ref int b)
        {
            var temp = b;
            b = a;
            a = temp;
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
    }
}
