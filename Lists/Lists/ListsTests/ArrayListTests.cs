using NUnit.Framework;
using System;
using Lists;

namespace ListsTests
{
    public class Tests
    {
        //1. добавление значения в конец

        #region AddInEndTests
        [TestCase(1, new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 1 })]
        [TestCase(1, new int[] { 2, 3, 4, 5, 2, 3, 4, 5, 9, 10 }, new int[] { 2, 3, 4, 5, 2, 3, 4, 5, 9, 10, 1 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        public void AddInEndTest(int value, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.AddInEnd(value);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //2. добавление значения в начало

        #region AddToStart

        [TestCase(1, new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 1 })]
        [TestCase(1, new int[] { 2, 3, 4, 5, 2, 3, 4, 5, 9, 10 }, new int[] { 2, 3, 4, 5, 2, 3, 4, 5, 9, 10, 1 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        public void AddToStartTest(int value, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.AddToStart(value);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //3. добавление значения по индексу
        #region AddByIndexTest

        [TestCase(1, 100, new int[] { 2, 3, 4, 5 }, new int[] { 2, 100, 3, 4, 5 })]
        [TestCase(3, 100, new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, 100, 5 })]
        public void AddByIndexTest(int index, int value, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 5, new int[] { 2, 3, 4, 5 })]
        [TestCase(0, 5, new int[] { 2, 3, 4, 5 })]
        public void AddByIndexTest_WhenIndexIsZeroOrMoreThenLength_ShouldThrowsIndexOutOfRangeException(int index, int value, int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddByIndex(index, value));
        }

        #endregion

        //4. удаление из конца одного элемента

        #region DeleteLastElement

        [TestCase(new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, })]
        [TestCase(new int[] { }, new int[] { })]
        public void DeleteLastElementTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.DeleteLastElement();
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //5. удаление из начала одного элемента

        #region DeleteFirstElement

        [TestCase(new int[] { 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { })]
        public void DeleteFirstElementTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.DeleteFirstElement();
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //6. удаление по индексу одного элемента

        #region

        [TestCase(0, new int[] { 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(3, new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4 })]
        [TestCase(1, new int[] { 2, 3, 4, 5 }, new int[] { 2, 4, 5 })]
        public void DeleteByIndexTest(int index, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { })]
        [TestCase(5, new int[] { 1, 2, 3 })]
        [TestCase(-1, new int[] { 1, 2, 3 })]
        public void DeleteByIndexTest_WhenIndexMoreThenLengthOrLessThenZero_ShouldThrowsIndexOutOfRangeException(int index, int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteByIndex(index));
        }

        #endregion

        //7. удаление из конца N элементов

        #region

        [TestCase(0, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2 })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        public void DeleteLastElementsTest(int countOfElements, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.DeleteLastElements(countOfElements);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //8. удаление из начала N элементов

        #region DeleteElementsFromStart

        [TestCase(0, new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(3, new int[] { 2, 3, 4, 5 }, new int[] { 5 })]
        [TestCase(1, new int[] { 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        public void DeleteElementsFromStartTest(int countOfElements, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.DeleteElementsFromStart(countOfElements);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 3, 4 }, 4)]
        public void DeleteElementsFromStartTest_WhenIndexMoreThenLength_ShouldThrowsArgumentException(int[] array, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.DeleteElementsFromStart(count));
        }

        #endregion

        //9. удаление по индексу N элементов

        #region

        [TestCase(0, 1, new int[] { 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(3, 2, new int[] { 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 3, 4, 7, 8 })]
        public void DeleteElementsByIndexTest(int index, int countOfElements, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.DeleteElementsByIndex(index, countOfElements);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 3, 4 }, 2, 1)]
        public void DeleteElementsByIndexTest_WhenIndexMoreThenLength_ShouldThrowsArgumentException(int[] array, int index, int countOfElements)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.DeleteElementsByIndex(index, countOfElements));
        }

        #endregion

        //10. вернуть длину

        #region

        #endregion

        //11. доступ по индексу

        #region



        #endregion

        //12. первый индекс по значению

        #region GetIndexOfFirstMatchByValue

        [TestCase(4, new int[] { 1, 2, 4, 6, 7 }, 2)]
        [TestCase(4, new int[] { 1, 2, 6, 7 }, -1)]
        public void GetIndexOfFirstMatchByValueTests(int value, int[] array, int expected)
        {
            ArrayList actualArr = new ArrayList(array);

            int actual = actualArr.GetIndexOfFirstMatchByValue(value);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //13. изменение по индексу

        #region



        #endregion

        //14. реверс (123 -> 321)

        #region

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        public void ReverseTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }

        #endregion

        //15. поиск значения максимального элемента

        #region GetMaxElement

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, 18)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetMaxElementTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.GetMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetMaxElementTest_WhenLengthIsZero_ShouldThrowsIndexOutOfRangeException(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.GetMaxElement());
        }

        #endregion

        //16. поиск значения минимального элемента

        #region

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, 1)]
        [TestCase(new int[] { 100, 2, 3, 18, 4 }, 2)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetMinElementTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.GetMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetMinElementTest_WhenLengthIsZero_ShouldThrowsIndexOutOfRangeException(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.GetMinElement());
        }

        #endregion

        //17. поиск индекс максимального элемента

        #region

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, 3)]
        [TestCase(new int[] { 100, 2, 3, 18, 4 }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        public void GetIndexOfMaxTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.GetIndexOfMax();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetIndexOfMaxTest_WhenLengthIsZero_ShouldThrowsIndexOutOfRangeException(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.GetIndexOfMax());
        }

        #endregion

        //18. поиск индекс минимального элемента

        #region

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, 0)]
        [TestCase(new int[] { 100, 2, 3, 18, 4 }, 1)]
        [TestCase(new int[] { 1 }, 0)]
        public void GetIndexOfMinTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.GetIndexOfMin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetIndexOfMinTest_WhenLengthIsZero_ShouldThrowsIndexOutOfRangeException(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.GetIndexOfMin());
        }

        #endregion

        //19. сортировка по возрастанию

        #region SortAscending

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, new int[] { 1, 2, 3, 4, 18 })]
        [TestCase(new int[] { -100, -2, -3, -18, -4 }, new int[] { -100, -18, -4, -3, -2 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortAscendingTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.SortAscending();

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //20. сортировка по убыванию

        #region

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, new int[] { 18, 4, 3, 2, 1 })]
        [TestCase(new int[] { -100, -2, -3, -18, -4 }, new int[] { -2, -3, -4, -18, -100 })]
        [TestCase(new int[] { -100, -2, -3, 7, -18, -4, }, new int[] { 7, -2, -3, -4, -18, -100 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortDescendingTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.SortDescending();

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //21. удаление по значению первого (?вернуть индекс)

        #region

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, 3, 18)]
        [TestCase(new int[] { 100, 2, 3, 18, 4 }, -1, 5)]
        [TestCase(new int[] { }, -1, 123)]
        public void DeleteFirstMatchTest(int[] array, int expected, int value)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.DeleteFirstMatch(value);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //22. удаление по значению всех (?вернуть кол-во)

        #region DeleteAllMatches

        [TestCase(new int[] { 1, 2, 3, 18, 4 }, 1, 18)]
        [TestCase(new int[] { 100, 2, 3, 18, 4 }, 0, 5)]
        [TestCase(new int[] { 1, 2, 2, 2, 1, 2, 2, 2, 2 }, 7, 2)]
        [TestCase(new int[] { }, 0, 123)]
        [TestCase(new int[] { 1, 2, 3, 3, 4 }, 1, 1)]
        public void DeleteAllMatchesTest(int[] array, int expected, int value)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.DeleteAllMatches(value);

            Assert.AreEqual(expected, actual);
        }

        #endregion


        //24. добавление списка (вашего самодельного) в конец

        #region AddListToEnd

        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { -1, -2, -3 }, new int[] { 1, 2, 3 }, new int[] { -1, -2, -3, 1, 2, 3 })]
        public void AddListToEndTest(int[] arrayList, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(arrayList); 
            ArrayList testArray = new ArrayList(array); 
            ArrayList expected = new ArrayList(expectedArray); 

            actual.AddListToEnd(testArray);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //25. добавление списка в начало

        #region AddListToStart

        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { -1, -2, -3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, -1, -2, -3 })]
        public void AddListToStartTest(int[] arrayList, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(arrayList); 
            ArrayList testArray = new ArrayList(array); 
            ArrayList expected = new ArrayList(expectedArray); 

            actual.AddListToStart(testArray);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        //26. добавление списка по индексу

        #region AddListByIndex

        [TestCase(new int[] { -1, -2, -3 }, new int[] { 1, 2, 3 }, new int[] { -1, 1, 2, 3, -2, -3 }, 1)]
        public void AddListByIndexTest(int[] arrayList, int[] array, int[] expectedArray, int index)
        {
            ArrayList actual = new ArrayList(arrayList); 
            ArrayList testArray = new ArrayList(array); 
            ArrayList expected = new ArrayList(expectedArray); 

            actual.AddListByIndex(testArray, index);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { }, new int[] { }, 1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, 1)]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, 1)]
        public void AddListByIndexTest_WhenOneOfTheArraysIsEmpty_ShouldThrowsIndexOutOfRangeException(int[] array, int[] exArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(exArray);

            Assert.Throws<IndexOutOfRangeException>(() => actual.AddListByIndex(expected, index));
        }

        #endregion
    }
}