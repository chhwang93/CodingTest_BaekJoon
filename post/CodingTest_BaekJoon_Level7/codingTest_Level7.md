## 7단계 - 문자열

### 11654번 문제 - 아스키 코드

```
using System;

namespace BaekJoon
{
    internal class Question11654
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Console.Read());
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/107953773-eaf0bb00-6fde-11eb-81c6-8585ee0c93b9.png)

------

* 문자열 첫 번째 문제, 아스키 코드를 출력하는 문제이다.
* C#에서는 Console.Read() 함수가 아스키코드 int를 반환하는 기능을 하기 때문에 한 줄로 작성이 가능하다.
* 시간은 92ms가 걸렸으며 1등과의 차이는 4ms가 났다.
* 합격률이 81.351%인만큼 쉽게 통과



### 11720번 문제 - 숫자의 합

```
using System;

namespace BaekJoon
{
    internal class Question11720
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(int.TryParse(input, out int num))
            {
                if(num>=1 && num<=100)
                {
                    var inputValue = Console.ReadLine();
                    var count = inputValue.Length;
                    var total = 0;

                    for(int i=0; i<count; i++)
                    {
                        total += inputValue[i] - 48;
                    }

                    Console.WriteLine(total);
                }
            }
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/107955169-cf86af80-6fe0-11eb-880e-fb7ee414e22f.png)

---

* 첫째 줄에 정수의 개수가 주어지고 둘째 줄에 숫자 N개가 공백없이 주어지며 합을 구하는 문제이다.
* 문자열의 개수만큼 for문을 돌고 아스키코드 기준 십진수 48이 0이므로 48을 빼주면 정수가 나오게 된다.
* 시간은 92ms로 1등과 4ms 차이가 났다.
* 한 번에 통과



### 10809번 문제 - 알파벳 찾기

```
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question10809
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            for (char c = 'a'; c <= 'z'; c++)
            {
                sb.Append(input.IndexOf(c));
                sb.Append(' ');
            }

            Console.WriteLine(sb);
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/107959013-293da880-6fe6-11eb-815a-4d89eaf65e44.png)

---

* 알파벳 소문자로 이루어진 단어 문자열에서 등장하는 위치의 값을 출력하고 단어에 포함되지 않는 알파벳은 -1을 출력한다.
* 처음에는 단순하게 int 배열을 생성하고 -1로 초기화한 후 각 위치의 값을 넣어주는 식으로 하였다.
  * 이렇게 작성을 하니 코드의 길이가 길어지고 가독성이 좋지 않게 되었음
* 문자열 함수 중 IndexOf()는 포함하지 않는 경우 -1을 반환하기 때문에 문제의 해답과 가깝다고 생각하여 코드를 변경한 결과 짧은 코드 및 좋은 가독성을 얻게 되었다.
* 시간은 96ms로 1등과 4ms 차이가 났다.
* 한 번에 통과



### 2675번 문제 - 문자열 반복

#### 첫 번째 작성한 코드

```
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question2675
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                for (int i = 0; i < num; i++)
                {
                    if (num >= 1 && num <= 1000)
                    {
                        var inputArray = Console.ReadLine().Split(' ');
                        var count = inputArray.Length;

                        if (count == 2)
                        {
                            var repeat = int.Parse(inputArray[0]);
                            var stringLength = inputArray[1].Length;
                            var sb = new StringBuilder();

                            for (int j = 0; j < stringLength; j++)
                            {
                                for (int k = 0; k < repeat; k++)
                                {
                                    sb.Append(inputArray[1][j]);
                                }
                            }
                            Console.WriteLine(sb);
                        }
                    }
                }
            }
        }
    }
}
```

#### 개선된 코드

```using System;
using System.Text;

namespace BaekJoon
{
    internal class Question2675
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                for (int i = 0; i < num; i++)
                {
                    if (num >= 1 && num <= 1000)
                    {
                        var inputArray = Console.ReadLine();
                        var stringLength = inputArray.Length;
                      
                        if (stringLength > 0)
                        {
                            var repeatNum = inputArray[0] - '0';
                            var sb = new StringBuilder();

                            for (int cur = 2; cur < stringLength; cur++)
                            {
                                for (int r = 0; r < repeatNum; r++)
                                {
                                    sb.Append(inputArray[cur]);
                                }
                            }
                            Console.WriteLine(sb);
                        }
                    }
                }
            }
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/108075620-eb0bbc00-70ad-11eb-8ae6-078b1fc44e94.png)

---

* 첫 번째줄에는 테스트 케이스의 개수 T가 주어지며, 두 번째줄부터 정수 R과 문자열 S가 주어지며 문자열의 각 문자를 R번 반복하여 출력하는 문제
* 첫 번째 작성했을 때 문자열을 Stringn.Split() 함수로 자르고 정수와 문자열을 구분하여 for문을 돌면서 코드를 작성했다.
  * 한 번에 통과했지만 92ms로 1등과의 차이는 8ms가 났다.
* 두 번째 작성할 때는 조금 더 간결하고 빠르게 하기 위해 String.Split()을 사용하지 않고 첫 번째는 정수이기 때문에 아스키코드 값을 통해 정수를 구하고 공백을 제외하고 입력값의 두 번째 자리수부터 문자열이 입력되기 때문에 2부터 입력값의 길이만큼 for문을 돌면서 반복문자를 출력하였다.
  * 88ms로 줄어들었고 메모리도 많이 줄어들어 1등과의 차이는 4ms가 났다.



### 1157번 문제 - 단어 공부

#### 첫 번째 작성한 코드

```
using System;

namespace BaekJoon
{
    internal class Question1157
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var inputLength = input.Length;
            var alphabetArray = new int[26];
            var max = int.MinValue;
            var maxIndex = -1;

            for (int i = 0; i < inputLength; i++)
            {
                var index = input[i] - 97;
                var value = ++alphabetArray[index];

                if (value > max)
                {
                    max = value;
                    maxIndex = index;
                }
            }

            bool isMulti = false;

            for (int i = 0; i < 26; i++)
            {
                if (i != maxIndex && max == alphabetArray[i])
                {
                    isMulti = true;
                    break;
                }
            }

            if (isMulti)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(Convert.ToChar(maxIndex + 65));
            }
        }
    }
}
```

#### 개선된 코드

```
using System;

namespace BaekJoon
{
    internal class Question1157
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var inputLength = input.Length;
            var alphabetArray = new int[26];
            var max = int.MinValue;
            var maxIndex = -1;

            for (int i = 0; i < inputLength; i++)
            {
                var index = input[i] - 97;
                var value = ++alphabetArray[index];

                if (value > max)
                {
                    max = value;
                    maxIndex = index;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (i != maxIndex && max == alphabetArray[i])
                {
                    Console.WriteLine("?");
                    return;
                }
            }

            Console.WriteLine((char)(maxIndex + 65));
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/108088846-447ae780-70bc-11eb-930d-ead75da4d3b2.png)

---

* 알파벳 대소문자로 이루어진 단어가 입력되면 대소문자 구분없이 가장 많이 사용된 알파벳을 대문자로 출력한다.
  * 단 가장 많이 사용된 알파벳이 2개이상인 경우 ?을 출력한다.
* 입력 받은 문자열을 소문자 문자열로 변환 후 최대값을 가진 알파벳의 인덱스를 구한다. 그 후 알파벳의 배열을 비교하면서 최대값과 동일한 인덱스가 있는 경우 ?을 출력하고 아닌 경우 대문자 알파벳을 출력한다.
* 처음에 작성했을 때 시간은 132ms가 나왔으며 개선한 코드에서는 112ms로 20ms가 줄어든 것을 확인했다.
* 한 번에 통과