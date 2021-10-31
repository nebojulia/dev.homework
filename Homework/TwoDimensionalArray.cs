using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class TwoDimensionalArray
    {
        //1. Найти минимальный элемент массива

        public static int SearchMin(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        //2. Найти максимальный элемент массива

        public static int SearchMax(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        //3. Найти индекс минимального элемента массива

        public static int[] SearchMinIndex(int[,]array)
        {
            int min = array[0, 0];
            int[] minIndex = new int[] {0,0};
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }
            return minIndex;
        }

        //4. Найти индекс максимального элемента массива

        public static int[] SearchMaxIndex(int[,] array)
        {
            int max = array[0, 0];
            int[] maxIndex = new int[] { 0, 0 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }
            return maxIndex;
        }

        //5. Найти количество элементов массива, которые больше всех своих соседей одновременно

        public static int CountBiggerNeighbor(int[,] array)
        {
            int count = 0;

            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < array.GetLength(1) - 1; j++)
                {

                    if ((i == 0 || array[i, j] > array[i - 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //6. Отразите массив относительно его главной диагонали

        public static int[,] TranspanentArray(int[,]array)
        {
            if(array.GetLength(0)!=array.GetLength(1))
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    int tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }
            return array;
        }
    }
}
