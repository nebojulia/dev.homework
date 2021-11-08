using System;
using Lists;

namespace ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList WWW = new ArrayList();
            //WWW.AddInEnd(1);
            //WWW.AddInEnd(2);
            //WWW.AddInEnd(3);
           // WWW.AddInEnd(7);
           // WWW.AddInEnd(4);
           // WWW.AddInEnd(6);
           // WWW.AddInEnd(7);
           // WWW.AddInEnd(8);

            //Console.WriteLine(WWW.Length);

            //12
            //Console.WriteLine(WWW.GetIndexOfFirstMatchByValue(18));
            //Console.WriteLine(WWW.GetIndexOfFirstMatchByValue(3));

            //13
            //WWW.ChangeValueByIndex(111, -10);
            //WWW.WriteToConsole();

            //14
            //WWW.ReverseArrayList();
            //WWW.WriteToConsole();

            //16
            //WWW.SearchMinElement();
            //WWW.WriteToConsole();


            //17

            //int index=WWW.SearchIndexOfMax();
            //WWW.WriteToConsole();
            //Console.WriteLine(index);

            //Console.WriteLine(WWW.SearchIndexOfMax());

            //18
            //int count = WWW.DeleteAllMatches(7);
            //WWW.WriteToConsole();
            //Console.WriteLine(count);


            



            ArrayList AAA = new ArrayList();

            AAA.AddInEnd(1);
            AAA.AddInEnd(2);
            AAA.AddInEnd(3);

            ArrayList QQQ = new ArrayList();
            QQQ.AddInEnd(9);
            QQQ.AddInEnd(8);
            QQQ.AddInEnd(7);


            //24
            //QQQ.AddListInEnd(AAA);
            //QQQ.WriteToConsole();

            //25
           AAA.AddListInStart(QQQ);
           AAA.WriteToConsole();

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
