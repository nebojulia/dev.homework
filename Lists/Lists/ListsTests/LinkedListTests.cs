using System;
using NUnit.Framework;
using Lists;

namespace ListsTests
{
    class LinkedListTests
    {
        public class Tests
        {
            #region GetLengthTests

            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
            [TestCase(new int[] { }, 0)]
            public void GetLengthTest(int[] array, int expected)
            {
                LinkedList actualList = new LinkedList(array);
                int actual = actualList.GetLength();

                Assert.AreEqual(expected, actual);
            }

            #endregion

            //1. добавление значения в конец

            #region Add

            [TestCase(1, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 1 })]
            public void AddTest(int value, int[] array, int[] expectedArray)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.Add(value);
                Assert.AreEqual(expected, actual);
            }

            #endregion

            //2. добавление значения в начало

            #region AddValueToStart

            [TestCase(1, new int[] { 1, 2, 3, 4 }, new int[] { 1, 1, 2, 3, 4 })]
            public void AddValueToStartTest(int value, int[] array, int[] expectedArray)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.AddValueToStart(value);
                Assert.AreEqual(expected, actual);
            }

            #endregion

            //3. добавление значения по индексу
            #region AddByIndexTest

            [TestCase(1, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 1, 3, 4 })]
            public void AddValueByIndexTest(int value, int index, int[] array, int[] expectedArray)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.AddValueByIndex(index, value);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { 1, 2, 3 }, 3, 4)]
            public void AddValueByIndexTest_WhenIndexMoreThanLength_ShouldThrowsIndexOutOfRangeException(int[] array, int index, int value)
            {
                LinkedList actual = new LinkedList(array);

                Assert.Throws<IndexOutOfRangeException>(() => actual.AddValueByIndex(index, value));
            }

            #endregion

            //4. удаление из конца одного элемента

            #region DeleteLastElement

            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
            [TestCase(new int[] { 1 }, new int[] { })]
            public void DeleteLastTest(int[] array, int[] expectedArray)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.DeleteLast();
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { })]
            public void DeleteLastTest_WhenListIsEmpty_ShouldThrowsIndexOutOfRangeException(int[] array)
            {
                LinkedList actual = new LinkedList(array);

                Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteLast());
            }

            #endregion

            //5. удаление из начала одного элемента

            #region DeleteFromStart

            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
            [TestCase(new int[] { 1 }, new int[] { })]
            public void DeleteFromStartTest(int[] array, int[] expectedArray)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.DeleteFromStart();
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { })]
            public void DeleteFromStartTest_WhenListIsEmpty_ShouldThrowsIndexOutOfRangeException(int[] array)
            {
                LinkedList actual = new LinkedList(array);

                Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteFromStart());
            }

            #endregion

            //6. удаление по индексу одного элемента

            #region

            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 }, 0)]
            [TestCase(new int[] { 1 }, new int[] { }, 0)]
            [TestCase(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1 }, 2)]
            public void DeleteByIndexTest(int[] array, int[] expectedArray, int index)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.DeleteByIndex(index);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { }, 0)]
            public void DeleteByIndexTest_WhenListIsEmpty_ShouldThrowsIndexOutOfRangeException(int[] array, int index)
            {
                LinkedList actual = new LinkedList(array);

                Assert.Throws<IndexOutOfRangeException>(() => actual.DeleteByIndex(index));
            }

            #endregion

            //7. удаление из конца N элементов

            #region

            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 }, 1)]
            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, }, 2)]
            [TestCase(new int[] { 1 }, new int[] { }, 1)]
            [TestCase(new int[] { 1 }, new int[] { 1 }, 0)]
            [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, 0)]
            public void CutNumElementsFromEndTest(int[] array, int[] expectedArray, int count)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.CutNumElementsFromEnd(count);
                Assert.AreEqual(expected, actual);
            }

            #endregion

            //8. удаление из начала N элементов

            #region DeleteElementsFromStart

            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 }, 1)]
            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, }, 2)]
            [TestCase(new int[] { 1 }, new int[] { }, 1)]
            [TestCase(new int[] { 1 }, new int[] { 1 }, 0)]
            [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, 0)]
            public void DeleteNumElementsFromStartTest(int[] array, int[] expectedArray, int count)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.DeleteNumElementsFromStart(count);
                Assert.AreEqual(expected, actual);
            }

            #endregion

            //9. удаление по индексу N элементов

            #region

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 6, 7 }, 2, 3)]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 4, 5, 6, 7 }, 0, 3)]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4 }, 3, 3)]
            public void DeleteNumElementsByIndexTest(int[] array, int[] expectedArray, int index, int count)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList expected = new LinkedList(expectedArray);

                actual.DeleteNumElementsByIndex(index, count);
                Assert.AreEqual(expected, actual);
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

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, 5)]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, -1, -7)]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 1)]
            [TestCase(new int[] { 1, 1, 1, 1, 1 }, 0, 1)]
            [TestCase(new int[] { 2, 1, 1, 1, 1 }, 1, 1)]
            public void GetFirstIndexByValueTest(int[] array, int expected, int value)
            {
                LinkedList list = new LinkedList(array);
                int actual = list.GetFirstIndexByValue(value);

                Assert.AreEqual(expected, actual);
            }

            #endregion

            //13. изменение по индексу

            #region



            #endregion

            //14. реверс (123 -> 321)

            #region


            #endregion

            //15. поиск значения максимального элемента

            #region GetMaxElement

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 7)]
            [TestCase(new int[] { 1, 2, 3, 8, 5, 6, 7 }, 8)]
            [TestCase(new int[] { 10, 2, 3, 8, 5, 6, 7 }, 10)]
            [TestCase(new int[] { -10000 }, -10000)]
            public void GetMaxElementTest(int[] array, int expected)
            {
                LinkedList list = new LinkedList(array);
                int actual = list.GetMax();

                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { })]
            public void GetMaxElementTest_WhenRootIsNull_ShouldThrowsIndexOutOfRangeException(int[] array)
            {
                LinkedList actual = new LinkedList(array);
                Assert.Throws<IndexOutOfRangeException>(() => actual.GetMax());
            }

            #endregion

            //16. поиск значения минимального элемента

            #region

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1)]
            [TestCase(new int[] { 1, 2, 3, 8, 5, 6, 0 }, 0)]
            [TestCase(new int[] { 10, 2, 3, 8, 0, 6, 7 }, 0)]
            [TestCase(new int[] { -10000 }, -10000)]
            public void GetMinTest(int[] array, int expected)
            {
                LinkedList list = new LinkedList(array);
                int actual = list.GetMin();

                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { })]
            public void GetMinTest_WhenRootIsNull_ShouldThrowsIndexOutOfRangeException(int[] array)
            {
                LinkedList actual = new LinkedList(array);
                Assert.Throws<IndexOutOfRangeException>(() => actual.GetMin());
            }

            #endregion

            //17. поиск индекс максимального элемента

            #region

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 6)]
            [TestCase(new int[] { 1, 2, 3, 8, 5, 6, 0 }, 3)]
            [TestCase(new int[] { 10, 2, 3, 8, 0, 6, 7 }, 0)]
            [TestCase(new int[] { -10000 }, 0)]
            public void GetIndexOfMaxTest(int[] array, int expected)
            {
                LinkedList list = new LinkedList(array);
                int actual = list.GetIndexOfMax();

                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { })]
            public void GetIndexOfMaxTest_WhenRootIsNull_ShouldThrowsIndexOutOfRangeException(int[] array)
            {
                LinkedList actual = new LinkedList(array);
                Assert.Throws<IndexOutOfRangeException>(() => actual.GetIndexOfMax());
            }

            #endregion

            //18. поиск индекс минимального элемента

            #region

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 0)]
            [TestCase(new int[] { 1, 2, 3, 8, 5, 6, 0 }, 6)]
            [TestCase(new int[] { 10, 2, 3, 8, 0, 6, 7 }, 4)]
            [TestCase(new int[] { -10000 }, 0)]
            public void GetIndexOfMinTest(int[] array, int expected)
            {
                LinkedList list = new LinkedList(array);
                int actual = list.GetIndexOfMin();

                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { })]
            public void GetIndexOfMinTest_WhenRootIsNull_ShouldThrowsIndexOutOfRangeException(int[] array)
            {
                LinkedList actual = new LinkedList(array);
                Assert.Throws<IndexOutOfRangeException>(() => actual.GetIndexOfMin());
            }

            #endregion

            //19. сортировка по возрастанию

            #region SortAscending



            #endregion

            //20. сортировка по убыванию

            #region



            #endregion

            //21. удаление по значению первого (?вернуть индекс)

            #region

            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 6, 5)]
            [TestCase(new int[] { 1, 2, 3, 8, 5, 6, 0 }, 3, 2)]
            [TestCase(new int[] { 10, 2, 3, 8, 0, 6, 7 }, 10, 0)]
            [TestCase(new int[] { -10000 }, -10000, 0)]
            public void DeleteFirstEqualTest(int[] array, int value, int expected)
            {
                LinkedList list = new LinkedList(array);
                int actual = list.DeleteFirstEqual(value);

                Assert.AreEqual(expected, actual);
            }

            #endregion

            //22. удаление по значению всех (?вернуть кол-во)

            #region DeleteAllMatches

            [TestCase(new int[] { 1, 2, 1, 1, 2, 2, 1 }, 1, 4)]
            [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 1, 6)]
            [TestCase(new int[] { 2, 2, 2, 1, 1, 1, 1 }, 10, 0)]
            [TestCase(new int[] { 2, 2, 2, 1, 1, 1, 1 }, 1, 4)]
            [TestCase(new int[] { -10000 }, -10000, 1)]
            [TestCase(new int[] { 1, 1, 1, 1, 2 }, 2, 1)]
            public void DeleteAllEqualsTest(int[] array, int value, int expected) // int[] expectedList,
            {
                LinkedList list = new LinkedList(array);
                //LinkedList newList = new LinkedList(expectedList);
                int actual = list.DeleteAllEquals(value);

                Assert.AreEqual(expected, actual);
                //Assert.AreEqual(newList, list);
            }

            #endregion


            //24. добавление списка (вашего самодельного) в конец

            #region AddListToEnd

            [TestCase(new int[] { -2, -1, 0 }, new int[] { 1, 2, 3, 4 }, new int[] { -2, -1, 0, 1, 2, 3, 4 })]
            [TestCase(new int[] { }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { }, new int[] { 1, 2, 3, 4 })]
            public void AddLinkedListTest(int[] array, int[] sArray, int[] expectedArr)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList list = new LinkedList(sArray);
                LinkedList expected = new LinkedList(expectedArr);

                actual.AddLinkedList(list);
                Assert.AreEqual(expected, actual);
            }

            #endregion

            //25. добавление списка в начало

            #region AddListToStart

            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { -2, -1, 0 }, new int[] { -2, -1, 0, 1, 2, 3, 4 })]
            [TestCase(new int[] { }, new int[] { }, new int[] { })]
            [TestCase(new int[] { }, new int[] { -2, -1, 0 }, new int[] { -2, -1, 0 })]
            [TestCase(new int[] { -2, -1, 0 }, new int[] { }, new int[] { -2, -1, 0 })]
            public void AddFirstLinkedListTest(int[] array, int[] sArray, int[] expectedArr)
            {
                LinkedList actual = new LinkedList(array); // òîò â êîòîðûé äîáàâëÿåì
                LinkedList list = new LinkedList(sArray); // òîò ÊÎÒÎÐÛÉ äîáàâëÿåì
                LinkedList expected = new LinkedList(expectedArr); // ñ ÷åì ñðàâíèâàåì

                actual.AddFirstLinkedList(list);
                Assert.AreEqual(expected, actual);
            }

            #endregion

            //26. добавление списка по индексу

            #region AddListByIndex

            [TestCase(new int[] { -2, -1, 0 }, new int[] { 1, 2, 3, 4 }, new int[] { -2, 1, 2, 3, 4, -1, 0 }, 1)]
            [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { }, new int[] { 1, 2, 3, 4 }, 2)]
            public void AddLinkedListByIndexTest(int[] array, int[] sArray, int[] expectedArr, int index)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList list = new LinkedList(sArray);
                LinkedList expected = new LinkedList(expectedArr);

                actual.AddLinkedListByIndex(list, index);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { }, new int[] { 1, 2, 3, 4 }, 0)]
            [TestCase(new int[] { -2, -1, 0 }, new int[] { 1, 2, 3, 4 }, 100)]
            public void AddLinkedListByIndex_WhenRootIsNull_ShouldThrowIndexOutOfRangeException(int[] array, int[] sArray, int index)
            {
                LinkedList actual = new LinkedList(array);
                LinkedList list = new LinkedList(sArray);

                Assert.Throws<IndexOutOfRangeException>(() => actual.AddLinkedListByIndex(list, index));
            }

            #endregion
        }
    }
}
