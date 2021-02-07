## 3단계 - for문

### 2739번 문제 - 구구단

```markdown
/// <summary>
    /// 2739번 문제
    /// </summary>
    internal class Question2739
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            //콘솔 입력값이 있는 지 확인
            if(input!=null)
            {
                //정수 변환 검사
                if(int.TryParse(input, out int N))
                {
                    //N은 1보다 크거나 같고 9보다 작거나 같다.
                    if(N >=1 && N<=9)
                    {
                        for(int i=1; i<=9; i++)
                        {
                            Console.WriteLine(string.Format("{0} * {1} = {2}", N, i, N * i));
                        }
                    }
                    else
                    {
                        Console.WriteLine("N이 1보다 작거나 9보다 크다");
                    }
                }
                else
                {
                    Console.WriteLine("입력된 값이 정수값이 아닙니다.");
                }
            }
            else
            {
                Console.WriteLine("입력값이 null");
            }
        }
    }
```

- for문 기준 가장 간단한 문제
- 구구단을 작성하는 것, 조건은 N은 1보다 크거나 같고 9보다 작거나 같다.
- 입력받은 N을 9단까지 출력
- 한 번에 맞춤

### 10950번 문제 - A+B 합 for문

```markdown
using System;

namespace Baekjoon
{
    internal class Question10950
    {
        public static void Main(string[] args)
        {
            //입력값 
            var input = Console.ReadLine();

            if(input!=null)
            {
                //int 변환 검사
                if(int.TryParse(input, out int count))
                {
                    //A+B 합 배열
                    int[] sumArray = new int[count];

                    //개수만큼 for문을 돌면서 A,B값을 구하고 더한다.
                    for (int i=0; i<count; i++)
                    {
                        var inputAB = Console.ReadLine();
                        if(inputAB!=null)
                        {
                            var splitInputAB = inputAB.Split(' ');
                            if(splitInputAB!=null && splitInputAB.Length==2)
                            {
                                if((int.TryParse(splitInputAB[0], out int A) && int.TryParse(splitInputAB[1],
                                    out int B)))
                                {
                                    sumArray[i] = A + B;
                                }
                            }
                        }
                    }

                    //합 결과 배열을 출력
                    for(int i=0; i<count; i++)
                    {
                        Console.WriteLine(sumArray[i]);
                    }
                }
            }
        }
    }
}
```

- 기존 사칙연산 문제에서 for문을 접목한 문제
- 처음 입력한 값이 for문을 도는 개수
- 그 후 입력 값은 A와 B 값으로 입력됨
- 최종적으로 입력된 값은 for문을 돌면서 출력됨
- 한 번에 맞춤



### 8393번 문제 - 합

```
using System;

namespace Baekjoon
{
    internal class Question8393
    {
        public static void Main(string[] args)
        {
            //입력값 
            var input = Console.ReadLine();

            if(input!=null)
            {
                //int 변환 검사
                if(int.TryParse(input, out int num))
                {
                    //총 합
                    var total = 0;

                    //for문 돌면서 더한다.
                    for(int i=1; i<=num; i++)
                    {
                        total += i;
                    }

                    //출력값
                    Console.WriteLine(total);
                }
            }
        }
    }
}
```

* 입력된 값을 활용하여 for문을 돌면서 합을 구하는 문제
* 간단한 문제라 맞춤



### 15552번 문제 - 빠른 A+B

```markdown
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question15552
    {
        public static void Main(string[] args)
        {
            //입력값 
            var inputNum = Console.ReadLine();
            var sb = new StringBuilder();

            if (inputNum != null)
            {
                //int 변환 검사
                if (int.TryParse(inputNum, out int num))
                {
                    //최대값은 1,000,000
                    if (num <= 1000000)
                    {
                        //StringBuilder로 문자열을 추가한다.
                        for (int i = 0; i < num; i++)
                        {
                            var result = Console.ReadLine().Split(' ');

                            if(int.TryParse(result[0], out int A) && int.TryParse(result[1], out int B))
                            {
                                sb.Append(A + B);
                                sb.Append("\n");
                            }
                        }

                        Console.WriteLine(sb);
                    }
                }
            }
        }
    }
}
```

* 기존 A+B의 합을 구하는 방식에서 실행속도가 빨라야한다.
* 처음에는 Split() 함수가 느렸다고 생각해 자르지 않고 할 수 있는 방법을 찾아봤는데 시간초과가 생각보다 맞추기 어려웠다.
* Microsoft Docs에서 String 관련된 내용을  확인하면 String을 수정하게 되면 새로운 문자열을 만들기 때문에 속도가 느린 것이었다.

![image-20210205004851559](../../image/stringbuilder.png)



* 따라서 StringBuilder를 통해 값을 합치는 방식을 사용하여 새 문자열을 생성하지 않도록 작성하였다.
* 그 후 제출하여 무사히 통과하였다.



### 2741번 문제 - N 찍기

```
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question2741
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                if(num >=1 && num<=100000)
                {
                    for(int i=1; i<=num; i++)
                    {
                        sb.Append(i);
                        sb.AppendLine();
                    }

                    Console.WriteLine(sb);
                }
            }
        }
    }
}
```

* for문으로 입력된 값 N만큼을 1~N값을 한줄에 하나씩 출력하는 문제
* 위의 빠른 A+B에 비하면 쉬웠으나 문제 자체가 시간 제한이 있는 줄 모르고 for문마다 Console.WriteLine을 작성했더니 시간초과로 틀렸다.
* 다시 StringBuilder를 통해 값을 저장하고 한 번에 출력함으로써 통과



### 2742번 문제 - 기찍 N

```markdown
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question2742
    { 
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                if(num>=1 && num <=100000)
                {
                    for(int i=num; i>=1; i--)
                    {
                        sb.Append(i);
                        sb.AppendLine();
                    }

                    Console.WriteLine(sb);
                }
            }
        }
    }
}
```

* 위의 2741번 문제를 그냥 리버스시킨 내용이다. 그래서 그런지 문제 이름도 기찍 N
* 방법은 2741번 문제와 동일하다. StringBuilder로 합쳐주고 한 번에 출력해주면 끝
* 한 번에 통과



### 11021번 문제 - A+B - 7

```
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question11021
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                for(int i=1; i<=num; i++)
                {
                    var inputAB = Console.ReadLine().Split();
                    if(inputAB.Length==2)
                    {
                        var a = int.Parse(inputAB[0]);
                        var b = int.Parse(inputAB[1]);
                        if ((a > 0 && a < 10) && (b > 0 && b < 10))
                        {
                            sb.Append("Case #");
                            sb.Append(i);
                            sb.Append(": ");
                            sb.Append(a + b);
                            sb.AppendLine();
                        }
                    }
                }

                Console.WriteLine(sb);
            }
        }
    }
}
```

* 15552번 문제의 출력을 조금 더 아름답게 출력하기 위한 문제
* 위의 A+B 문제와 방법은 동일하다. 입력 개수를 받고 입력 개수만큼 for문을 돌면서 StringBuilder에 문자열을 합쳐주고 출력
* 문자열을 빠르게 출력하는 방식은 15552번 문제를 한 번 겪고 나니 금방 풀 수 있게 됨



### 11022번 문제 - A+B - 8

```
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question11022
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                for(int i=1; i<=num; i++)
                {
                    var inputAB = Console.ReadLine().Split();
                    if(inputAB.Length==2)
                    {
                        var a = int.Parse(inputAB[0]);
                        var b = int.Parse(inputAB[1]);
                        if ((a > 0 && a < 10) && (b > 0 && b < 10))
                        {
                            sb.Append("Case #");
                            sb.Append(i);
                            sb.Append(": ");
                            sb.Append(a);
                            sb.Append(" + ");
                            sb.Append(b);
                            sb.Append(" = ");
                            sb.Append(a + b);
                            sb.AppendLine();
                        }
                    }
                }

                Console.WriteLine(sb);
            }
        }
    }
}
```

* 11021번 문제에서 조금 더 아름답게 만드는 문제이다.
* 계속해서 비슷한 문제가 출제되는 것으로 봐서 입출력 관련하여 시간 제한을 두고 익숙하라는 뜻 같다.
* 내용은 11021번 문제와 거의 동일하기 때문에 따로 해석을 안해도 될 것으로 보임



### 2438번 문제 - 별 찍기 - 1

```
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question2438
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                if (num >= 1 && num <= 100)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append("*");
                        }
                        sb.AppendLine();
                    }
                    Console.WriteLine(sb);
                }
            }
        }
    }
}
```

* 입력된 N 개수만큼 별을 출력한다.
* 이중 for문을 이용하여 *을 출력하고 StringBuilder로 합친 후 출력한다.
* for문 관련하여 문제를 계속해서 풀 때마다 익숙해지는 것 같다.



### 2439번 문제 - 별 찍기 - 2

```
using System;
using System.Text;

namespace Baekjoon
{
    internal class Question2439
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                if(num>=1 && num<=100)
                {
                    for(int i=0; i<num; i++)
                    {
                        for(int j=0; j<num; j++)
                        {
                            if(j<num-(i+1))
                            {
                                sb.Append(" ");
                            }
                            else
                            {
                                sb.Append("*");
                            }
                        }
                        sb.AppendLine();
                    }

                    Console.WriteLine(sb);
                }
            }
        }
    }
}
```

* 2438번의 별 찍기 문제에서 오른쪽 기준으로 별이 정렬하도록 만드는 문제
* 2438번 문제의 경우 그냥 for문을 돌려서 별을 출력했지만 이번 문제는 공백과 별이 들어간다.
  * 이중 포문을 돌면서 i가 증가할 때마다 공백이 줄어들고 별이 추가되는 방식으로 작성하였다.
* 한 번에 통과