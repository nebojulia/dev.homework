using System;

namespace Homework.Lists
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private const int _minArrayLength = 10;
        private int[] _array;

        public ArrayList()
        {
            Length = 0;
            _array = new int[_minArrayLength];
        }


        //1. добавление значения в конец

        #region

        public void AddInEnd(int value)
        {

            if (Length == _array.Length)
            {
                UpArraySize();
            }
            _array[Length] = value;
            Length++;
        }

        #endregion

        //2. добавление значения в начало

        #region

        public void AddToBeggining(int value)
        {
            if (Length == _array.Length)
            {
                UpArraySize();
            }
            ShiftToRight();
            _array[0] = value;
            Length++;
        }

        #endregion

        //3. добавление значения по индексу
        #region

        public void AddByIndex(int value, int index)
        {
            if (Length == _array.Length)
            {
                UpArraySize();
            }

            for (int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[index] = value;
            Length++;
        }

        #endregion

        //4. удаление из конца одного элемента

        #region

        public void CutArrayEnd()
        {
            CutArraySize();
            Length--;
        }

        #endregion

        //5. удаление из начала одного элемента

        #region

        public void CutArrayStart()
        {
            CutArraySize();
            ShiftToLeft();
            Length--;
        }

        #endregion

        //6. удаление по индексу одного элемента

        #region

        public void CutByIndex(int index)
        {
            CutArraySize();

            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }

        #endregion

        //7. удаление из конца N элементов

        #region

        public void CutArrayEndByNumElement(int count)
        {
            CutArraySize();

            Length -= count;
        }

        #endregion

        //8. удаление из начала N элементов

        #region

        public void CutArrayStartByNumElement(int count)
        {
            for (int i = 0; i < count; i++)
            {
                CutArrayStart();
            }
        }
        #endregion

        //9. удаление по индексу N элементов

        #region

        public void CutSeveralElementsFromArrayByIndex(int count, int index)
        {
            CutArraySize();
            for (int i = index; i < index + count; i++)
            {
                ShiftToLeft(index);
            }
            Length -= count;
        }

        #endregion

        //10. вернуть длину

        #region

        //public int Length { get; private set; }

        #endregion

        //11. доступ по индексу

        #region

        //public int this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index > Length)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //
        //        return _array[index];
        //    }
        //    set
        //    {
        //        if (index < 0 || index > Length)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //
        //        _array[index] = value;
        //    }
        //}

        #endregion

        //12. первый индекс по значению

        #region

        public int GetIndexOfFirstMatchByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        //13. изменение по индексу

        #region



        #endregion

        //14. реверс (123 -> 321)

        #region

        #endregion

        //15. поиск значения максимального элемента

        #region

        #endregion

        //16. поиск значения минимального элемента

        #region

        #endregion

        //17. поиск индекс максимального элемента

        #region

        #endregion

        //18. поиск индекс минимального элемента

        #region

        #endregion

        //19. сортировка по возрастанию

        #region

        #endregion

        //20. сортировка по убыванию

        #region

        #endregion

        //21. удаление по значению первого (?вернуть индекс)

        #region

        #endregion

        //22. удаление по значению всех (?вернуть кол-во)

        #region

        #endregion

        //23. 3 конструктора (пустой, на основе одного элемента, на основе массива)

        #region

        #endregion

        //24. добавление списка (вашего самодельного) в конец

        #region

        #endregion

        //25. добавление списка в начало

        #region

        #endregion

        //26. добавление списка по индексу

        #region

        #endregion


        public void WriteToConsole()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        private void UpArraySize()
        {
            int[] tmpArray = new int[(int)(Length * 1.5)];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        private void CutArraySize()
        {
            if (Length <= (_array.Length / 2))
            {
                int[] tmpArray = new int[(int)(Length * 0.7)];
                for (int i = 0; i < Length; i++)
                {
                    tmpArray[i] = _array[i];
                }
                _array = tmpArray;
            }

        }

        private void ShiftToRight(int index = 0)
        {
            int tmp;

            for (int i = Length; i > index; i--)
            {
                tmp = _array[i];
                _array[i] = _array[i - 1];
                _array[i - 1] = tmp;
            }
        }

        private void ShiftToLeft(int index = 0)
        {
            int tmp;

            for (int i = index; i < Length; i++)
            {
                tmp = _array[i];
                _array[i] = _array[i + 1];
                _array[i + 1] = tmp;
            }
        }
    }
}
