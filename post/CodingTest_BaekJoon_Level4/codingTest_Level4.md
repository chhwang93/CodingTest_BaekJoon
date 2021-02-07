## 4단계 - while문

### 10952번 문제 - A+B - 5

``` markdown
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question10952
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var a = -1;
            var b = -1;

            while(a!=0 || b!=0)
            {
                var input = Console.ReadLine().Split();

                if (input.Length == 2)
                {
                    if (int.TryParse(input[0], out a) && int.TryParse(input[1], out b))
                    {
                        if ((a > 0 && a < 10) && (b > 0 && b < 10))
                        {
                            if (a != 0 || b != 0)
                            {
                                sb.Append(a + b);
                                sb.AppendLine();
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
```

* while문을 이용한 A+B 첫 번째 문제
* while문은 반복할 조건만 잘 정해주면 for문과 동일하게 사용이 가능하다.
  * 따라서 조건을 a=0, b=0일 때 종료하도록 하고 종료 시 StringBuilder에 추가한 문자열을 출력하면 된다.
* 한 번에 통과

### 10951번 문제 -  A + B - 4

```markdown
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question10951
    {
        static void Main(string[] args)
        {
            try
            {
                var sb = new StringBuilder();

                while (true)
                {
                    var result = Console.ReadLine();
                    if (!string.IsNullOrEmpty(result))
                    {
                        var input = result.Split();

                        if (input.Length == 2)
                        {
                            if (int.TryParse(input[0], out int a) && 			int.TryParse(input[1], out int b))
                            {
                                if ((a > 0 && a < 10) && (b > 0 && b < 10))
                                {
                                    sb.Append(a + b);
                                    sb.AppendLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine(sb);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
```

* EOF(End of File) 관련 문제, 입력이 종료되는 시점을 확인해서 종료 후 문자열을 출력하는 방식

* 처음에는 EOF관련이라 파일을 읽어 종료시점을 확인해야 하나 했으나 입력값이 없을 경우 종료하면 되는 것으로 보임

* 처음 코드를 작성하여 제출했을 때 런타임 에러가 났었는데 무슨 문제인지 확인한 결과 Console.ReadLine()의 입력 값이 null일 때 Split을 하면 오류가 발생하는 것을 확인했고 이를 String.IsNullOrEmpty로 검사하여 유효한 경우에만 Split()를 호출하도록 하여 해결하였다.

  

### 1110번 문제 - 더하기 사이클

```
using System;

namespace BaekJoon
{
    internal class Question1110
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(int.TryParse(input, out int num))
            {
                if(num >= 0 && num<=99)
                {
                    var returnNum = -1;
                    var count = 0;

                    while (num != returnNum)
                    {
                        //시작 시 returnNum의 값은 num을 받는다.
                        if(count==0)
                        {
                            returnNum = num;
                        }

                        int first;
                        int second;

                        //값이 10보다 작은 경우 앞자리에 0을 추가한다.
                        if (returnNum < 0)
                        {
                            first = 0;
                            second = returnNum;
                        }
                        else
                        {
                            first = returnNum / 10;
                            second = returnNum % 10;
                        }

                        //결과값의 일의 자리 수
                        var result = (first + second) % 10;

                        //기존 일의 자리 수의 10의 곱과 결과값의 일의 자리 수를 더한다.
                        returnNum = second * 10 + result;
                        count++;
                    }
                    Console.WriteLine(count);
                } 
            }
        }
    }
}
```

* 문제 자체는 읽어보면 단순한 두 자리수 더하기를 반복하여 주어진 값과 더한 값이 동일할 경우 종료하면서 반복한 횟수가 출력되는 문제이다.
* 코드 내용이 길어져서 복잡해보이지만 규칙만 알면 간단한 문제인 것으로 보임



#### 코드 길이를 줄인 버전

------



```
using System;

namespace BaekJoon
{
    internal class Question1110
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(int.TryParse(input, out int num))
            {
                if(num >= 0 && num<=99)
                {
                    var count = 0;
                    var compareNum = num;

                    while (true)
                    {
                        var first = compareNum < 0 ? 0 : compareNum /10;
                        var second = compareNum < 0 ? compareNum : compareNum % 10;

                        //결과값의 일의 자리 수
                        var result = (first + second) % 10;

                        //기존 일의 자리 수의 10의 곱과 결과값의 일의 자리 수를 더한다.
                        compareNum = second * 10 + result;

                        count++;

                        if (num == compareNum)
                        {
                            break;
                        }
                    }
                    Console.WriteLine(count);
                } 
            }
        }
    }
}
```

* 반복문의 조건을 무한루프를 돌리고 내부에서 조건이 맞는 경우 break문으로 빠져나가게 함
* 삼항연산자를 이용하여 코드를 간결하게 줄임
* 백준에 제출한 결과 위의 코드보다 속도는 8ms가 늘었고  코드길이는 450B 가량 줄었다.

