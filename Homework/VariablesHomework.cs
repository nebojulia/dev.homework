using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class VariablesHomework
    {
        //1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/B-A
        public static double GetResultOfFormulaCalculation(double firstNum, double secondNum)
        {
            if(firstNum==secondNum)
            {
                throw new ArgumentException();
            }

            double result = ((5 * firstNum + secondNum * secondNum) / (secondNum - firstNum));
            return result;   
        }

        //2. Пользователь вводит 2 строковых значения(A и B). Поменяйте содержимое переменных A и B местами.

        public static void Swap <T>(ref T a, ref T b)
        {
            T tmp = a;
            a=b;
            b = tmp;
        }


        //3.1 Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B.
        public static int GetResultOfDivision(int firstNum, int secondNum)
        {
            if(secondNum==0)
            {
                throw new DivideByZeroException();
            }
            
            return firstNum / secondNum;   //то же значение что и запись "int result = firstNum / secondNum; return result;"
        }

        //3.2 Пользователь вводит 2 числа (A и B). Выведите в консоль остаток от деления A на B.
        public static int GetRemainderOfTheDivision(int firstNum, int secondNum)
        {
            if (secondNum == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNum % secondNum;
        }

        //4.Пользователь вводит 3 не равных 0 числа (A, B и С).
        //Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public static double GetResultOfLineEquation(double firstNum, double secondNum, double thirdNum)
        {
            if(firstNum==0)
            {
                throw new DivideByZeroException();
            }

            return (thirdNum - secondNum) / firstNum;
        }

        //5.Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
        //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.

        public static string GetFormulaOfLineEquation(double x1, double y1, double x2, double y2)
        {
            if(x1==x2)
            {
                throw new DivideByZeroException();
            }

            Double a = (y1 - y2) / (x1 - x2);
            Double b = y2 - a * x2;
            if(b>0)
            { 
                return $"y={a}x+{b}";  
            }
            else if(b<0)
            {
                return $"y={a}x{b}";  
            }
            else
            {
                return $"y={a}x";
            }
        }
    }
}
