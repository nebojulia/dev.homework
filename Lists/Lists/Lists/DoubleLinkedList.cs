using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{

    public class DoubleLinkedList
    {
        public int Length { get; private set; }
        private Node _root;
        private Node _tail;
        public DoubleLinkedList()
        {
            _root = null;
            _tail = null;
            Length = 0;
        }
        public DoubleLinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
            Length = 1;
        }

        public DoubleLinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;
                _tail = null;

            }
            else
            {
                Node node = new Node(array[0]);
                Length = array.Length;

                _root = node;

                for (int i = 1; i < array.Length; i++)
                {
                    node.Next = new Node(array[i]);
                    node.Next.Previous = node;
                    node = node.Next;
                }
                _tail = node;
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

       public void IsIndexLeft(int index)
        {
            Node crnt;
            int numOfSteps;

            if (index <= Length / 2)
            {
                crnt = _root;
                numOfSteps = index;
            }
            else
            {
                crnt = _tail;
                numOfSteps = Length - index;
            }
        }


        //1. добавление значения в конец
        #region
        public void Add(int value)
        {
            if (_root != null)
            {
                _tail.Next = new Node(value);
                _tail.Next.Previous = _tail;
                _tail = _tail.Next;
                Length++;
            }
            else
            {
                _root = new Node(value);
                _tail = _root;
                Length = 1;
            }
        }

        #endregion

        //2. добавление значения в начало

        #region

        public void AddToStart(int value)
        {
            if(_root!=null)
            {
                Node tmp = _root;
                Node addNode = new Node(value);
                _root = addNode;
                addNode.Next = tmp;
                tmp.Previous = addNode;
            }
            else
            {
                _root = new Node(value);
                _tail = _root;
                Length = 1;
            }
        }

        #endregion

        //3. добавление значения по индексу
        #region

       // public void AddValueByIndex(int value, int index)         запуталась. пропишу метод поиска ноды по индексу
       // { 
       //     if (index < 0 || index > Length)
       //     {
       //         throw new IndexOutOfRangeException();
       //     }
       //
       //     Node addNode = new Node(value);
       //
       //     bool isIndexLeft = index <= Length / 2;
       //     Node crnt;
       //     int numOfSteps;
       //   
       //     if (isIndexLeft)
       //     {
       //         crnt = _root;
       //         numOfSteps = index;
       //         
       //         for (int i = 0; i < index; i++)
       //         {
       //             crnt = crnt.Next;
       //         }
       //     }
       //     else
       //     {
       //         crnt = _tail;
       //         numOfSteps = Length - index;
       //     }
       //
       //     crnt.Previous.Next = addNode;
       //     addNode.Previous = crnt.Previous.Next;
       //     crnt.Previous = addNode;
       //     addNode.Next = crnt;
       //
       // }

        #endregion

        //4. удаление из конца одного элемента

        #region

        public void RemoveLast()
        {
            RemoveByIndex(Length - 1);
        }

        #endregion

        //5. удаление из начала одного элемента

        #region

        public void RemoveFromStart()
        {
            RemoveByIndex(0);
        }

        #endregion

        //6. удаление по индексу одного элемента        

        #region
        public void RemoveByIndex(int index)
        {
            if(index<0 || index>Length)
            {
                throw new IndexOutOfRangeException();
            }

            bool isIndexLeft = index <= Length / 2;
            Node crnt;
            int numOfSteps;

            if (isIndexLeft)
            {
                crnt = _root;
                numOfSteps = index;
            }
            else
            {
                crnt = _tail;
                numOfSteps = Length - index;
            }

            for (int i = 1; i < numOfSteps; i++)
            {
                crnt = isIndexLeft ? crnt.Next : crnt.Previous;
            }

            if(crnt!=_root && crnt!=_tail)
            {
            crnt.Previous.Next = crnt.Next;
            crnt.Next.Previous = crnt.Previous;
            }
            else if(crnt==_root && crnt==_tail)
            {
                _root = null;
                _tail = null;
            }
            else if(crnt==_root)
            {
                _root = crnt.Next;
                crnt.Next.Previous = null;
            }
            else
            {
                _tail = crnt.Previous;
                crnt.Previous.Next = null;
            }
            Length--;
        }
    

        #endregion

        //7. удаление из конца N элементов

        #region

        public void CutNumElementsFromEnd(int num)
        {
            int length = Length;
            if(num>Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for(int i= length - num; i < length; i++)
                {
                    RemoveLast();
                }
            }
        }

        #endregion

        //8. удаление из начала N элементов

        #region

        public void CutNumElementsFromStart(int num)
        {
            int length = Length;
            if (num > Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    RemoveFromStart();
                }
            }
        }
        #endregion

        //9. удаление по индексу N элементов

        #region

        public void DeleteNumElementsByIndex(int num, int index)   //в процессе
        {
           
           //if (num > Length)
           //{
           //    throw new ArgumentOutOfRangeException();
           //}                                                          как я это сделала? удаляет каждую 2ю ноду
           //else
           //{
           //    for (int i = index; i <= num; i++)
           //    {
           //        RemoveByIndex(i);
           //    }
           //}
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
            
        }

        #endregion

        //12. первый индекс по значению

        #region



        #endregion

        //13. изменение по индексу

        #region ChangeValueByIndex

        public void ChangeIndexValue(int index, int value)
        {
            
        }

        #endregion

        //14. реверс (123 -> 321)

        #region



        #endregion

        //15. поиск значения максимального элемента

        #region

        public void GetMaxValue()
        {

        }
        
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



        public void GetNodeByIndex()
        {

        }
    }
}

