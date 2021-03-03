using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Tree exampleTree = new Tree();

            exampleTree.Add(12);
            exampleTree.Add(8);
            exampleTree.Add(4);
            exampleTree.Add(6);
            exampleTree.Add(5);
            exampleTree.Add(11);
            exampleTree.Add(22);
            exampleTree.Add(23);
            exampleTree.Add(21);


            exampleTree.PrintInOrder(exampleTree.rootNode);
            

            Console.WriteLine();

            exampleTree.DeleteElem(22);
            exampleTree.DeleteElem(6);

            exampleTree.PrintInOrder(exampleTree.rootNode);


            Console.WriteLine(exampleTree.Find(4));

            Console.ReadLine();
        }
    }
}
