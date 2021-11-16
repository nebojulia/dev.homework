using System;
using Lists;

namespace ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(1);
            //linkedList.Add(2);
            //linkedList.Add(3);
            //linkedList.Add(4);
            //linkedList.Add(5);

            int[] array = new int[] { 1,2,3,4,5};
            DoubleLinkedList LL = new DoubleLinkedList(array);

            //1
            //LL.Add(777);
            //LL.WriteToConsole();

            //2
            //LL.AddToStart(777);
            //LL.WriteToConsole();

            //3
            LL.AddValueByIndex(777, 3);
            LL.WriteToConsole();
        }
    }
}
