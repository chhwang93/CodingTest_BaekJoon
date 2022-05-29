
## 2단계 - if문

### 1330번 문제 - 두 수 비교하기

```markdown
using System;

namespace Baekjoon
{
    /// <summary>
    /// 1330번 문제
    /// </summary>
    internal class Question1330
    {
        public static void Main(string[] args)
        {
            //콘솔 입력값
            var input = Console.ReadLine();

            //콘솔 입력값이 null이 아닌경우
            if(input!=null)
            {
                //입력값을 공백 기준으로 나눔
                var splitInput = input.Split(' ');

                //공백 기준으로 나눴을 때 개수가 2개인 경우(값이 2개)
                if(splitInput.Length == 2)
                {
                    //정수로 변환되는지 확인
                    if(int.TryParse(splitInput[0], out int A) && int.TryParse(splitInput[1], out int B))
                    {
                        //A가 B보다 큰 경우
                        if(A>B)
                        {
                            Console.WriteLine(">");
                        }
                        //A가 B보다 작은 경우
                        else if (A < B)
                        {
                            Console.WriteLine("<");
                        }
                        //A와 B가 같은 경우
                        else
                        {
                            Console.WriteLine("==");
                        }
                    }
                }
            }
        }
    }
}
```

- 간단하게 두 수의 값을 if로 비교하는 문제
- 한 번에 맞춤

### 9498번 문제 - 시험 성적

### 시험 점수를 입력받아 100-90점은 A, 80-89점은 B, 70-79점은 C, 60-69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오. ###

```markdown
using System;

namespace Baekjoon
{
    /// <summary>
    /// 9498번 문제
    /// </summary>
    internal class Question9498
    {
        public static void Main(string[] args)
        {
            //콘솔 입력값 확인
            var input = Console.ReadLine();

            //정수로 변환되는지 확인
            if(int.TryParse(input, out int score))
            {
                //점수가 0과 100사이에 있는지 확인
                if(score>=0 && score<=100)
                {
                    if(score / 10 >=9)
                    {
                        Console.WriteLine("A");
                    }
                    else if(score/10 >=8)
                    {
                        Console.WriteLine("B");
                    }
                    else if (score / 10 >= 7)
                    {
                        Console.WriteLine("C");
                    }
                    else if (score / 10 >= 6)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("F");
                    }
                }
            }
        }
    }
}
```

- 시험 점수에 따른 등급을 나누는 문제

- 조건으로는 점수는 0점과 100점 사이에 존재해야 하며, 90-100점은 A등급, 80-89점은 B등급, 70-79점은 C등급, 60-69점은 D등급, 나머지는 F등급이다.

- 점수를 10으로 나눈 몫을 구하면 십의 자리를 구할 수 있기 때문에 십의 자리를 통해 등급을 나눈다.

- 한 번에 맞춤

  

### 2753번 문제 - 윤년

### 연도가 주어졌을 때 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.

### 윤년은 연도가 4의 배수이면서, 100의 배수가 아닐때 또는 400의 배수일 때이다.

```markdown
using System;

namespace Baekjoon
{
    /// <summary>
    /// 2753번 문제
    /// </summary>
    internal class Question2753
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(input!=null && input!=string.Empty)
            {
                if(int.TryParse(input, out int year))
                {
                    //연도는 1년보다 같거나 크고 4000년보다 작거나 같다.
                    if(year>=1 && year<=4000)
                    {
                        //윤년인 경우(4의 배수이면서 100의 배수가 아닐때 또는 400의 배수일 때)
                        if(year % 4 == 0 && (year % 100 !=0 || year %400 ==0))
                        {
                            Console.WriteLine(1);
                        }
                        else
                        {
                            Console.WriteLine(0);
                        }
                    }
                }
            }
        }
    }
}
```

- 윤년일 때 1이며, 윤년이 아닐 때 0을 구하는 문제
- 윤년의 조건은 4의 배수이면서 100의 배수가 아니거나 400의 배수일 때 윤년으로 본다.
  - if(year % 4 == 0 && (year % 100 !=0 || year %400 ==0)) 다음과 같은 조건일 때 윤년
- 한 번에 맞춤

### 14681번 문제 - 사분면 고르기

```markdown
using System;

namespace Baekjoon
{
    internal class Question14681
    {
        public static void Main(string[] args)
        {
            var inputX = Console.ReadLine();
            var inputY = Console.ReadLine();

            if(int.TryParse(inputX, out int x) && int.TryParse(inputY, out int y))
            {
                if((x>=-1000 && x<=1000) && (y>=-1000 && y<=1000))
                {
                    //x와 y가 양수인 경우(1사분면)
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine(1);
                    }
                    //x는 음수이고 y는 양수인 경우(2사분면)
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine(2);
                    }
                    //x와 y가 음수인 경우(3사분면)
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine(3);
                    }
                    //x는 양수이고 y는 음수인 경우(4사분면)
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine(4);
                    }
                }
            }
        }
    }
}
```

- 수학문제 중 어느 점이 사분면에 속하는지 확인하는 문제
- 두 개의 정수가 주어지며 두 개의 정수가 양수인지 음수인지에 따라 어떤 사분면인지 정해짐
- 한 번에 맞춤

### 2884번 문제 - 알람시계

### 알람시계를 평소에 일어나는 시간에서 45분을 뺀 시간으로 변경하는 문제

```markdown
internal class Question2884
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(input!=null)
            {
                var splitInput = input.Split(' ');

                //나눈 입력값의 개수가 2인경우
                if(splitInput!=null && splitInput.Length ==2)
                {
                    //정수로 변환할 때 검사를 통과해야 함
                    if(int.TryParse(splitInput[0], out int H) && int.TryParse(splitInput[1], out int M))
                    {
                        if((H>=0 && H<=23) && (M>=0 && M<=59))
                        {
                            //분이 45분보다 낮은 경우
                            if(M < 45)
                            {
                                //분은 60분 기준 45분에서 현재 분을 뺀것을 뺀다.
                                //M = 60 - (45 - M);
                                M+= 15;

                                //시간이 0보다 큰 경우 1만 빼고 0인 경우 23을 넣어준다.
                                H = H > 0 ? H - 1 : 23;
                            }
                            //분이 45분보다 높은 경우
                            else
                            {
                                //45분만 빼면 됨
                                M -= 45;
                            }

                            Console.WriteLine(string.Format("{0} {1}", H, M));
                        }
                    }
                }
            }
            
        }
    }
```

- 24시 기준으로 하며 시간은 0-23 사이 값, 분은 0-59 사이 값만 유효하다.
- 분이 45분보다 낮은 경우 시간과 분이 변경되며 분이 45분보다 높은 경우 분만 빼면 된다.
- M = 60 - (45 - M); → M+=15로 변경하면 더 간단하다.
- H = H > 0 ? H - 1 : 23; 이 구문에서 처음에 시간을 1보다 큰 경우로 작성하여 제출하는 바람에 틀렸다.
  - 1보다 큰 경우 1의 값도 뒤의 조건값을 타기 때문에
  - 두 번째 제출했을 때는 정답으로 처리됨

