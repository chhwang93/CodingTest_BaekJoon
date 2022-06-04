using CodingTestProject.Sort;
using System;

namespace CodingTestProject
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IExecute excute = new SelectionSort();
            excute.Execute();
        }

        public static class CommonUtil
        {
            #region 공통 입력 기능
            public static string[] GetInputStrings(string input, params char[] separator)
            {
                return input.Split(separator);
            }
            #endregion

            #region 문자열 배열 변환
            public static float[] GetFloatArrayFromStringArray(string[] input)
            {
                return Array.ConvertAll(input, float.Parse);
            }
            public static double[] GetDoubleArrayFromStringArray(string[] input)
            {
                return Array.ConvertAll(input, double.Parse);
            }
            public static int[] GetIntArrayFromStringArray(string[] input)
            {
                return Array.ConvertAll(input, int.Parse);
            }
            public static long[] GetLongArrayFromStringArray(string[] input)
            {
                return Array.ConvertAll(input, long.Parse);
            }
            #endregion

            #region 문자열 변환
            public static T GetConvertValue<T>(string input)
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }

            public static T GetConvertValue<T>(char input)
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            #endregion

            #region 숫자의 합
            public static long FindSumOfLong(string input)
            {
                long sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    sum += (CommonUtil.GetConvertValue<long>(input[i]) - 48);
                }

                return sum;
            }

            public static int FindSumOfInt(string input)
            {
                int sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    sum += (CommonUtil.GetConvertValue<int>(input[i]) - 48);
                }

                return sum;
            }
            #endregion

            #region 구간의 합
            public static int[] GetPrefixSum(int[] array)
            {
                var result = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = result[i] + array[i];
                }

                return result;
            }
            public static long[] GetPrefixSum(long[] array)
            {
                var result = new long[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = result[i] + array[i];
                }

                return result;
            }
            public static float[] GetPrefixSum(float[] array)
            {
                var result = new float[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = result[i] + array[i];
                }

                return result;
            }
            public static double[] GetPrefixSum(double[] array)
            {
                var result = new double[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = result[i] + array[i];
                }

                return result;
            }

            public static int[,] GetPrefixSumFromMatrix(int[,] matrix, int row, int col)
            {
                var result = new int[row + 1, col + 1];

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        result[i, j] = result[i, j - 1] + result[i - 1, j] - result[i - 1, j - 1] + matrix[i, j];
                    }
                }

                return result;
            }
            public static long[,] GetPrefixSumFromMatrix<T>(long[,] matrix, int row, int col)
            {
                var result = new long[row + 1, col + 1];

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        result[i, j] = result[i, j - 1] + result[i - 1, j] - result[i - 1, j - 1] + matrix[i, j];
                    }
                }

                return result;
            }
            public static float[,] GetPrefixSumFromMatrix<T>(float[,] matrix, int row, int col)
            {
                var result = new float[row + 1, col + 1];

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        result[i, j] = result[i, j - 1] + result[i - 1, j] - result[i - 1, j - 1] + matrix[i, j];
                    }
                }

                return result;
            }
            public static double[,] GetPrefixSumFromMatrix<T>(double[,] matrix, int row, int col)
            {
                var result = new double[row + 1, col + 1];

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        result[i, j] = result[i, j - 1] + result[i - 1, j] - result[i - 1, j - 1] + matrix[i, j];
                    }
                }

                return result;
            }
            #endregion
        }
    }
}
