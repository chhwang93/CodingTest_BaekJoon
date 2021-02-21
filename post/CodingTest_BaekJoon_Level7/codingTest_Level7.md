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



### 1152번 문제 - 단어의 개수

#### 첫 번째 작성한 코드

```
using System;

namespace BaekJoon
{
    internal class Question1152
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = input.Length;

            var isword = false;
            var result = 0;

            for (int i = 0; i < count; i++)
            {
                if(input[i]!=' ' && !isword)
                {
                    isword = true;
                    result++;
                }
                else if(input[i]==' ' && isword)
                {
                    isword = false;
                }
            }

            Console.WriteLine(result);
        }
    }
}
```

#### 개선된 코드

```
using System;

namespace BaekJoon
{
    internal class Question1152
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = input.Length;

            var isword = false;
            var result = 0;

            for (int i = 0; i < count; i++)
            {
                if(isword && input[i] != ' ')
                {
                    continue;
                }

                if (input[i] != ' ' && !isword)
                {
                    isword = true;
                    result++;
                    continue;
                }

                isword = false;
            }

            Console.WriteLine(result);
        }
    }
}
```

---

![image](https://user-images.githubusercontent.com/76270432/108369232-b418e000-723e-11eb-8362-375adc9af9e3.png)

---

* 정답 비율이 28.006%인 문제로 처음에 문제만 봤을 때는 그냥 Split()로 나누고 길이를 구하면 되는거 아니야? 하고 풀었다가 제출만 4번 연속 실패했다.

* 단어가 등장할 때마다 등장 횟수를 세어 출력하는 문제로 간단해보이지만 단어 앞 뒤로 공백이 있는 경우 공백은 제외해야 한다.
* 처음 제출할 때는 예제 입력값과 출력값이 정상적으로 나와서 제출했다가 문제를 다시 읽어보니 앞 뒤로 공백인 경우 또는 그냥 공백만 있는 경우 등의 경우의 수를 모두 다 따져봐야 되는 것이었다.
  * String.Split() 함수로 자르는 경우 단어가 공백 하나만 있을 때도 길이값이 1이 되기 때문에 실패하던 것이었음
* 따라서 문자열을 돌면서 단어가 시작되는 경우 개수를 증가시키고 공백이 나올 때까지 돌다가 공백이 나온 경우 다시 단어를 찾는 형식으로 하여 풀었다.
* 첫 번째 코드에서 시간은 108ms가 걸렸으며 두 번째 코드에서는 104ms로 1등과 4ms 차이가 났다.
* 풀면서 느낀 점은 문제를 유심히 잘 봐야하며 정답률이 낮은 경우 쉽게 보이는 문제라도 의심을 해봐야한다.



### 2908번 문제 - 상수

![image](https://user-images.githubusercontent.com/76270432/108595518-a5a80100-73c3-11eb-80d9-32d5bfdb4b7c.png)



#### 첫 번째 작성한 코드

```
using System;

namespace BaekJoon
{
    internal class Question2908
    {
        public static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ');

            if (inputArray.Length == 2 && (inputArray[0] != inputArray[1]))
            {
                if (int.TryParse(inputArray[0], out int a) && int.TryParse(inputArray[1], out int b))
                {
                    var a_100digits = a / 100;
                    var a_10digits = (a / 10) % 10;
                    var a_1digits = (a % 10) % 10;
                    var b_100digits = b / 100;
                    var b_10digits = (b / 10) % 10;
                    var b_1digits = (b % 10) % 10;

                    if ((a_100digits !=0 && a_10digits != 0 && a_1digits!=0)
                        && (b_100digits != 0 && b_10digits != 0 && b_1digits != 0))
                    {
                        var reverseA = a_1digits * 100 + a_10digits * 10 + a_100digits;
                        var reverseB = b_1digits * 100 + b_10digits * 10 + b_100digits;

                        Console.WriteLine(Math.Max(reverseA, reverseB));
                    }
                }
            }
        }
    }
}
```

#### 개선한 코드

```
using System;
using System.Text;

namespace BaekJoon
{
    internal class Question2908
    {
        public static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ');

            if (inputArray.Length == 2 && (inputArray[0] != inputArray[1]))
            {
                var a = ReverseNumberFromString(inputArray[0]);
                var b = ReverseNumberFromString(inputArray[1]);

                if(a!=0 && b!=0)
                {
                    Console.WriteLine(Math.Max(a, b));
                }
            }
        }

        public static int ReverseNumberFromString(string value)
        {
            var charArray = value.ToCharArray();
            var charCount = charArray.Length;
            var sb = new StringBuilder();

            for(int i= charCount-1; i>=0; i--)
            {
                var charValue = charArray[i] - 48;

                if(charValue==0)
                {
                    return 0;
                }

                sb.Append(charValue);
            }

            return int.Parse(sb.ToString());
        }
    }
}
```

* 입력된 두 개의 정수 값을 반대로 알아듣고 최대값을 구하는 문제
* 첫 번째 풀이 방식에서는 입력값을 정수로 변환 후 각 자리수를 구하여 반대로 값을 구해 최대값을 구하는 방식으로 진행
* 두 번째 풀이 방식에서는 함수를 통해 중복 코드 작성을 막고 문자를 아스키코드를 통해 각 자리수를 구하고 반대로 값을 구하여 반환하는 방식으로 진행
* 첫 번째 방식과 두 번째 방식은 시간은 92ms가 걸렸으며 1등과 4ms가 차이가 났다.
* 처음에 조건을 제대로 확인하지 않아 틀린  후 2번 째에 통과함



### 5622번 문제 - 다이얼

![image](https://user-images.githubusercontent.com/76270432/108612805-4aabf380-742f-11eb-98e0-3f12e75de56a.png)

---

#### 첫 번째 작성한 코드

```
using System;

namespace BaekJoon
{
    internal class Question5622
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = input.Length;

            if (count >= 2 && count <= 15)
            {
                var total = 0;

                for(int i=0; i<count; i++)
                {
                    total += GetNumberFromAlphabet(input[i]);
                }

                Console.WriteLine(total);
            }
        }

        public static int GetNumberFromAlphabet(char alphabet)
        {
            var alphabetASII = 65;
            var value = alphabet - alphabetASII;

            switch (value)
            {
                case 0:
                case 1:
                case 2:
                    return 3;
                case 3:
                case 4:
                case 5:
                    return 4;
                case 6:
                case 7:
                case 8:
                    return 5;
                case 9:
                case 10:
                case 11:
                    return 6;
                case 12:
                case 13:
                case 14:
                    return 7;
                case 15:
                case 16:
                case 17:
                case 18:
                    return 8;
                case 19:
                case 20:
                case 21:
                    return 9;
                case 22:
                case 23:
                case 24:
                case 25:
                    return 10;
            }

            return 0;
        }
    }
}
```

#### 개선한 코드

```
using System;

namespace BaekJoon
{
    internal class Question5622
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = input.Length;
            var alphabetArray = new int[] { 3, 3, 3, 4, 4, 4, 5, 5, 5, 
                6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10 };

            if (count >= 2 && count <= 15)
            {
                var total = 0;

                for(int i=0; i<count; i++)
                {
                    total += alphabetArray[input[i]-65];
                }

                Console.WriteLine(total);
            }
        }
    }
}
```

* 각 다이얼의 숫자에는  각각의 대문자 알파벳이 주어지며, 문자열이 주어졌을 때 문자열에 맞는 다이얼 번호값의 총합을 출력하는 문제
* 첫 번째 작성한 코드에서는 char 값을 입력으로 받는 함수를 작성하여 각 알파벳에 맞는 값을 반환하도록 코드를 작성하였다.
* 개선한 코드에서는 알파벳의 배열에 각각의 값을 할당하고 해당 알파벳 인덱스를 입력하여 총합을 구하는 식으로 변경하여 코드의 길이를 줄였다.
* 시간은 96ms로 1등과의 차이는 12ms로 제법 크게 났다.  1등의 코드를 확인하니 내 코드에서 조금 더 개선할 여지가 할 필요가 있었다.



