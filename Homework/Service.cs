using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Service
    { //Метод вывода одномерного массива
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        //Метод созданияя массива

        public static int[] CreateArray(int len)
        {
            Random rand = new Random();
            int[] array = new int[len];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101);
            }
            return array;
        }

        //Метод создания двумерного массива

        public static int[,] CreateTwoDimensionalArray(int row, int col)
        {
            int[,] array = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-100, 101);
                }
            }
            return array;
        }

        //Метод вывода двумерного массива

        public static void PrintTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
