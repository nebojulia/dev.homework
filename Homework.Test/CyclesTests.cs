using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Homework.Test
{
    class CyclesTests
    {
        //1.Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

        #region ElevateNumTests
        [TestCase(2,2,4)]
        [TestCase(4,3,64)]
        [TestCase(1,54,1)]
        [TestCase(5,0,1)]
        [TestCase(0,5,0)]
        public void ElevateNumTests(double fNum, double sNum, double expected)
        {
            double actual = Cycles.ElevateNum(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(-4,3)]
        [TestCase(4,-3)]
        public void ElevateNumTests(double fNum, double sNum)
        {
            Assert.Throws<ArgumentException>(() => Cycles.ElevateNum(fNum, sNum));
        }

        #endregion

        //2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        #region GetNumbersDivisionOnNumTests

        [TestCase(-500, new int[] { 500,1000 })]
        [TestCase(500, new int[] { 500,1000 })]
        [TestCase(999, new int[] { 999 })]
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        public void GetNumbersDivisionOnNumTests(int num, int[]expected)
        {
            int[] actual = Cycles.GetNumbersDivisionOnNum(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(-1500)]
        [TestCase(1500)]
        public void GetNumbersDivisionOnNumTests_WhenNumLesOrMore(int num)
        {
            Assert.Throws<ArgumentException>(() => Cycles.GetNumbersDivisionOnNum(num));
        }

        #endregion

        //3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

        #region GetNumberOfNumsMoreThanSquareOfNumTests

        [TestCase(20, 4)]
        [TestCase(-20, 0)]
        [TestCase(0, 0)]
        public void GetNumberOfNumsMoreThanSquareOfNumTests(int num, int expected)
        {
            int actual = Cycles.GetNumberOfNumsMoreThanSquareOfNum(num);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        //4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

        #region GetBiggestDividerTests

        [TestCase(4,2)]
        [TestCase(100,50)]
        [TestCase(-10,10)]
        [TestCase(0,0)]
        public void GetBiggestDividerTests(int num, int expected)
        {
            int actual=Cycles.GetBiggestDivider(num);

            Assert.AreEqual(actual, expected);
        }
        #endregion

        //5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
        //(Учтите, что при вводе B может оказаться меньше A).

        #region GetSummOfNumbersDivSevenFromRangeTests

        [TestCase(14,21,35)]
        [TestCase(0,10,7)]
        [TestCase(-25,10,-35)]
        [TestCase(7,7,7)]
        public void GetSummOfNumbersDivSevenFromRangeTests(int lBorder, int rBorder, int expected)
        {
            int actual = Cycles.GetSummOfNumbersDivSevenFromRange(lBorder, rBorder);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        //6. Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

        #region GetFibonacciNumberTests

        [TestCase(4,2)]
        [TestCase(10,34)]
        public void GetFibonacciNumberTests(int num, int expected)
        {
            int actual=Cycles.GetFibonacciNumber(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(-15)]
        [TestCase(0)]
        public void GetFibonacciNumberTests_WhenNumLesThanZero_ThenThrowArgumentException(int num)
        {
            Assert.Throws<ArgumentException>(() => Cycles.GetFibonacciNumber(num));
        }
        #endregion

        //7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

        #region GetBiggestDivOfTwoNumbersWithEuclidAlgTests

        [TestCase(180,150,30)]
        [TestCase(-180,150,30)]
        [TestCase(0,150,150)]
        [TestCase(0,0,0)]
        [TestCase(10,-10, 10)]
        public void GetBiggestDivOfTwoNumbersWithEuclidAlgTests(int fNum, int sNum, int expected)
        {
            int actual = Cycles.GetBiggestDivOfTwoNumbersWithEuclidAlg(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        //8. Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //Найдите число N методом половинного деления.

        #region GetNumByHalfDivMethodTests

        [TestCase(125,5)]
        [TestCase(1,1)]
        public void GetNumByHalfDivMethodTests(double num, double expected)
        {
            double actual = Cycles.GetNumByHalfDivMethod(num);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

        #region CountOddDigitTests

        [TestCase(77,2)]
        [TestCase(952,2)]
        [TestCase(204,0)]
        [TestCase(333,3)]
        [TestCase(-521,2)]
        [TestCase(0,0)]
        public void CountOddDigitTests(int num, int expected)
        {
            int actual = Cycles.CountOddDigit(num);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности
        //цифр заданного числа, например, задано число 123, вывести 321.

        #region GetReversNumberTests

        [TestCase(123,321)]
        [TestCase(055,55)]
        [TestCase(1,1)]
        [TestCase(-52,-25)]
        [TestCase(0,0)]
        public void GetReversNumberTests(int num, int expected)
        {
            int actual = Cycles.GetReversNumber(num);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //11. Пользователь вводит целое положительное  число (N).
        //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 

        #region GetNumsFromRangeIfSummOfEvenMoreThenSummOfOddTests

        [TestCase(10, new[] {2,4,6,8})]
        public void GetNumsFromRangeIfSummOfEvenMoreThenSummOfOddTests(int num, int[] expected)
        {
            int[] actual = Cycles.GetNumsFromRangeIfSummOfEvenMoreThenSummOfOdd(num);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //11.1. Подсчет суммы четных цифр числа
        #region
        #endregion GetSummOfEvenDigitTests

        [TestCase(596,6)]
        [TestCase(2468,20)]
        [TestCase(-241,6)] //? прописала в методе abs или надо чтобы считал -2+4=2?
        [TestCase(0,0)] 
        public void GetSummOfEvenDigitTests(int num, int expected)
        {
            int actual = Cycles.GetSummOfEvenDigit(num);

            Assert.AreEqual(expected, actual);
        }

        //11.2. Подсчет суммы нечетных цифр числа

        #region GetSummOfOddDigitTests

        [TestCase(1111,4)]
        [TestCase(100,1)]
        [TestCase(-153,9)] // тот же вопрос
        [TestCase(0,0)]
        public void GetSummOfOddDigitTests(int num, int expected)
        {
            int actual = Cycles.GetSummOfOddDigit(num);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //12. Пользователь вводит 2 числа.
        //Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

        #region IsSameDigitsTests

        [TestCase(123,345,true)]
        [TestCase(121,345,false)]
        [TestCase(-51,345,true)] //тот же вопрос про abs
        [TestCase(0,3,false)]
        [TestCase(0,0, true)] 
        [TestCase(1,1, true)] 
        public void IsSameDigitsTests(int fNum, int sNum, bool expected)
        {
            bool actual = Cycles.IsSameDigits(fNum, sNum);

            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
