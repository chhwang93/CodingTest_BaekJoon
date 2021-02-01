## 1단계 - 입출력과 사칙연산

### 문제 2557번 - Hello World!를 출력하시오.

```markdown
using System;

class Question
{
	static void Main(string[] args)
	{
		 Console.WriteLine("Hello World!");	
	}
}
```

- 첫 번째로 풀어본 백준 코딩테스트 문제

- 가장 간단한 Hello World!를 작성하는 문제

- 간단한 문제라고 생각했지만 생각보다 **철자 오타라던지 대소문자로 인해 10번이나 다시 고쳤다.**

- 경력자라고 너무 쉽게 생각했던게 자만인 것으로 생각됨

  

### 문제 10718번 - We love kriii(격려의 문구를 출력해주자)

```markdown
using System;

class Question10718
{
	static void Main(string[] args)
	{
		Console.WriteLine("강한친구 대한육군");
		Console.WriteLine("강한친구 대한육군");
	}
}
```

- 두 번째로 풀어본 백준 코딩테스트 문제
- 위의  **Hello World!와 거의 동일**하다. 다만  두 줄로 줄바꿈을 해서 표시
- 철자 오타와 대소문자를 위에서 한번 겪고 나니 한 번에 통과!!



### 문제 10171번 - 아래 예제와 같이 고양이를 출력하시오.

```markdown
\\    /\\
 )  ( ')
(  /  )
 \\(__)|

이런 모양의 고양이를 출력해야 함

using System;

class Question10171
{
    static void Main(string[] args)
    {
        Console.WriteLine("\\\\    /\\\\");
        Console.WriteLine(" )  ( ')");
        Console.WriteLine("(  /  )");
        Console.WriteLine(" \\\\(__)|");
    }
}
```

- 세 번째로 풀어본 백준 코딩테스트 문제
- 문자열 중 **이스케이프 시퀀스** 관련해서 낸 문제로 보임
- 처음에는 아무 생각없이 역슬래쉬를 그냥 써서 컴파일 에러 오류가 생겨 확인해보니 이스케이프 시퀀스 오류라고 하여 확인해본 결과 역슬래쉬는 \\ 작성을 해야 \로 인식한다.
- \\로 작성했지만 계속해서 컴파일 오류 발생, 맨 앞에 문자열도 역슬래쉬였다. 앞의 문자열도 \\로 작성해주니 정상적으로 맞음



### 문제 10172번 - 아래 예제와 같이 개를 출력하시오.

```markdown
|\\_/|
|q p|   /}
( 0 )"""\\
|"^"`    |
||_/=\\\\__|

using System;
 
class Question10172
{
    static void Main(string[] args)
    {
        Console.WriteLine("|\\\\_/|");
        Console.WriteLine("|q p|   /}");
        Console.WriteLine("( 0 )\\"\\"\\"\\\\");
        Console.WriteLine("|\\"^\\"`    |");
        Console.WriteLine("||_/=\\\\\\\\__|");
    }
}
```

- 네 번째로 풀어본 백준 코딩테스트 문제
- 세 번째 문제처럼 **이스케이프 시퀀스** 관련한 문제
- 여기서 이스케이프 시퀀스 관련된 문자열은 "(큰따옴표), \(역슬래쉬)임
  - \"로 작성해야 "가 출력되고 \\로 작성해야 \가 출력됨
  - 컴파일 에러 확인하고 고치느라 애먹었다.



### 문제 1000번 - 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

```markdown
첫 째줄에 A와 B가 주어진다.(0 <A, B<10)
출력은 첫째 줄에 A+B를 출력한다.

예제 1 2
예제 출력 3

using System;

class Question1000
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            A = int.Parse(split[0]);
            B = int.Parse(split[1]);
            C = A + B;
            Console.WriteLine(C);
        }
    }
```

- C# 콘솔 입력은 Console.ReadLine()으로 받음

- 문자열로 반환되기 때문에 이를 Split 함수를 통해 나눌 필요가 있다.

- 문자열로 나눠진 값을 int.Parse(문자열)을 통해 정수로 변환 후 두 정수를 더하면 된다.

- 다른 사람이 아스키코드 방식으로 푼 방식 확인

  - 문자열 '0'은 십진수 48이며, 입력값이 1,2였을 때 십진수는 49, 50이 된다. 49에서 48을 빼면 1이 나오고 50-48을 빼면 2가 나오니 1+2 =3이 나온다.

    ```markdown
    using System;
    
    namespace Practice
    {
        internal class Practice
        {
            private static void Main()
            {
                var input = Console.ReadLine();
                Console.WriteLine(input[0] - '0' + input[2] - '0');
            }
        }
    }
    ```



### 문제 1001번 - 두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램을 작성하시오.

```markdown
using System;

namespace BaekJoon
{
    class Question1001
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //입력이 3개 이상인 경우(A, 공백, B)
            if (input.Length > 2)
            {
                //아스키코드 0에서 입력값을 빼면 정수가 나옴
                int a = Convert.ToInt32(input[0] - '0');
                int b = Convert.ToInt32(input[2] - '0');

                //a는 0보다 크고 b는 10보다 작음
                if (a > 0 && b < 10)
                {
                    Console.WriteLine(a - b);
                }
            }
        }
    }
}
```

- 위와 동일한 문제지만 연산자가 -인 문제
- 아스키코드로 한번 풀어봤다. 유효값 설정 조건이 있어 조건값도 작성함
- VisualStudio에서 확인 후 제출하니 한번에 맞췄다.



### 문제 10998번 - 두 정수 A와 B를 입력받은 다음, AxB를 출력하는 프로그램을 작성하시오.

```markdown
using System;

namespace BaekJoon
{
    class Question10998
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //입력이 3개 이상인 경우(A, 공백, B)
            if (input.Length > 2)
            {
                //아스키코드 0에서 입력값을 빼면 정수가 나옴
                int a = Convert.ToInt32(input[0] - '0');
                int b = Convert.ToInt32(input[2] - '0');

                //a는 0보다 크고 b는 10보다 작음
                if (a > 0 && b < 10)
                {
                    Console.WriteLine(a * b);
                }
            }
        }
    }
}
```

- 위와 동일한 문제지만 연산자가 *인 문제
- 위의 문제에서 연산자만 바꿔주면 바로 풀린다.



### 문제 1008번 - 두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.

```markdown
using System;

namespace BaekJoon
{
    class Question1008
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //입력이 3개 이상인 경우(A, 공백, B)
            if (input.Length > 2)
            {
                //아스키코드 0에서 입력값을 빼면 정수가 나옴
                double a = Convert.ToDouble(input[0] - '0');
                double b = Convert.ToDouble(input[2] - '0');

                //a는 0보다 크고 b는 10보다 작음
                if (a > 0 && b < 10)
                {
                    Console.WriteLine(a / b);
                }
            }
        }
    }
}
```

- 위의 곱셈 문제와 동일하다.
- 다만 조건에는 실제 정답과 출력값의 절대오차 또는 상대오차가 10의 -9승 이하이면 정답으로 나와 있는데 이는 **Double형으로 나눠야하는 것을 의미**
- 처음에 Float형으로 나눠서 자신있게 제출했다가 틀렸다고 해서 조건을 다시 보게 되었다.
- 조건을 확실히 보고 정확한 답을 제출하자!



### 문제 10869번 - 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오.

```markdown
using System;

namespace Baekjoon
{
    internal class Question10869
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int A = int.Parse(split[0]);
            int B = int.Parse(split[1]);

            if ((A >= 1 && A <= 10000) && (B >= 1 && B <= 10000))
            {
                Console.WriteLine(A + B);
                Console.WriteLine(A - B);
                Console.WriteLine(A * B);
                Console.WriteLine(A / B);
                Console.WriteLine(A % B);
            }
        }
    }
}
```

- 모든 사칙연산을 사용하는 문제
- 조건은 두 자연수가 제공(1≤A, B≤10,000)
- 첫째 줄에 A+B, 둘째 줄에 A-B, 셋째 줄에 A*B, 넷째 줄에 A/B, 다섯째 줄에 A%B를 출력한다.
- 조건 단위가 1에서 10000사이이므로 아스키코드로 작성하면 틀린 답으로 나온다.
  - 문자열을 나눠서 정수로 변환 후 조건을 확인 후 사칙연산을 진행한다.



### 문제 10430번 - 사칙연산 복합 문제

```markdown
(A+B)%C는 ((A%C) + (B%C))%C 와 같을까?

(A×B)%C는 ((A%C) × (B%C))%C 와 같을까?

세 수 A, B, C가 주어졌을 때, 위의 네 가지 값을 구하는 프로그램을 작성하시오.

using System;

namespace Baekjoon
{
    internal class Question10430
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int A = int.Parse(split[0]);
            int B = int.Parse(split[1]);
            int C = int.Parse(split[2]);

            if ((A >= 2 && A <= 10000) && (B >= 2 && B <= 10000)
                && (C >=2 && C<=10000))
            {
                Console.WriteLine((A + B) % C);
                Console.WriteLine(((A % C) + (B%C)) % C);
                Console.WriteLine((A * B)%C);
                Console.WriteLine(((A % C)*(B%C))%C);
            }
        }
    }
}
```

- 복합적인 사칙연산을 사용하는 문제
- 조건은 세 개의 자연수가 제공됨(2≤A,B,C≤10000)
- 첫 째 줄에 (A+B)%C를 출력한다.
- 둘 째 줄에 ((A%C)+(B%C))%C를 출력한다.
- 셋 째 줄에 (A*B)%C를 출력한다.
- 넷 째 줄에 ((A%C)*(B%C))%C를 출력한다.
- 한번에 맞췄음



### 문제 2588번 - 곱셈 문제

- (세 자리 수) × (세 자리 수)는 다음과 같은 과정을 통하여 이루어진다.

- (1)과 (2)위치에 들어갈 세 자리 자연수가 주어질 때 (3), (4), (5), (6)위치에 들어갈 값을 구하는 프로그램을 작성하시오.

  ![실력키우기 곱셈(JAVA)](https://lh3.googleusercontent.com/proxy/E0b5RxqbEtOHGj-EtiP3dw498rcgb7ezIWEwWIMHAl0Str_RgW6cJ0TUshfWz9nNg7Oi6dhC0uIhzLYEaMo8KnFoZHytqwkYHyCWkbbLw9Z3xBzMpzx_M2KHLBLEyQdgurZ0sd9hn_BQTCUu_30uqRY)

  ```markdown
  using System;
  
  namespace Baekjoon
  {
      //2588번 문제
      internal class Question2588
      {
          public static void Main(string[] args)
          {
              var inputA = Console.ReadLine();
              var inputB = Console.ReadLine();
  
              var A = int.Parse(inputA);
              var B = int.Parse(inputB);
  
              var B100 = B / 100; //100의 자리수
              var B10 = B / 10 % 10; //10의 자리수
              var B1 = B % 10; //1의 자리수
  
              Console.WriteLine(A * B1);
              Console.WriteLine(A * B10);
              Console.WriteLine(A * B100);
              Console.WriteLine(A * B);
          }
      }
  }
  ```

  - 곱셈 문제로써 그냥 곱셈하는 것이 아닌 곱셈의 과정을 출력하는 문제임
  - 따라서 피연산자 A와 B의 계산에서 B의 100의 자리수, 10의 자리수, 1의 자리수 단위로 곱셈을 해야 함
  - 자리수를 구하기 위해 몫과 나머지를 구해서 작성함
  - 한 번에 맞춘 문제