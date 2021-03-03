using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
        class Tree
        {

            public class Node
            {
                public int exampleData;
                public Node leftNode = null;
                public Node rightNode = null;
                public Node parent = null;
                

                public Node(int data)
                {
                    exampleData = data;
                }

            }

        public Node rootNode;

        public bool Add(int value)
        {
            Node before = null, after = this.rootNode;

            while (after != null)
            {
                before = after;
                if (value < after.exampleData)
                    after = after.leftNode;
                else if (value > after.exampleData)
                    after = after.rightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node(value);

            if (this.rootNode == null)
                this.rootNode = newNode;
            else
            {
                if (value < before.exampleData)
                    before.leftNode = newNode;
                else
                    before.rightNode = newNode;
            }

            return true;
        }

        public void PrintInOrder(Node parent)
        {
            if (parent != null)
            {
                PrintInOrder(parent.leftNode);
                Console.Write(parent.exampleData + " ");
                PrintInOrder(parent.rightNode);
            }
        }
        public void DeleteElem(int key)
        {
            Delete(rootNode, key);
        }

        Node Delete(Node root, int key)
        {
            if(root == null)
            {
                return root;
            }

            if (key < root.exampleData)
            {
                root.leftNode = Delete(root.leftNode, key);
            }

            else if (key > root.exampleData)
            {
                root.rightNode = Delete(root.rightNode, key);
            }

            else if (root.leftNode != null && root.rightNode != null)
            {
                root.exampleData = MinElem(root.rightNode);
                root.rightNode = Delete(root.rightNode, root.exampleData);
            }
            else
            {
                if (root.leftNode != null)
                {
                    root = root.leftNode;
                }
                else if (root.rightNode != null)
                {
                    root = root.rightNode;
                }
                else root = null;
            }
            return root;
        }

        public bool Find(int value)
            {
                Node currentNode = rootNode;

                while (currentNode != null)
                {
                    int compare = value - currentNode.exampleData;
                    if (compare == 0)
                        return true;

                    if (compare < 0)
                    {
                        currentNode = currentNode.leftNode;
                        continue;
                    }
                    currentNode = currentNode.rightNode;
                }

                return false;
            }

        private int MinElem(Node node)
        {
            while (node.leftNode != null)
            {
                node = node.leftNode;
            }

            return node.exampleData;
        }
    }
 }
