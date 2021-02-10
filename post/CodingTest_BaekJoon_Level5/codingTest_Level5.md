## 5단계 - 1차원 배열

### 10818번 문제 - 최소,최대

```
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question10818
    { 
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                if (num >= 1 && num <= 1000000)
                {
                    var inputArray = Console.ReadLine().Split(' ');

                    if (num == inputArray.Length)
                    {
                        var min = int.MaxValue;
                        var max = int.MinValue;

                        for (int i = 0; i < num; i++)
                        {
                            if (int.TryParse(inputArray[i], out int value))
                            {
                                if (value >= -1000000 && value <= 1000000)
                                {
                                    if (value < min)
                                    {
                                        min = value;
                                    }
                                    if (value > max)
                                    {
                                        max = value;
                                    }
                                }
                            }
                        }

                        sb.Append(min);
                        sb.Append(" ");
                        sb.Append(max);

                        Console.WriteLine(sb);
                    }
                }
            }
        }
    }
}
```

* 1차원 배열 관련 첫 번째 문제
* 첫 번째 입력에서 배열의 개수를 입력 받고 두 번째 입력에서 정수 배열을 입력 받는다.
* C#은 문자열을 입력으로 받기 때문에 입력된 개수와 입력된 정수 배열의 개수가 동일한 경우 처리하도록 코드를 작성하였다.
* 정수 배열이 나온 경우 for문을 돌면서 최소와 최대값을 구하고 출력하도록 한다.
* 시간은 420ms로 예외처리를 고려해 TryParse를 사용한게 속도가 느려진 것으로 보인다.
* 한 번에 통과
