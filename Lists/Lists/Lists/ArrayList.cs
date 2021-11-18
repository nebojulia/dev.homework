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
        
        public void AddToStart(int value)
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
            if (index >= Length || index < 1)
            {
                throw new IndexOutOfRangeException();
            }

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

        public void DeleteLastElement()
        {
            if (Length > 0)
            {
                Length--;
                CutArraySize();
            }
            
        }

        #endregion

        //5. удаление из начала одного элемента

        #region

        public void DeleteFirstElement()
        {
            CutArraySize();
            ShiftToLeft();
            Length--;
        }

        #endregion

        //6. удаление по индексу одного элемента

        #region

        public void DeleteByIndex(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

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

        public void DeleteLastElements(int count)
        {
            if (count > Length)
            {
                throw new ArgumentException();
            }

            CutArraySize();

            Length -= count;
        }

        #endregion

        //8. удаление из начала N элементов

        #region

        public void DeleteElementsFromStart(int count)
        {
            if (count > Length)
            {
                throw new ArgumentException();
            }

            for (int i=0; i<count; i++)
            {
                DeleteFirstElement();
            }
        }
        #endregion

        //9. удаление по индексу N элементов

        #region

        public void DeleteElementsByIndex(int count, int index)
        {
            if (index + 1 + count > Length)
            {
                throw new ArgumentException();
            }

            CutArraySize();

            for(int i=index; i<index+count; i++)
            {
                ShiftToLeft(index);
            }
            
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

        #region ChangeValueByIndex
       
        public void ChangeValueByIndex(int value, int index)
        {
            if (index < Length)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (i == index)
                    {
                        _array[i] = value;
                    }
                } // 
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        //14. реверс (123 -> 321)

        #region

        public void Reverse()
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

        #region GetMaxElement

        public int GetMaxElement()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }

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

        #region GetMinElement

        public int GetMinElement()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }

            int min = _array[0];

            for(int i=1;i<Length;i++)
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

        #region GetIndexOfMax
        public int GetIndexOfMax()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }

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

        #region GetIndexOfMin

        public int GetIndexOfMin()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }

            int min = _array[0];
            int minIndex = 0;

            for (int i = 1; i < Length; i++)
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

        #region SortAscending

        public void SortAscending()  
        {
            for(int i=0;i<Length;i++)
            {
                int indexOfMin = i;
                for(int j=i+1;j<Length;j++)
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
        }

        #endregion

        //20. сортировка по убыванию

        #region SortDescending
        public void SortDescending() 
        {
            for (int i = 0; i < Length; i++)
            {
                int indexOfMax = i;
                for (int j = i + 1; j < Length; j++)
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
        }

        #endregion

        //21. удаление по значению первого (?вернуть индекс)

        #region

        public int DeleteFirstMatch(int value)
        {
            for(int i=0;i<Length;i++)
            {
                if (_array[i]==value)
                {
                    int index = i;
                    ShiftToLeft(index);
                    return index;
                }
            }
            return -1;
        }

        #endregion

        //22. удаление по значению всех (?вернуть кол-во)

        #region DeleteAllMatches

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
            Length -= count;
            return count;
        }

        #endregion

        //23. 3 конструктора (пустой, на основе одного элемента, на основе массива)

        #region
        // в начале
        #endregion

        //24. добавление списка (вашего самодельного) в конец

        #region AddListToEnd

        public void AddListToEnd(ArrayList array)
        {
            if (Length+array.Length == _array.Length)
            {
                UpArraySize();
            }

            for (int i=0; i < array.Length; i++)
            {
                _array[Length+i] = array[i];
            }
                Length+=array.Length;

        }

        #endregion

        //25. добавление списка в начало

        #region AddListToStart

        public void AddListToStart(ArrayList array)
        {
            for(int i=0; i < array.Length; i++)
            {
                Length++;
                ShiftToRight(i);
                _array[i] = array[i];
            }
        }

        #endregion

        //26. добавление списка по индексу

        #region

        public void AddListByIndex(ArrayList arrayList, int index)
        {
            if(index<0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(Length+arrayList.Length>_array.Length)
            {
                UpArraySize();
            }

            for(int i=index;i<=arrayList.Length+index-1;i++)
            {
                ShiftToRight(index);
                Length++;
            }

            for(int i=0;i<arrayList.Length;i++)
            {
                _array[index + i] = arrayList[i];
            }
        }

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
            if ((int)(Length * 0.7) > _minArrayLength && Length <= (_array.Length / 2))
            {
                int[] tmpArray = new int[(int)(Length * 0.7)];

                for (int i = 0; i < _array.Length; i++)
                {
                    tmpArray[i] = _array[i];
                }
                _array = tmpArray;
            }

        }

        private void ShiftToRight(int index=0)
        {
            for(int i=Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
        }

        private void ShiftToLeft(int index=0)
        {
            //int tmp;

            for (int i = index; i < Length; i++)
            {
                //tmp = _array[i];
                _array[i] = _array[i+1];
                //_array[i+1] = tmp;
            }
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if (arrayList._array[i] != _array[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
