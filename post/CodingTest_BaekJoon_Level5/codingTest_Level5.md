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