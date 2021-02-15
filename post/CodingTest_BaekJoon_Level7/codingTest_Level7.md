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