using System;
using System.Collections.Generic;

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

        #region 스테이블 삽입 정렬
        public static void InsertionSort<T>(IList<T> list, Comparison<T> comparison)
        {
            if(list==null)
            {
                throw new ArgumentNullException("List");
            }

            if(comparison==null)
            {
                throw new ArgumentNullException("Comparison");
            }

            var count = list.Count;

            for(int i=1; i<count; i++)
            {
                var value = list[i];

                int j = i - 1;

                for(; j>=0 && comparison(list[j], value) > 0; j--)
                {
                    list[j + 1] = list[j];
                }
                list[j + 1] = value;
            }
        }
#endregion
    }
}
