## 6단계 - 함수

### 4673번 문제 - 셀프 넘버

```
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question4673
    {
        public static int AddNumberOfDigit(int num)
        {
            var result = num;

            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            var count = 10000;
            var sb = new StringBuilder();
            var boolArray = new bool[count];

            for (int i = 1; i <= count; i++)
            {
                var result = AddNumberOfDigit(i);

                if(result-1 < count)
                {
                    boolArray[result-1] = true;
                }
            }

            for(int i=0; i< count; i++)
            {
                if(!boolArray[i])
                {
                    sb.Append(i + 1);
                    sb.AppendLine();
                }    
            }

            Console.WriteLine(sb);
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/107873725-d7b6f000-6ef7-11eb-9666-3bd24c5350f5.png)

------

* 문제는 입력값과 각 자리수를 더하는 함수가 있고 이를 통해 결과값이 나오게 되는데 위의 함수를 통해서 생성할 수 없은 생성자가 없는 함수를 셀프 넘버라고 하며 셀프 넘버를 출력하는 문제이다.

* 함수 문제이기 때문에 문제의 각 자리수를 더하는 함수인 AddNumberOfDigit 함수를 작성하였고 생성자가 존재하는 결과값을 반환하고 생성자가 있는 경우에는 해당 결과값의 인덱스를 true로 변경하였다.

  * 그 후 for문을 돌면서 booArray에서 false인 값을 찾으면 이는 셀프 넘버가 될 것이다.

* 시간은 처음 작성했을 때 162ms가 나왔으며 시간이 오래 걸리는 코드를 계속해서 수정하여 80ms로 줄였다.

  * 처음으로 코딩테스트 시간 1등을 하였다.

  ![image](https://user-images.githubusercontent.com/76270432/107873896-21540a80-6ef9-11eb-8b0f-86dc9cbee562.png)



### 1065번 문제 - 한수

```
using System;
using System.Collections.Generic;

namespace BaekJoon
{
    internal class Question1065
    {
        public static bool GetHansoo(int num)
        {
            var digitNumbers = new List<int>();

            while (num > 0)
            {
                digitNumbers.Add(num % 10);
                num /= 10;
            }
            var count = digitNumbers.Count;

            if (num < 3)
            {
                return true;
            }
            else
            {
                var diff = digitNumbers[1] - digitNumbers[0];

                for (int i = 1; i < count - 1; i++)
                {
                    if (diff != digitNumbers[i + 1] - digitNumbers[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                var total = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (GetHansoo(i))
                    {
                        total++;
                    }
                }

                Console.WriteLine(total);
            }
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/107873961-98899e80-6ef9-11eb-968b-f96817ce0ac4.png)

---

* 정수 X의 각 자리 수가 등차수열을 이루는 수를 한수라고 하며 한수의 개수를 구하는 문제
* 1~99까지는 한수이기 때문에 GetHansoo 함수에서 true로 반환하도록 함
* 100이상의 값은 각 자리수를 비교하여 등차수열인 경우에만 true를 반환하고 하나라도 두 수의 차이가 일정하지 않다면 false로 반환한다.
* 한수인 경우에만 total 값을 증가시킨다.
* 시간은 92ms가 걸렸으며 1등과의 차이는 4ms 차이가 났음
* 한 번에 통과