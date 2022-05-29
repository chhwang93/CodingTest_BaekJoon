## 8단계 - 기본 수학 1

### 1712번 문제 - 손익분기점

![image](https://user-images.githubusercontent.com/76270432/110226381-fa09bf80-7f31-11eb-9e1d-8b3420c68e85.png)



![image](https://user-images.githubusercontent.com/76270432/110226390-0e4dbc80-7f32-11eb-8048-c4c8878d3a8c.png)

---

* A - 고정 비용, B- 재료비&인건비, C-노트북 가격
* 손익분기점을 넘기는 시점의 노트북 총 판매량을 출력함 
  * A+Bx 총판매량= Cx총판매량이 동일한 경우 손익분기점을 넘겼다고 할 수 없고 Cx총 판매량이 손익분기점을 넘겨야 한다.

* A,B,C는 21억 이하의 자연수이다.

#### 첫 번째 성공한 코드

```c#
using System;

namespace BaekJoon
{
    internal class Question1712
    {
        public static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ');

            if (inputArray.Length == 3)
            {
                var fixedCost = int.Parse(inputArray[0]);
                var variableCost = int.Parse(inputArray[1]);
                var salePrice = int.Parse(inputArray[2]);

                Console.WriteLine(CalculateBreakEvenPoint((ulong)fixedCost, (ulong)variableCost, (ulong)salePrice));
            }
        }

        /// <summary>
        /// 손익분기점을 계산한다.
        /// </summary>
        /// <param name="fixedCost">고정 비용</param>
        /// <param name="variableCost">가변 비용</param>
        /// <param name="salesCost">판매 가격</param>
        /// <returns>손익분기점이 될 판매 개수를 반환한다.</returns>
        public static int CalculateBreakEvenPoint(ulong fixedCost, ulong variableCost, ulong salePrice)
        {
            int totalNum = 0;

            //가변비용이 판매 가격보다 높은 경우 손익분기점을 만들 수 없기 때문에
            //-1을 리턴한다.
            if(variableCost >= salePrice)
            {
                return -1;
            }

            //손익분기점을 계산한다.
            while(true)
            {
                if((fixedCost + variableCost * (ulong)totalNum) >= (salePrice * (ulong)totalNum))
                {
                    totalNum++;
                }
                else
                {
                    break;
                }
            }

            return totalNum;
        }
    }
}
```

* 4번의 시도 끝에 첫 번째로 성공한 코드

* 손익분기점 계산하는 방식은 맞았지만 판매 개수에 판매가격이나 가변 금액을 곱했을 때 입력값을 21억이라고할 경우 **int의 자료형의 최대 크기를 넘어가기 때문에** ulong으로 작성하여 최대크기가 넘어가지 않도록 작성함

* 속도는 1504ms로 1등의 88ms와 한참 차이가 났다.

  * 무슨 문제가 있을까?라고 생각하고 아래에 개선한 코드가 있음

  

#### 개선한 코드

```c#
using System;

namespace BaekJoon
{
    internal class Question1712
    {
        public static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ');

            if (inputArray.Length == 3)
            {
                var fixedCost = int.Parse(inputArray[0]);
                var variableCost = int.Parse(inputArray[1]);
                var salePrice = int.Parse(inputArray[2]);

                	Console.WriteLine(CalculateBreakEvenPoint(fixedCost,variableCost,salePrice));
            }
        }

        /// <summary>
        /// 손익분기점을 계산한다.
        /// </summary>
        /// <param name="fixedCost">고정 비용</param>
        /// <param name="variableCost">가변 비용</param>
        /// <param name="salesCost">판매 가격</param>
        /// <returns>손익분기점이 될 판매 개수를 반환한다.</returns>
        public static int CalculateBreakEvenPoint(int fixedCost, int variableCost, int salePrice)
        {
            //가변비용이 판매 가격보다 높은 경우 손익분기점을 만들 수 없기 때문에
            //-1을 리턴한다.
            if(variableCost >= salePrice)
            {
                return -1;
            }

            return (fixedCost / (salePrice - variableCost) + 1);
        }
    }
}
```

* 중요한 점을 먼저 말하자면 굳이 개수를 구하기 위해 **while문을 돌릴 필요가 없다.**
* 고정 비용에서 (가변비용 - 판매 비용)을 나눴을 때의 몫의 값이 나오고 1을 더해주면 손익분기점이 나오는 판매 개수가 나오게 된다.
  * 따라서 위의 함수 코드에서 속도를 **96ms**까지 줄일 수 있었고 자료형도 ulong -> int로 변환하여 처리한 결과 **92ms로 1등과 4ms**차이가 날정도로 줄였다.