using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    class BranchingStructuresTests
    {
        //1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

        #region GetResultOfMathOperationTests

        [TestCase(5, 6, -1)]
        [TestCase(0, -5, -5)]
        [TestCase(5, 0, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 5, 25)]
        public void GetResultOfMathOperationTests(int fNum, int sNum, int expecting)
        {
            int actual = BranchingStructures.GetResultOfMathOperation(fNum, sNum);

            Assert.AreEqual(actual, expecting);
        }

        #endregion

        //2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).

        #region FindCoordinateSectionTests

        [TestCase(0, 10, "Лежит на оси координат")]
        [TestCase(-5, 5, "Четверть 1")]
        [TestCase(7, 7, "Четверть 2")]
        [TestCase(-9, -9, "Четверть 3")]
        [TestCase(11, -11, "Четверть 4")]
        public void FindCoordinateSectionTests(int fNum, int sNum, string expecting)
        {
            string actual = BranchingStructures.FindCoordinateSection(fNum, sNum);

            Assert.AreEqual(actual, expecting);
        }

        #endregion

        //3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

        #region SortNumbersAscendingTests

        [TestCase(1,5,4, new int[] { 1,4,5 })]
        [TestCase(-6,2,-3, new int[] { -6,-3,2 })]
        [TestCase(0,12,-5, new int[] { -5,0,12 })]
        [TestCase(0,0,0, new int[] { 0,0,0 })]
        public void SortNumbersAscendingTests(int fNum, int sNum, int tNum, int[] expected)
        {
            int [] actual = BranchingStructures.SortNumbersAscending(fNum, sNum, tNum);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        //4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.

        #region DisplayNumbersInAscendingOrderTests

        [TestCase(1d,2d,3d,new double[] { })]
 
        public void DisplayNumbersInAscendingOrderTests(double fNum, double sNum, double tNum, double[] expecting)
        {
            double[] actual = BranchingStructures.DisplayNumbersInAscendingOrder(fNum, sNum, tNum);

            Assert.AreEqual(actual, expecting);
        }

        [TestCase(0d,100d,2d)]
        public void DisplayNumbersInAscendingOrderTests_WhenDivideByZeroEx_ThenThrowDivideByZeroException(double fNum, double sNum, double tNum)
        {
            Assert.Throws<DivideByZeroException>(() => BranchingStructures.DisplayNumbersInAscendingOrder(fNum, sNum, tNum));
        }
        #endregion

        //5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.

        #region WriteNumbersAsWordsTests

        [TestCase(25,"Двадцать пять")]
        [TestCase(10,"Десять")]
        [TestCase(18,"Восемнадцать")]
        [TestCase(55,"Пятьдесят пять")]
        [TestCase(90,"Девяносто ")]
        public void WriteNumbersAsWordsTests(int Num, string expecting)
        {
            string actual = BranchingStructures.WriteNumbersAsWords(Num);

            Assert.AreEqual(actual, expecting);
        }

        [TestCase(8)]
        [TestCase(123)]
        public void WriteNumbersAsWordsTests_WhenNumBiggerOrSmaller_ThenThrowArgumentException(int Num)
        {
            Assert.Throws<ArgumentException>(() => BranchingStructures.WriteNumbersAsWords(Num));
        }
        #endregion

    }
}
