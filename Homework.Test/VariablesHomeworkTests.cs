using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    class VariablesHomeworkTests
    {
        //1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/B-A

        #region GetResultOfFormulaCalculationTests

        [TestCase(1d,2d,9d)]
        [TestCase(3d,5d,20d)]
        [TestCase(-1d,-2d,1d)]
        public void GetResultOfFormulaCalculationTests(double fNum, double sNum, double expected)
        {
            double actual = VariablesHomework.GetResultOfFormulaCalculation(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(1,1)]
        [TestCase(0,0)]
        [TestCase(-1,-1)]
        [TestCase(321,321)]
        [TestCase(608,608)]
        public void GetResultOfFormulaCalculationTests_WhenArgumentsEqual_ThenThrowArguementExeption(double fNum, double sNum)
        {
            Assert.Throws<ArgumentException>(() => VariablesHomework.GetResultOfFormulaCalculation(fNum, sNum));
        }
        #endregion

        //2. Пользователь вводит 2 строковых значения(A и B). Поменяйте содержимое переменных A и B местами.

        #region Swap
        //public void SwapTests(ref T fNum, ref T sNum, ref T expected)
        //{
        //    double actual = VariablesHomework.Swap(fNum, sNum);
        //
        //    Assert.AreEqual(actual, expected);
        //}
        #endregion

        //3.1 Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B.

        #region GetResultOfDivision
        [TestCase(2,1,2)]
        [TestCase(-10,2,-5)]
        [TestCase(20,-4,-5)]
        [TestCase(-10,-1,10)]
        [TestCase(21,7,3)]
        public void GetResultOfDivisionTests(int fNum, int sNum, int expected)
        {
            double actual = VariablesHomework.GetResultOfDivision(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(321, 0)]
        [TestCase(608, 0)]
        public void GetResultOfDivision_WhenDividerZero_ThenThrowDivideByZeroException(int fNum, int sNum)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHomework.GetResultOfDivision(fNum, sNum));
        }
        #endregion

        //3.2 Пользователь вводит 2 числа (A и B). Выведите в консоль остаток от деления A на B.

        #region GetRemainderOfTheDivision
        [TestCase(2,1,0)]
        [TestCase(10,3,1)]
        [TestCase(20,3,2)]
        [TestCase(-15,2,-1)]
        [TestCase(7,6,1)]
        public void GetRemainderOfTheDivisionTests(int fNum, int sNum, int expected)
        {
            double actual = VariablesHomework.GetRemainderOfTheDivision(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(321, 0)]
        [TestCase(608, 0)]
        public void GetRemainderOfTheDivision_WhenDividerZero_ThenThrowDivideByZeroException(int fNum, int sNum)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHomework.GetRemainderOfTheDivision(fNum, sNum));
        }

        #endregion

        //4.Пользователь вводит 3 не равных 0 числа (A, B и С).
        //Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.

        #region GetResultOfLineEquation
        [TestCase(10d,5d,2d,-0.3d)]
        [TestCase(24d,8d,4d,-(1d/6d))]
        [TestCase(15d,0d,5d,1d/3d)]
        [TestCase(-100d,14d,15d,-0.01d)]
        [TestCase(-36d,0d,-7d,7d/36d)]
        public void GetResultOfLineEquationTests(double firstNum, double secondNum, double thirdNum, double expected)
        {
            double actual = VariablesHomework.GetResultOfLineEquation(firstNum, secondNum, thirdNum);

            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(0d,0d,-7d)]
        public void GetResultOfLineEquation_WhenDividerZero_ThenThrowDivideByZeroException(double firstNum, double secondNum, double thirdNum)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHomework.GetResultOfLineEquation(firstNum, secondNum, thirdNum));
        }
        #endregion

        //5.Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
        //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.

        #region GetFormulaOfLineEquation
        [TestCase(1d, 2d, 3d, 4d, "y=1x+1")]
        [TestCase(-1d, -2d, -3d, -4d, "y=1x-1")]
        [TestCase(2d, 3d, -3d, 6d, "y=-0,6x+4,2")]
        [TestCase(17d, -5d, 0d, 12d, "y=-1x+12")]
        [TestCase(5d, 0d, 0d, -10d, "y=2x-10")]
        public void GetFormulaOfLineEquationTests(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = VariablesHomework.GetFormulaOfLineEquation(x1, y1, x2, y2);

            Assert.AreEqual(actual, expected);
        }
        [TestCase(1d, 2d, 1d, 4d)]
      
        public void GetFormulaOfLineEquation_WhenDividerZero_ThenThrowDivideByZeroException(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHomework.GetFormulaOfLineEquation(x1, y1, x2, y2));
        }
        #endregion
    }
}
