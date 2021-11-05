using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    class ArrayTests
    {
        //1. Найти минимальный элемент массива

        #region SearchMinTests

        [TestCase(new int[] { 2, 4, 1, 5 }, 1)]
        [TestCase(new int[] { 0, -5, 2, -2 }, -5)]
        [TestCase(new int[] { 3, 0, 0, 9 }, 0)]
        public void SearchMinTests(int[] array, int expected)
        {
            int actual = Array.SearchMin(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void SearchMinTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.SearchMin(array));
        }

        #endregion

        //2. Найти максимальный элемент массива

        #region SearchMaxTests

        [TestCase(new int[] { 2, 4, 1, 5 }, 5)]
        [TestCase(new int[] { 0, -5, 2, -2 }, 2)]
        [TestCase(new int[] { 3, 0, 0, 9 }, 9)]
        public void SearchMaxTests(int[] array, int expected)
        {
            int actual = Array.SearchMax(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void SearchMaxTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.SearchMax(array));
        }

        #endregion

        //3. Найти индекс минимального элемента массива

        #region SearchMinEllementIndexTests
        [TestCase(new int[] { 2, 4, 1, 5 }, 2)]
        [TestCase(new int[] { 0, -5, 2, -2 }, 1)]
        [TestCase(new int[] { 3, 0, 0, 9 }, 1)]
        public void SearchMinEllementIndexTests(int[] array, int expected)
        {
            int actual = Array.SearchMinEllementIndex(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void SearchMinEllementIndexTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.SearchMax(array));
        }

        #endregion

        //4. Найти индекс максимального элемента массива

        #region SearchMaxEllementIndexTests

        [TestCase(new int[] { 2, 4, 1, 5 }, 3)]
        [TestCase(new int[] { 0, -5, 2, -2 }, 2)]
        [TestCase(new int[] { 3, 0, 0, 9 }, 3)]
        public void SearchMaxEllementIndexTests(int[] array, int expected)
        {
            int actual = Array.SearchMaxEllementIndex(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void SearchMaxEllementIndexTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.SearchMax(array));
        }

        #endregion

        //5. Посчитать сумму элементов массива с нечетными индексами

        #region GetSummOfOddElementsTests

        [TestCase(new int[] { 2, 4, 1, 5 }, 9)]
        [TestCase(new int[] { 0, -5, 2, -2 }, -7)]
        [TestCase(new int[] { 3, 0, 0, 9 }, 9)]
        public void GetSummOfOddElementsTests(int[] array, int expected)
        {
            int actual = Array.GetSummOfOddElements(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetSummOfOddElementsTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.GetSummOfOddElements(array));
        }

        #endregion

        //6. Сделать реверс массива (массив в обратном направлении)

        #region ReverseTests

        [TestCase(new int[] { 2, 4, 1, 5 }, new int[] { 5, 1, 4, 2 })]
        [TestCase(new int[] { 0, -5, 2, -2 }, new int[] { -2, 2, -5, 0 })]
        [TestCase(new int[] { 3, 0, 0, 9 }, new int[] {9, 0, 0, 3 })]
        public void ReverseTests(int[] array, int [] expected)
        {
            int [] actual = Array.Reverse(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void ReverseTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.GetSummOfOddElements(array));
        }

        #endregion

        //7. Посчитать количество нечетных элементов массива

        #region CountOddElementsTests

        [TestCase(new int[] { 2, 4, 1, 5 }, 2)]
        [TestCase(new int[] { 0, -5, 2, -2 }, 1)]
        [TestCase(new int[] { 3, 0, 0, 9 }, 2)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]
        public void CountOddElementsTests(int[] array, int expected)
        {
            int actual = Array.CountOddElements(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void CountOddElementsTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.CountOddElements(array));
        }

        #endregion

        //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.

        #region ReversHalfsOfArrayTests

        [TestCase(new int[] { 2, 4, 1, 5 }, new int[] { 1, 5, 2, 4 })]
        [TestCase(new int[] { 0, -5, 2, -2 }, new int[] { 2, -2, 0, -5 })]
        [TestCase(new int[] { 3, 0, 0, 9 }, new int[] { 0, 9, 3, 0 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        public void ReversHalfsOfArrayTests(int[] array, int[] expected)
        {
            int[] actual = Array.ReversHalfsOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void ReversHalfsOfArrayTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.ReversHalfsOfArray(array));
        }


        #endregion

        //9. Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 

        #region SortArrayAscendingTests

        [TestCase(new int[] { 2, 4, 1, 5 }, new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 0, -5, 2, -2 }, new int[] { -5, -2, 0, 2 })]
        [TestCase(new int[] { 3, 0, 0, 9 }, new int[] { 0, 0, 3, 9 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        public void SortArrayAscendingTests(int[] array, int[] expected)
        {
            int[] actual = Array.SortArrayAscending(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SortArrayAscendingTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.SortArrayAscending(array));
        }

        #endregion

        //10. Отсортировать массив по убыванию одним из способов,
        //(отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))
        //Пузырек

        #region SortArrayDescendingTests

        [TestCase(new int[] { 2, 4, 1, 5 }, new int[] { 5, 4, 2, 1 })]
        [TestCase(new int[] { 0, -5, 2, -2 }, new int[] { 2, 0, -2, -5 })]
        [TestCase(new int[] { 3, 0, 0, 9 }, new int[] { 9, 3, 0, 0 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        public void SortArrayDescendingTests(int[] array, int[] expected)
        {
            int[] actual = Array.SortArrayDescending(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SortArrayDescendingTests_WhenArrayIsEmpty_ThenThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Array.SortArrayDescending(array));
        }

        #endregion


    }
}
