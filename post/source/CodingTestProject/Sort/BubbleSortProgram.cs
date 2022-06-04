using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTestProject.Sort
{
    /// <summary>
    /// 정렬(Stable, Non_Stable 개념 이해)
    /// </summary>
    public class BubbleSortProgram : IExecute
    {
        public class Item : IComparable
        {
            public int Index { get; set; }
            public int Value { get; set; }

            public int CompareTo(object obj)
            {
                int result = 0;
                if (obj != null && obj is Item other)
                {
                    result = Value - other.Value;
                }

                return result;
            }
        }

        public void Execute()
        {
            var n = CommonUtil.GetConvertValue<int>(Console.ReadLine());

            var items = new List<Item>();

            for (int i = 0; i < n; i++)
            {
                items.Add(new Item() { Index = i, Value = CommonUtil.GetConvertValue<int>(Console.ReadLine()) });
            }

            //스테이블 정렬
            items = items.OrderBy(item => item).ToList();

            var maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var value = items[i].Index - i;

                if (maxValue < value)
                {
                    maxValue = value;
                }
            }

            Console.WriteLine(maxValue + 1);
        }
    }
}
