using System;

namespace CodingTestProject.DataStructure
{
    public class DNAPassword : IExecute
    {
        private int checkCount = 0;
        private int result = 0;

        public void Execute()
        {
            var inputNums = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));
            var inputValue = Console.ReadLine();
            var inputLength = CommonUtil.GetIntArrayFromStringArray(Console.ReadLine().Split(' '));

            var s = inputNums[0];
            var p = inputNums[1];

            checkCount = 0;
            result = 0;

            if (inputLength.Length == 4)
            {
                var compareArray = new int[inputLength.Length];
                var checkArray = new int[inputLength.Length];
              
                //초기 최소 개수 할당
                for(int i=0; i<inputLength.Length; i++)
                {
                    compareArray[i] = inputLength[i];   // A, C, G, T 순서의 개수

                    if(compareArray[i]==0)
                    {
                        checkCount++;
                    }
                }

                //초기 입력된 개수 확인
                for(int i=0; i<p; i++)
                {
                    Add(inputValue[i], compareArray, ref checkArray);
                }

                if(checkCount == 4)
                {
                    result++;
                }

                //추가 또는 삭제 처리
                for( int i = p; i< s ; i++)
                {
                    Delete(inputValue[i - p], compareArray, ref checkArray);
                    Add(inputValue[i], compareArray, ref checkArray);

                    if(checkCount == 4)
                    {
                        result++;
                    }
                }

                Console.WriteLine(result);
            }
        }

        private void Add(char inputChar, int[] compareArray, ref int[] checkArray)
        {
            switch (inputChar)
            {
                case 'A':
                    checkArray[0]++;
                    if(compareArray[0] == checkArray[0])
                    {
                        checkCount++;
                    }
                    break;

                case 'C':
                    checkArray[1]++;
                    if (compareArray[1] == checkArray[1])
                    {
                        checkCount++;
                    }
                    break;

                case 'G':
                    checkArray[2]++;
                    if (compareArray[2] == checkArray[2])
                    {
                        checkCount++;
                    }
                    break;

                case 'T':
                    checkArray[3]++;
                    if (compareArray[3] == checkArray[3])
                    {
                        checkCount++;
                    }
                    break;
            }
        }

        private void Delete(char inputChar, int[] compareArray, ref int[] checkArray)
        {
            switch (inputChar)
            {
                case 'A':
                    if(compareArray[0]==checkArray[0])
                    {
                        checkCount--;
                    }
                    checkArray[0]--;
                    break;

                case 'C':
                    if (compareArray[1] == checkArray[1])
                    {
                        checkCount--;
                    }
                    checkArray[1]--;
                    break;

                case 'G':
                    if (compareArray[2] == checkArray[2])
                    {
                        checkCount--;
                    }
                    checkArray[2]--;
                    break;

                case 'T':
                    if (compareArray[3] == checkArray[3])
                    {
                        checkCount--;
                    }
                    checkArray[3]--;
                    break;
            }
        }
    }
}
