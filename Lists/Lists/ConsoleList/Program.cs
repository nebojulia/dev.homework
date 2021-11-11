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

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            LinkedList LL = new LinkedList(array);


            //1
            //LL.Add(0);
            //LL.WriteToConsole();

            //7
            //LL.CutNumElementsFromEnd(2);
            //LL.WriteToConsole();

            //2
            //LL.AddValueToStart(0);
            //LL.WriteToConsole();

            //3
            LL.AddValueByIndex(0, 2);
            LL.WriteToConsole();
        }
    }
}
