using System;
using Lists;

namespace ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList WWW = new ArrayList();
            WWW.AddInEnd(1);
            WWW.AddInEnd(2);
            WWW.AddInEnd(3);
            WWW.AddInEnd(3);
            WWW.AddInEnd(3);

            Console.WriteLine(WWW.Length);

           //ArrayList QQQ = new ArrayList();
           //
           //QQQ.AddInEnd(587);
           //QQQ.AddInEnd(2);
           //QQQ.AddInEnd(325);
           //QQQ.AddInEnd(64);
           //QQQ.AddInEnd(777);
           //QQQ.AddInEnd(54);
           //QQQ.AddInEnd(745);
           //QQQ.AddInEnd(725);
           //QQQ.AddInEnd(54);
           //QQQ.AddInEnd(45);
           //QQQ.AddInEnd(69);
           //QQQ.AddInEnd(11);
           //
           //QQQ.WriteToConsole();

            //2
            //QQQ.AddToBeggining(999);
            //QQQ.WriteToConsole();

            //3
            //QQQ.AddByIndex(111, 5);
            //QQQ.WriteToConsole();

            //4
            //QQQ.CutArrayEnd();
            //QQQ.WriteToConsole();

            //5
            //QQQ.CutArrayStart();
            //QQQ.WriteToConsole();

            //6
            //QQQ.CutByIndex(3);
            //QQQ.WriteToConsole();

            //7
            //QQQ.CutArrayEndByNumElement(3);
            //QQQ.WriteToConsole();

            //8
            //QQQ.CutArrayStartByNumElement(3);
            //QQQ.WriteToConsole();

            //9
            //QQQ.CutSeveralElementsFromArrayByIndex(2, 3);
            //QQQ.WriteToConsole();
        }
    }
}
