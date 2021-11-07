using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    class TwoDimensionalArrayTests
    {
        #region Mocks
        public static int[,] GetTwoDimensionalArrayMock(string arrayType)
        {
            switch (arrayType)
            {
                case "positive":
                    return new int[,] { { 5, 3, 6 }, { 12, 99, 8 }, { 11, 18, 23 } };
                case "negative":
                    return new int[,] { { -5, -3, -6 }, { -12, -99, -8 }, { -11, -18, -23 } };
                case "zero":
                    return new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                case "moreCols":
                    return new int[,] { { 5, -3, 6, 7 }, { -12, -99, 0, 13 }, { 11, 0, 23, -9 } };
                case "moreRows":
                    return new int[,] { { 5, -3, 6 }, { -12, -99, 0 }, { 11, 0, -23 }, { 7, 113, -999 } };
                case "lenghtLess":
                    return new int[,] { };
                default: //mixed
                    return new int[,] { { 5, -3, 6 }, { -12, -99, 0 }, { 11, 0, -23 } };
            }
        }

        public static int[,] GetFlipMatrixMock(string arrayType)
        {
            switch (arrayType)
            {
                case "positive":
                    return new int[,] { { 5, 12, 11 }, { 3, 99, 18 }, { 6, 8, 23 } };
                case "negative":
                    return new int[,] { { -5, -12, -11 }, { -3, -99, -18 }, { -6, -8, -23 } };
                case "zero":
                    return new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                case "moreCols":
                    return new int[,] { { 5, -3, 6, 7 }, { -12, -99, 0, 13 }, { 11, 0, 23, -9 } };
                case "moreRows":
                    return new int[,] { { 5, -3, 6 }, { -12, -99, 0 }, { 11, 0, -23 }, { 7, 113, -999 } };
                case "lenghtLess":
                    return new int[,] { };
                default: //mixed
                    return new int[,] { { 5, -12, 11 }, { -3, -99, 0 }, { 6, 0, -23 } };
            }
        }
        #endregion

        //1. Найти минимальный элемент массива

        #region SearchMinTest

        [TestCase("positive",3)]
        [TestCase("negative", -99)]
        [TestCase("zero", 0)]
        [TestCase("moreCols", -99)]
        [TestCase("moreRows", -999)]
        [TestCase("123",-99)]
        public void SearchMinTest(string type, int expected)
        {
            int actual = TwoDimensionalArray.SearchMin(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }
        [TestCase("lenghtLess")]
        public void SearchMinTest_WhenTwoDimensionalArrayCollOrRowIsEmpty_ThenThrowArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.SearchMin(GetTwoDimensionalArrayMock(type)));
        }

        #endregion

        //2. Найти максимальный элемент массива

        #region SearchMaxTest

        [TestCase("positive", 99)]
        [TestCase("negative", -3)]
        [TestCase("zero", 0)]
        [TestCase("moreCols", 23)]
        [TestCase("moreRows", 113)]
        [TestCase("123", 11)]
        public void SearchMaxTest(string type, int expected)
        {
            int actual = TwoDimensionalArray.SearchMax(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }
        [TestCase("lenghtLess")]
        public void SearchMaxTest_WhenTwoDimensionalArrayCollOrRowIsEmpty_ThenThrowArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.SearchMax(GetTwoDimensionalArrayMock(type)));
        }

        #endregion

        //3. Найти индекс минимального элемента массива

        #region SearchMinIndexTest

        [TestCase("positive", new int[] { 0, 1 })]
        [TestCase("negative", new int[] { 1, 1 })]
        [TestCase("zero", new int[] { 0, 0 })]
        [TestCase("moreCols", new int[] { 1, 1 })]
        [TestCase("moreRows", new int[] { 3, 2 })]
        [TestCase("123", new int[] { 1, 1 })]
        public void SearchMinIndexTest(string type, int[] expected)
        {
            int[] actual = TwoDimensionalArray.SearchMinIndex(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void SearchMinIndexTest_WhenTwoDimensionalArrayCollOrRowIsEmpty_ThenThrowArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.SearchMinIndex(GetTwoDimensionalArrayMock(type)));
        }

        #endregion

        //4. Найти индекс максимального элемента массива

        #region SearchMaxIndexTest

        [TestCase("positive", new int[] { 1, 1 })]
        [TestCase("negative", new int[] { 0, 1 })]
        [TestCase("zero", new int[] { 0, 0 })]
        [TestCase("moreCols", new int[] { 2, 2 })]
        [TestCase("moreRows", new int[] { 3, 1 })]
        [TestCase("123", new int[] { 2, 0 })]
        public void SearchMaxIndexTest(string type, int[] expected)
        {
            int[] actual = TwoDimensionalArray.SearchMaxIndex(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void SearchMaxIndexTest_WhenTwoDimensionalArrayCollOrRowIsEmpty_ThenThrowArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.SearchMaxIndex(GetTwoDimensionalArrayMock(type)));
        }

        #endregion

        //5. Найти количество элементов массива, которые больше всех своих соседей одновременно

        #region CountBiggerNeighborTest

        [TestCase("positive", 1)]
        [TestCase("negative", 1)]
        [TestCase("zero", 0)]                                   
        [TestCase("moreCols", 1)]
        [TestCase("moreRows", 2)]
        [TestCase("123", 1)]
        public void CountBiggerNeighborTest(string type, int expected)
        {
            int actual = TwoDimensionalArray.CountBiggerNeighbor(GetTwoDimensionalArrayMock(type));
        
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase("lenghtLess")]
        public void CountBiggerNeighborTest_WhenTwoDimensionalArrayCollOrRowIsEmpty_ThenThrowArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.CountBiggerNeighbor(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

        //6. Отразите массив относительно его главной диагонали

        #region TranspanentArrayTest

        [TestCase("positive", "positive")]
        [TestCase("negative", "negative")]
        [TestCase("zero", "zero")]
        [TestCase("1", "1")]
        public void TranspanentArrayTest(string type, string expectedType)
        {
            int[,] actual = TwoDimensionalArray.TranspanentArray(GetTwoDimensionalArrayMock(type));
            int[,] expected = GetFlipMatrixMock(expectedType);

            Assert.AreEqual(expected, actual);
        }
        [TestCase("lenghtLess")]
        [TestCase("moreCols")]         //как подтягивается?
        [TestCase("moreRows")]         //как подтягивается?
        public void TranspanentArrayTest_WhenTwoDimensionalArrayCollOrRowIsEmpty_ThenThrowArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.TranspanentArray(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

    }
}
