using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class BranchingStructures
    {
        //1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

        public static int GetResultOfMathOperation (int firstNum, int secondNum)
        {
            int result;
                if (firstNum > secondNum)
                    result = (firstNum + secondNum);
                else if (firstNum < secondNum)
                    result = (firstNum - secondNum);
                else
                    result= (firstNum * secondNum);

            return result;
        }


        //2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).

        public static string FindCoordinateSection (int x, int y)
        {
            string result;

                if (x == 0 || y == 0)
            { 
                    result = "Лежит на оси координат";
            }
                else if  (x< 0 && y> 0)
            {
                    result = "Четверть 1";
            }
                else if (x > 0 && y > 0)
            {
                    result = "Четверть 2";
            }
                else if (x< 0 && y< 0)
            {
                    result = "Четверть 3";
            }
                else
            {
                    result = "Четверть 4";
            }

            return result;
        }


        //3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.





        //4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.

        public static double[] DisplayNumbersInAscendingOrder(double a, double b, double c)
        {

            double D = (b * b) - (4 * a * c);
            double result1 = ((-b + Math.Sqrt(D)) / (2 * a));
            double result2 = ((-b - Math.Sqrt(D)) / (2 * a));
            {
                if(a==0)
                {
                    throw new DivideByZeroException();
                }

                if (D > 0)
                {
                    double[] result = new double[] {result1, result2};
                    return result;
                }
                else if (D < 0)
                {
                    double[] result = new double[0];
                    return result;
                }      
                else
                {
                    double[] result = new double[] { result1 };
                    return result;
                }
            }
        }

        //5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.

        static public string WriteNumbersAsWords(int num)
        {
            if(num>99 || num<10)
            {
                throw new ArgumentException();
            }

            int dividedNum = num / 10;
            int remainderOfDiv = num % 10;
            int x = num;
            string y = "";
            if (dividedNum != 1)
            {
                switch (dividedNum)
                {
                    case 2:
                        y += "Двадцать ";
                        break;
                    case 3:
                        y += "Тридцать ";
                        break;
                    case 4:
                        y += "Сорок ";
                        break;
                    case 5:
                        y += "Пятьдесят ";
                        break;
                    case 6:
                        y += "Шестьдесят ";
                        break;
                    case 7:
                        y += "Семьдесят ";
                        break;
                    case 8:
                        y += "Восемьдесят ";
                        break;
                    case 9:
                        y += "Девяносто ";
                        break;
                }
                switch (remainderOfDiv)
                {
                    case 1:
                        y += "один";
                        break;
                    case 2:
                        y += "два";
                        break;
                    case 3:
                        y += "три";
                        break;
                    case 4:
                        y += "четыре";
                        break;
                    case 5:
                        y += "пять";
                        break;
                    case 6:
                        y += "шесть";
                        break;
                    case 7:
                        y += "семь";
                        break;
                    case 8:
                        y += "восемь";
                        break;
                    case 9:
                        y += "девять";
                        break;
                }
            }
            else
            {
                switch (num)
                {
                    case 10:
                        y += "Десять";
                        break;
                    case 11:
                        y += "Одинадцать";
                        break;
                    case 12:
                        y += "Двенадцать";
                        break;
                    case 13:
                        y += "Тринадцать";
                        break;
                    case 14:
                        y += "Четырнадцать";
                        break;
                    case 15:
                        y += "Пятнадцать";
                        break;
                    case 16:
                        y += "Шестнадцать";
                        break;
                    case 17:
                        y += "Семнадцать";
                        break;
                    case 18:
                        y += "Восемнадцать";
                        break;
                    case 19:
                        y += "Девятнадцать";
                        break;
                }
            }
                return y;

        }
    }
}
