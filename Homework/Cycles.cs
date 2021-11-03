using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Cycles
    {
        //1.Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

        static public double ElevateNum (double fNum, double sNum)
        {
            if(fNum<0 || sNum<0)
            {
                throw new ArgumentException();
            }

            double result = 1;
            for (int i = 0; i < sNum; i++)
            {
                result *= fNum;
            }
            return result;
        }

        //2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        static public int[] GetNumbersDivisionOnNum(int num)
        {
            num = Math.Abs(num);

            if (num<-1000 || num>1000)
            {
                throw new ArgumentException();
            }

            int[] result = new int[1000 / num];

            for(int i=num; i<=1000; i+=num)
            {
                result[(i/num)-1] = i;
            }
            return result;
        }


        //3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

        public static int GetNumberOfNumsMoreThanSquareOfNum(int num)
        {
            int count = 0;

            for (int i = 1; i* i<num; i++)
            {
                count++;
            }
            return count;
        }

        //4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

        public static int GetBiggestDivider(int num)
        {
            int divider = 0;
            if(num>0)
            {
                for (int i = num - 1; i > 0; i--)
                {
                    divider = num % i;
                    if (divider == 0)
                    {
                        divider = i;
                        break;
                    }
                }
            }
            else
            {
                divider = Math.Abs(num);
            } 
                   return divider;
        }



        //5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
        //(Учтите, что при вводе B может оказаться меньше A).

       public static int GetSummOfNumbersDivSevenFromRange(int lBorder, int rBorder)
       {
           int result=0;
          
           if(lBorder>rBorder)
           {
                VariablesHomework.Swap(ref lBorder, ref rBorder);
           }
            for (int i= lBorder; i<=rBorder;i++)
            {
               if(i%7==0)
                {
                    result += i;
                }
            }
            return result;
       }

        //6. Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

        public static int GetFibonacciNumber(int num)
        {
            if(num<0 || num==0)
            {
                throw new ArgumentException();
            }

            int fNum = 0;
            int sNum = 1;
            int tmp=0;

            for (int i = 1; i < num; i++)
            {
                tmp = fNum + sNum;
                sNum = fNum;
                fNum = tmp;
            }
            return tmp;
            
        }

        //7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

        public static int GetBiggestDivOfTwoNumbersWithEuclidAlg(int fNum, int sNum)
        {
            fNum = Math.Abs(fNum);
            sNum = Math.Abs(sNum);
            if(fNum==0 || sNum==0)
            { 
                if(fNum==0)
                {
                    return sNum;
                }
                else
                {
                    return fNum;
                }
            }
            while (fNum != sNum)
            {
                if (fNum > sNum)
                {
                    fNum = fNum - sNum;
                }
                else
                {
                    sNum = sNum - fNum;
                }
            }
                return fNum;
        }

        //8. Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //Найдите число N методом половинного деления.

        public static double GetNumByHalfDivMethod(double num)
        {
            double lBorder = 0;
            double rBorder=num;
            double half = 0;
            while (num != half * half * half)
            {
                half = (lBorder + rBorder) / 2;
                if (num > half * half * half)
                {
                    lBorder = half;
                }
                else
                {
                    rBorder = half;
                }
            }
            return half;
        }



        //9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

        public static int CountOddDigit(int num)
        {
            num = Math.Abs(num);
            int count = 0;
            while (num != 0)
            {

                int tmp = num % 10;
                if (tmp % 2 == 1)
                {
                    count++;
                }
                num = num / 10;
            }
            return count;
        }


        //10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности
        //цифр заданного числа, например, задано число 123, вывести 321.

        public static int GetReversNumber(int num)
        {
            int result = 0;
            while (num != 0)
            {
                int tmp = num % 10;
                result = result * 10 + tmp;
                num = num / 10;
            }
            return result;
        }

    //11. Пользователь вводит целое положительное  число (N).
    //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 

        public static int[] GetNumsFromRangeIfSummOfEvenMoreThenSummOfOdd(int num) //Максим, привет) 
        {
            int len = 0;
            for(int i=1;i<=num; i++)
            {
                if(GetSummOfEvenDigit(i)>GetSummOfOddDigit(i))
                {
                    len++;
                }
            }
            int[] result = new int[len];
            int index = 0;

            for (int i = 1; i <= num; i++)
            {
                if (GetSummOfEvenDigit(i) > GetSummOfOddDigit(i))
                {
                    result[index]=i;
                    index++;
                }
            }
            return result;
        }

    //11.1. Подсчет суммы четных цифр числа

        public static int GetSummOfEvenDigit(int num)
        {
            int result = 0;
            num = Math.Abs(num);

            while(num!=0)
            {
                int tmp = num%10;
                if(tmp%2==0)
                {
                    result += tmp;
                }
                num = num / 10;
            }
            return result;
        }

        //11.2. Подсчет суммы нечетных цифр числа

        public static int GetSummOfOddDigit(int num)
        {
            int result = 0;
            num = Math.Abs(num);

            while (num != 0)
            {
                int tmp = num % 10;
                if (tmp % 2 == 1)
                {
                    result += tmp;
                }
                num = num / 10;
            }
            return result;
        }

        //12. Пользователь вводит 2 числа.
        //Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

        public static bool IsSameDigits(int fNum, int sNum)
        {
            bool result = false;
            fNum = Math.Abs(fNum);
            sNum = Math.Abs(sNum);

            if(fNum==0 && sNum==0)
            {
                result = true;
            }

            while (fNum != 0)
            {
                int tmp = sNum;

                while (tmp != 0)
                {
                    if (fNum % 10 == tmp % 10)
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        tmp /= 10;
                    }
                }
                fNum /= 10;
                if (result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
