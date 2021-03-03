using System;

namespace LnkdLst
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList exampleList = new LinkedList();

            exampleList.AddElement(1);
            exampleList.AddElement(2);
            exampleList.AddElement(3);
            exampleList.AddElement(4);
            exampleList.AddElement(5);
            exampleList.AddElement(6);

            exampleList.PrintElements();
            Console.WriteLine();

            exampleList.DeleteElement(exampleList.FirstElement);
            exampleList.PrintElements();
            Console.WriteLine();

            exampleList.DeleteElement(exampleList.LastElement);
            exampleList.PrintElements();
            Console.WriteLine();

            exampleList.ReverseElements();
            exampleList.PrintElements();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
