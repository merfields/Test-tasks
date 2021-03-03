using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnkdLst
{
    class LinkedList
    {
        public class Node
        {
            public Node next;
            public object exampleData;
        }

        private Node rootElement = null;

        public Node FirstElement
        {
            get { return rootElement; }
        }

        public Node LastElement
        {
            get
            {
                Node current = rootElement;
                if (current == null)
                {
                    return null;
                }

                while (current.next != null)
                {
                    current = current.next;
                }
                return current;
            }
        }


        public void DeleteElement(Node nodeToDelete)
        {
            if (rootElement == nodeToDelete)
            {
                rootElement = nodeToDelete.next;
                nodeToDelete.next = null;
            }
            else
            {
                Node current = rootElement;

                while (current.next != null)
                {
                    if (current.next == nodeToDelete)
                    {
                        current.next = nodeToDelete.next;
                        nodeToDelete.next = null;
                        break;
                    }
                    current = current.next;
                }
            }
        }


        public void AddElement(object value)
        {
            Node newNode = new Node { exampleData = value };
            if (rootElement == null)
            {
                rootElement = newNode;
            }
            else LastElement.next = newNode;
        }

        public void PrintElements()
        {
            Node current = rootElement;

            while (current != null)
            {
                Console.Write(current.exampleData);
                current = current.next;
            }
        }

        public void ReverseElements()
        {
            Node prevNode = null;
            Node curNode = rootElement;
            Node nextNode = rootElement.next;

            while(nextNode != null)
            {
                curNode.next = prevNode;
                prevNode = curNode;
                curNode = nextNode;
                nextNode = curNode.next;
            }
            curNode.next = prevNode;
            rootElement = curNode;
        }


    }
}
