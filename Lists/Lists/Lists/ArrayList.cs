using System;

namespace Lists
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private const int _minArrayLength= 10;
        private int[] _array;

        public ArrayList()
        {
            Length = 0;
            _array = new int[_minArrayLength];
        }

        public ArrayList(int element)
        {
            Length = 1;
            _array=new int[_minArrayLength];
            _array[0] = element;
        }

        public ArrayList(int[]array)
        {
            Length = array.Length;

            if(array.Length > _minArrayLength)
            {
                _array= new int[(int)(Length * 1.5)];
            }
            else
            {
                _array = new int[_minArrayLength];
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _array[index];
            }
            set
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }

                _array[index] = value;
            }
        }

        //1. добавление значения в конец

        #region

        public void AddInEnd(int value)
        {
            
            if(Length==_array.Length)
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
            
            for(int i=Length; i>index; i--)
            {
                _array[i] = _array[i-1];
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
            for(int i=0; i<count; i++)
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
            for(int i=index; i<index+count; i++)
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
            for(int i=0;i<Length;i++)
            {
                if(_array[i]==value)
                {
                    return i;
                }
            }
                return -1;
        }
        
        #endregion

        //13. изменение по индексу

        #region

        public int ChangeValueByIndex(int value, int index)
        {
            for(int i=0; i < Length; i++)
            {
                if(i==index)
                {
                    _array[i] = value;
                    return value;
                }
            }
            return -1;  // вопрос: как проверить не введет ли пользователь индекс >||<Length? нужно ли?
        }

        #endregion

        //14. реверс (123 -> 321)

        #region

        public void ReverseArrayList()
        {
            for(int i=0;i<Length/2;i++)
            {
                int tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }

        #endregion

        //15. поиск значения максимального элемента

        #region

        public int SearchMaxElement()
        {
            int max = _array[0];

            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
            #endregion

            //16. поиск значения минимального элемента

            #region

        public int SearchMinElement()
        {
            int min = _array[0];

            for(int i=1;i<_array.Length;i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        #endregion

        //17. поиск индекс максимального элемента

        #region
        public int SearchIndexOfMax()
        {
            int max = _array[0];
            int maxIndex = 0;

            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        #endregion

        //18. поиск индекс минимального элемента

        #region

        public int SearchIndexOfMin()
        {
            int min = _array[0];
            int minIndex = 0;

            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        #endregion

        //19. сортировка по возрастанию

        #region

        public int[] SortAscending(int[]_array)  //нужно ли возвращать?
        {
            for(int i=0;i<_array.Length;i++)
            {
                int indexOfMin = i;
                for(int j=i+1;j<_array.Length;j++)
                {
                    if(_array[indexOfMin]>_array[j])
                    {
                    indexOfMin = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[indexOfMin];
                _array[indexOfMin] = tmp;
            }
            return _array;
        }

        #endregion

        //20. сортировка по убыванию

        #region
        public int[] SortDescending(int[] _array)  //нужно ли возвращать?
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int indexOfMax = i;
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[indexOfMax] < _array[j])
                    {
                        indexOfMax = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[indexOfMax];
                _array[indexOfMax] = tmp;
            }
            return _array;
        }

        #endregion

        //21. удаление по значению первого (?вернуть индекс)

        #region

        public int DeleteFirstMatch(int value)
        {
            for(int i=0;i<Length;i++)
            {
                int index=0;

                if (_array[i]==value)
                {
                    index = i;
                    ShiftToLeft(index);
                    return index;
                }
            }
            return -1;
        }

        #endregion

        //22. удаление по значению всех (?вернуть кол-во)

        #region

        public int DeleteAllMatches(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {

                if (_array[i] == value)
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        //23. 3 конструктора (пустой, на основе одного элемента, на основе массива)

        #region

        #endregion // в начале

        //24. добавление списка (вашего самодельного) в конец

        #region

        public void AddListInEnd(ArrayList array)
        {
            for(int i=0; i < array.Length; i++)
            {
                _array[Length+i] = array[i];
            }
                Length+=array.Length;

        }

        #endregion

        //25. добавление списка в начало

        #region
                                                                   //не работаеееееет
        public void AddListInStart(ArrayList array)
        {
            ShiftToRight(array.Length);
            for(int i=0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
                Length+=array.Length;
        }

        #endregion

        //26. добавление списка по индексу

        #region

        // Loading...

        #endregion


        public void WriteToConsole()
        {
            for (int i= 0;i<Length;i++)
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
            if(Length<=(_array.Length/2))
            {
                int[] tmpArray = new int[(int)(Length * 0.7)];
                for (int i = 0; i < Length; i++)
                {
                    tmpArray[i] = _array[i];
                }
                _array = tmpArray;
            }

        }

        private void ShiftToRight(int index=0)
        {
            //int tmp;

            for(int i=Length; i > index; i--)
            {
                //tmp = _array[i];
                _array[i] = _array[i - 1];
               // _array[i - 1] = tmp;
            }
        }

        private void ShiftToLeft(int index=0)
        {
            int tmp;

            for (int i = index; i < Length; i++)
            {
                tmp = _array[i];
                _array[i] = _array[i+1];
                _array[i+1] = tmp;
            }
        }
    }
}
