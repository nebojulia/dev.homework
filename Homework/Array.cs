using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Array
    {
        //1. Найти минимальный элемент массива

        public static int SearchMin(int[] array)
        {
            if(array.Length==0)
            {
                throw new ArgumentException();
            }
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        //2. Найти максимальный элемент массива

        public static int SearchMax(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //3. Найти индекс минимального элемента массива

        public static int SearchMinEllementIndex(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            int min = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        //4. Найти индекс максимального элемента массива
        public static int SearchMaxEllementIndex(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            int max = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        //5. Посчитать сумму элементов массива с нечетными индексами

        public static int GetSummOfOddElements(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            int result = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                result += array[i];
            }
            return result;
        }

        //6. Сделать реверс массива (массив в обратном направлении)

        public static int[] Reverse(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                VariablesHomework.Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
            return array;
        }

        //7. Посчитать количество нечетных элементов массива

        public static int CountOddElements(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            int count = 0;
            for(int i=0;i<array.Length;i++)
            {
                if(Math.Abs(array[i]%2)==1 && array[i]!=0)
                {
                    count++;
                }
            }
            return count;
        }


        //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.

        public static int[] ReversHalfsOfArray(int[]array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i=0;i<array.Length/2;i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length / 2 + i + (array.Length % 2)];
                array[array.Length / 2 + i + (array.Length % 2)] = tmp;
            }
            return array;
        }

        //9. Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 

        public static int[] SortArrayAscending(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length; i++) //запускаем цикл определения начала диапазона (смещаем индекс начального элемента)
            {
                int indexOfMin = i;
                for (int j = i + 1; j < array.Length; j++) //цикл сравнения элементов - поиск меньшего
                {
                    if (array[indexOfMin] > array[j])
                    {
                        indexOfMin = j; //присваивание меньшего найденного значения
                    }
                }
                int tmp = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = tmp;           //перемещаем меньший элемент в начало
            }
            return array;
        }
        //10. Отсортировать массив по убыванию одним из способов,
        //(отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))
        //Пузырек

        public static int[] SortArrayDescending(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }
    }
}
