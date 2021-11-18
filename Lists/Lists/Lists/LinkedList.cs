using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList
    {
        private Node _root;

        public LinkedList()
        {
            _root = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
        }

        public LinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;
            }
            else
            {
                Node node = new Node(array[0]);
                _root = node;

                for (int i = 1; i < array.Length; i++)
                {
                    node.Next = new Node(array[i]);
                    node = node.Next;
                }
            }
        }
        public void WriteToConsole()
        {
            Node node = _root;
            while (node != null)
            {
                Console.Write($"{node.Value} ");
                node = node.Next;
            }

            Console.WriteLine();
        }

        public int GetLength()
        {
            Node tmp = _root;
            int count = 0;
            if(_root==null)
            {
                return 0;
            }
            while(tmp!=null)
            {
                count++;
                tmp = tmp.Next;
            }
            return count;
        }


        //1. добавление значения в конец
        #region
        public void Add(int value)
        {
            if (_root != null)
            {
                Node tmp = _root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(value);
            }
            else
            {
                _root = new Node(value);
            }
        }

            #endregion

            //2. добавление значения в начало

            #region

            public void AddValueToStart(int value)
            {
                Node tmp = _root;

                Node addNode = new Node(value);
                _root = addNode;
                addNode.Next = tmp;
            }

            #endregion

            //3. добавление значения по индексу
            #region
                                                                    
            public void AddValueByIndex(int value, int index)
            {
                if(index<0 || index>GetLength())
                {
                    throw new IndexOutOfRangeException();
                }
                
                Node addNode = new Node(value);
                Node tmp = _root;

                for(int i=0;i<index-1;i++)
                {
                    tmp=tmp.Next;
                }
                addNode.Next = tmp.Next;
                tmp.Next = addNode;
            }

        #endregion

        //4. удаление из конца одного элемента

        #region

        public void DeleteLast()
        {
            Node tmp = _root;
            int length = GetLength();

            if(length==1)
            {
                _root = null;
            }

            for(int i=0; i<length-2; i++)  //если -1 он типа next'ом запрыгивает в последнюю ноду? 
            {
                tmp = tmp.Next;
            }
            tmp.Next = null;
        }

            #endregion

            //5. удаление из начала одного элемента

            #region

        public void DeleteFromStart()
        {
            int length = GetLength();
            
            if (length == 1)
            {
                _root = null;
            }
            else
            {
                _root=_root.Next;
            }
        }

        #endregion

        //6. удаление по индексу одного элемента

        #region
        public void DeleteByIndex(int index)
        {
            Node tmp = _root;
            int length = GetLength();

            if(index>length ||index<0)
            {
                throw new IndexOutOfRangeException();
            }
            
            if(index==0)
            {
                _root = _root.Next;
            }

            for(int i=0; i<index-1;i++)
            {
                tmp = tmp.Next;
            }
            tmp.Next = tmp.Next.Next;
        }

        #endregion

        //7. удаление из конца N элементов

        #region

        public void CutNumElementsFromEnd(int num)
        {
            int length = GetLength();

            if(_root==null || num>length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(length==1)
            {
                _root = null; //?
            }

            Node tmp = _root;
            int cutLength = length - num;

            for(int i=0;i<cutLength-1;i++)
            {
                tmp = tmp.Next;
            }
            
            tmp.Next = null;
        }

        #endregion

        //8. удаление из начала N элементов

        #region

        public void DeleteNumElementsFromStart(int num)
        {
            int length = GetLength();

            if(num<0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(num==0)
            {
                return;
            }

            if(num>=length)
            {
                _root = null;
            }
            else
            {
                Node tmp = _root;
                for (int i = 0; i < num - 1; i++)
                {
                    tmp = tmp.Next;
                }
                _root = tmp.Next;
            }
        }
            #endregion

            //9. удаление по индексу N элементов

            #region
        
        public void DeleteNumElementsByIndex(int num, int index)   //в процессе
        {
            int length = GetLength();

            if(index>length || num<0)
            {
                throw new IndexOutOfRangeException();
            }
         // if(index==0 && num>=length)     //выдать пустой лист, если index=0 а num>=length
         // {
         //     _root.Next = null;
         // }

            Node tmp = _root;

            for(int i=0;i<index-1;i++)
            {
                tmp = tmp.Next;
            }

            Node tmp2 = _root;
            for(int i=0;i<index+num-1;i++)
            {
                tmp2 = tmp2.Next;
            }

            tmp.Next = tmp2.Next;
        }

        #endregion

        //10. вернуть длину

        #region

        //GetLength();

        #endregion

        //11. доступ по индексу

        #region

        public void GetIndex(int index)
        {
            Node tmp = _root;

            for(int i=0;i<index-1;i++)
            {
                tmp = tmp.Next;
            }
        }

        #endregion

        //12. первый индекс по значению

        #region

        public int GetFirstIndexByValue(int value)
        {
            Node tmp = _root;

            for (int i = 0; tmp != null; i++)
            {
                if (tmp.Value == value)
                {
                    return i;
                }
                tmp = tmp.Next;
            }
            return -1;
        }

        #endregion

        //13. изменение по индексу

        #region ChangeValueByIndex

        public void ChangeIndexValue(int index,int value)
        {
           int length = GetLength();

            if(index<0 || index>length)
            {
                throw new IndexOutOfRangeException();
            }

            Node tmp = _root;

            for (int i = 0; i < index - 1; i++)
            {
                tmp = tmp.Next;
            }
            tmp.Next.Value = value;
        }

        #endregion

        //14. реверс (123 -> 321)

        #region



        #endregion

        //15. поиск значения максимального элемента

        #region

        public int GetMax()
        {
            if (_root != null)
            {
                int max = _root.Value;
                Node tmp = _root;

                while (tmp != null)
                {
                    if (tmp.Value > max)
                    {
                        max = tmp.Value;
                    }
                    tmp = tmp.Next;
                }

                return max;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        #endregion

        //16. поиск значения минимального элемента

        #region

        public int GetMin()
        {
            if (_root != null)
            {
                int min = _root.Value;
                Node tmp = _root;

                while (tmp != null)
                {
                    if (tmp.Value < min)
                    {
                        min = tmp.Value;
                    }
                    tmp = tmp.Next;
                }

                return min;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        #endregion

        //17. поиск индекс максимального элемента

        #region

        public int GetIndexOfMax()
        {
            if (_root != null)
            {
                int min = _root.Value;
                int index = 0;
                int counter = 0;
                Node tmp = _root;

                while (tmp != null)
                {
                    if (tmp.Value > min)
                    {
                        min = tmp.Value;
                        index = counter;
                    }
                    tmp = tmp.Next;
                    counter++;
                }

                return index;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        #endregion

        //18. поиск индекс минимального элемента

        #region

        public int GetIndexOfMin()
        {
            if (_root != null)
            {
                int max = _root.Value;
                int index = 0;
                int counter = 0;
                Node tmp = _root;

                while (tmp != null)
                {
                    if (tmp.Value < max)
                    {
                        max = tmp.Value;
                        index = counter;
                    }
                    tmp = tmp.Next;
                    counter++;
                }

                return index;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        #endregion

        //19. сортировка по возрастанию

        #region



        #endregion

        //20. сортировка по убыванию

        #region


        #endregion

        //21. удаление по значению первого (?вернуть индекс)

        #region

        public int DeleteFirstEqual(int value)
        {
            int index = 0;

            if (_root != null)
            {
                Node tmp = _root;
                while (tmp != null)
                {
                    if (tmp.Value == value)
                    {
                        return index;
                    }
                    index++;
                    tmp = tmp.Next;
                }
            }
            return -1;
        }

        #endregion

        //22. удаление по значению всех (?вернуть кол-во)

        #region

        public int DeleteAllEquals(int value)
        {
            int count = 0;

            if (_root != null)
            {
                Node tmp = _root;
                while (tmp != null)
                {
                    while (tmp.Value == value)
                    {
                        if (tmp.Next == null)
                        {
                            _root = null;
                            count++;
                            return count;
                        }
                        tmp = tmp.Next;
                        count++;
                    }

                    if (tmp.Next != null)
                    {
                        if (tmp.Next.Value == value || tmp.Value == value)
                        {
                            count++;
                            if (tmp.Next.Next != null)
                            {
                                tmp.Next = tmp.Next.Next;
                            }
                            else
                            {
                                tmp.Next = null;
                            }
                        }
                    }
                    tmp = tmp.Next;
                }
            }
            return count;
        }

        #endregion

        //23. 3 конструктора (пустой, на основе одного элемента, на основе массива)

        #region
        //наверху
        #endregion

        //24. добавление списка (вашего самодельного) в конец

        #region
        public void AddLinkedList(LinkedList list)
        {
            if (_root != null)
            {
                Node tmp = _root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = list._root;
            }
            else
            {
                _root = list._root;
            }
        }

        #endregion

        //25. добавление списка в начало

        #region
        public void AddFirstLinkedList(LinkedList list)
        {
            if (list._root != null)
            {
                Node tmpList = list._root;
                while (tmpList.Next != null)
                {
                    tmpList = tmpList.Next;
                }
                tmpList.Next = _root;
                _root = list._root;
            }
        }

        #endregion

        //26. добавление списка по индексу

        #region
        public void AddLinkedListByIndex(LinkedList list, int index)
        {
            int len = GetLength();

            if (index > len - 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (_root == null)
            {
                _root = list._root;
            }
            else if (list._root != null && _root != null)
            {
                Node startList = list._root;
                Node endList = list._root;
                
                while (endList.Next != null)
                {
                    endList = endList.Next;
                }
                Node tmp = _root;

                for (int i = 0; i < index - 1; i++)
                {
                    tmp = tmp.Next;
                }

                Node tmpContinue = tmp.Next;
                tmp.Next = startList;
                endList.Next = tmpContinue;
            }
        }

        #endregion

        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;

            Node tmpRoot = _root;
            Node tmp = linkedList._root;

            if (tmpRoot == null && tmp == null)
            {
                return true;
            }

            while (tmpRoot != null || tmp != null)
            {
                if (tmpRoot.Value != tmp.Value)
                {
                    return false;
                }
                if ((tmpRoot.Next == null && tmp.Next != null)
                    || (tmpRoot.Next != null && tmp.Next == null))
                {
                    return false;
                }

                tmpRoot = tmpRoot.Next;
                tmp = tmp.Next;
            }
            return true;
        }
    }
}
