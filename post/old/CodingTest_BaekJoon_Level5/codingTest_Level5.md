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



### 2562번 문제 - 최댓값

```
using System;

namespace Baekjoon
{
    internal class Question2562
    {
        public static void Main(string[] args)
        {
            var count = 9;
            var intArray = new int[count];

            //1차원 배열에 입력한다.
            for(int i=0; i<count; i++)
            {
                if(int.TryParse(Console.ReadLine(), out int value) && (value > 0 && value < 100))
                {
                    intArray[i] = value;
                }
            }

            //최대값과 최대값에 해당하는 인덱스를 구한다.
            var max = int.MinValue;
            var index = -1;

            for(int i=0; i<count; i++)
            {
                var value = intArray[i];
                if(max < value)
                {
                    max = value;
                    index = i+1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}
```

* 9개의 서로 다른 자연수가 주어지며 이 중 최대값을 찾고 인덱스를 구하는 문제
* 9개의 정수를 담을 수 있는 정수 배열을 생성하고 Console.ReadLine()을 통해 입력받은 정수를 저장한다.
* for문을 돌면서 최대값과 그에 해당하는 인덱스를 입력받아 출력한다.
* 시간은 92ms 걸림
* 한 번에 통과



### 2577번 문제 - 숫자의 개수

```
using System;

namespace Baekjoon
{
    internal class Question2577
    {
        public static void Main(string[] args)
        {
            var inputA = Console.ReadLine();
            var inputB = Console.ReadLine();
            var inputC = Console.ReadLine();

            int[] intArray = new int[10];

            if(int.TryParse(inputA, out int A) && int.TryParse(inputB, out int B) && int.TryParse(inputC, out int C))
            {
                if((A>=100 && A<1000) && (B >= 100 && B < 1000) && (C >= 100 && C < 1000))
                {
                    var result = A * B * C;

                    while(result>=10)
                    {
                        var quotient = result / 10;
                        var remainder = result % 10;

                        result = quotient;

                        intArray[remainder]++;
                    }

                    intArray[result]++;
                }

                for(int i=0; i<intArray.Length; i++)
                {
                    Console.WriteLine(intArray[i]);
                }
            }
        }
    }
}
```

* 입력된 정수 A,B,C값을 곱하고 계산한 결과가  0부터 9까지 숫자가 몇 번씩 쓰여졌는지 확인하는 문제
* 각 자리수는 while문을 돌면서 결과값의 몫과 나머지를 구하고 몫은 이전 자리 수가 있는 값으로 이동하고 나머지를 인덱스로 하여 개수를 늘렸다.
* 시간은 92ms 걸렸고 맞춘 사람 방식을 보니 ASII코드를 사용하여 처리한 방식이 84ms로 빨랐다.
* 한 번에 통과



### 3052번 문제 - 나머지

```
using System;

namespace Baekjoon
{
   internal class Question3052
    {
        public static void Main(string[] args)
        {
            var count = 10;
            var intArray = new int[count];

            for(int i=0; i< count; i++)
            {
                var input = Console.ReadLine();
                if(int.TryParse(input, out int value))
                {
                    if(value>=0 && value<=1000)
                    {
                        //42로 나눈 나머지를 저장
                        intArray[i] = value % 42;
                    }
                }
            }

            //배열을 정렬한다.
            Array.Sort(intArray);

            var compare = 0;
            var totalNum = 0;

            for(int i=0; i<count; i++)
            {
                //초기값일 때 비교값을 저장하고 총 개수를 증가시킨다.
                if(i==0)
                {
                    compare = intArray[i];
                    totalNum++;
                }
                //비교값과 현재값을 비교하여 다른 경우 비교값을 변경하고 총 개수를 증가시킨다.
                else
                {
                    if(compare != intArray[i])
                    {
                        compare = intArray[i];
                        totalNum++;
                    }
                }
            }
            Console.WriteLine(totalNum);
        }
    }
}
```

* 정수를 10개 입력 받은 후 42로 나눈 나머지가 서로 다른 게 몇개인지 출력하는 문제
* 처음에 42로 나눈 나머지값을 정수 배열에 저장하고 배열을 순서대로 정렬한다.
* 정렬된 값을 for문을 돌면서 비교하여 달라지는 경우 총 개수를 증가시키고 비교값을 변경한다.
* 시간은 100ms 걸렸고 1등과 비교하면 16ms 차이가 났다. 이는 Array.Sort() 함수를 실행하면서 정렬에 시간이 걸린 것으로 보인다.
* 한 번에 통과



### 1546번 문제 - 평균

```
using System;

namespace Baekjoon
{
    internal class Question1546
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(uint.TryParse(input, out uint num))
            {
                if(num<=1000)
                {
                    var inputArray = Console.ReadLine().Split(' ');

                    if(num==inputArray.Length)
                    {
                        var intArray = new float[num];
                        var max = float.MinValue;

                        for (int i=0; i<num; i++)
                        {
                            if(float.TryParse(inputArray[i], out float value) && value <=100)
                            {
                                if(max<value)
                                {
                                    max = value;
                                }
                                intArray[i] = value;
                            }
                        }

                        float total = 0;

                        for(int i=0; i<num; i++)
                        {
                            total += (intArray[i] / max) * 100;
                        }

                        Console.WriteLine(total/num);
                    }
                }
            }
        }
    }
}
```

* 평균값을 구하는 문제인데 기본 점수를 입력받고 최대값을 구하여 점수/최대값*100으로 새로 계산했을 때의 평균을 구하는 문제이다.
* 첫 번째 줄에서 점수의 개수를 입력 받고 둘 째줄에서 점수 배열을 입력한다.
  * 점수의 개수와 문자열을 Split() 함수로 잘랐을 때 길이가 동일한 경우에만 다음 연산을 진행한다.
* 최대값을 구하고 구한 점수 배열을 재 계산하고 평균을 출력한다.
* 시간은 92ms가 걸렸고 1등과 4ms로 크게 차이가 안났다.
* 한 번에 통과



### 8958번 문제  - OX퀴즈

```
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question8958
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if(int.TryParse(input, out int num))
            {
                for(int i=0; i<num; i++)
                {
                    var inputValue = Console.ReadLine();

                    var count = inputValue.Length;

                    if (count > 0 && count < 80)
                    {
                        var total = 0;
                        var current = 0;

                        for (int j = 0; j < count; j++)
                        {
                            if (inputValue[j] == 'O' || inputValue[j] == 'o')
                            {
                                current++;
                                total += current;
                            }
                            else
                            {
                                current = 0;
                            }
                        }
                        sb.Append(total);
                        sb.AppendLine();
                    }
                }

                Console.WriteLine(sb);
            }
        }
    }
}
```

* 첫 번째 입력값을 정수 N으로 받아 정수 N만큼 OX결과값을 입력으로 받고 O인 경우 문제의 점수는 그 문제까지 연속된  O의 개수가 되고 총합을 출력하는 문제
* 입력받은 OX결과값을 String으로 받아 for문을 돌면서 O인지 X인지 비교한다.
  * O인 경우 현재값을 더하고 현재값을 총합에 더한다.
  * X인 경우 현재값을 초기화한다.
* 그 후 StringBuilder를 통해 출력한다.
* 시간은 96ms로 1등과 4ms 차이가 났다.
* 한 번에 통과



### 4344번 문제 - 평균은 넘겠지

```
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question4344
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            //테스트 케이스 개수를 입력받는다.(개수는 1<=N<=100)
            if(int.TryParse(input, out int num) && (num>=1&& num<=1000))
            {
                for(int i=0; i<num; i++)
                {
                    //공백으로 입력값을 구분한다.
                    var inputValue = Console.ReadLine().Split(' ');
                    var count = inputValue.Length;
                    var total = 0;
                    var array = new int[count-1];

                    //첫 번째 수는 개수를 의미하기 때문에 1부터 시작
                    for(int j=1; j<count; j++)
                    {
                        //점수 값을 배열에 저장하고 총합을 더한다.(점수는 0<=Value<=100)
                        if(int.TryParse(inputValue[j], out int value) && (value>=0 && value<=100))
                        {
                            array[j - 1] = value;
                            total += value;
                        }
                    }

                    count = array.Length;
                    var cur = 0;
                    //평균을 구한다.
                    var avg = (float)total / (float)count;
                    
                    //평균보다 높은 점수를 가진 개수를 구한다.
                    for(int j=0; j<count; j++)
                    {
                        if(avg < array[j])
                        {
                            cur++;
                        }
                    }

                    //비율 값을 구한다.
                    var result = ((float)cur / (float)count)*100;

                    sb.Append(result.ToString("N3"));
                    sb.AppendLine("%");
                }

                Console.WriteLine(sb);
            }
        }
    }
}
```

* 정답 비율 37.452%의 문제, 첫 째 줄에 테스트 케이스 개수가 주어지며 둘 째 줄에 점수 개수와 점수 개수에 맞는 점수들이 주어진다.
  * 점수의 평균보다 점수가 높은 학생의 수를 구하고 비율을 소수점 셋째 자리수까지 구하여 출력하도록 함
* 문제 자체는 그렇게 어렵지 않아 총합을 구하고 평균을 구해서 평균과 점수를 비교하여 점수가 평균보다 높으면 현재값을 더하여 비율을 구한다.
* 시간은 위의 코드로 작성했을 때 112ms가 나왔고 1위는 88ms가 걸렸다.
  * 조건식에서 시간이 걸리는 것을 확인하여 점수를 구할 때 int.TryParse()와 value값 조건식을 제거하고 나니 92ms로 1등과 4ms차이가 난 것을 확인
  * 시간이 ms 단위로 차이나기 때문에 조건식으로 예외처리 하는 것이 중요하다고 보고 위의 코드로 작성함
* 한 번에 통과했다.