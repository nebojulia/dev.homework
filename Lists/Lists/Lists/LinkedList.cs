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
                                                                    //пока далеко не готово
            public void AddValueByIndex(int value, int index)
            {
            Node addNode = new Node(value);
                 _root = addNode;
                for(int i=0;i<=index;i++)
                {
                addNode = addNode.Next;
                }
            _root.Next = addNode;
            }

            #endregion

            //4. удаление из конца одного элемента

            #region



            #endregion

            //5. удаление из начала одного элемента

            #region



            #endregion

            //6. удаление по индексу одного элемента

            #region



            #endregion

            //7. удаление из конца N элементов

            #region

        public void CutNumElementsFromEnd(int num)
        {
            int length = GetLength();

            if(_root==null || num>length)
            {
                throw new IndexOutOfRangeException();
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


            #endregion

            //9. удаление по индексу N элементов

            #region



            #endregion

            //10. вернуть длину

            #region



            #endregion

            //11. доступ по индексу

            #region


            #endregion

            //12. первый индекс по значению

            #region



            #endregion

            //13. изменение по индексу

            #region ChangeValueByIndex



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
            //наверху
            #endregion // в начале

            //24. добавление списка (вашего самодельного) в конец

            #region



            #endregion

            //25. добавление списка в начало

            #region



            #endregion

            //26. добавление списка по индексу

            #region



            #endregion
   
    }
}
