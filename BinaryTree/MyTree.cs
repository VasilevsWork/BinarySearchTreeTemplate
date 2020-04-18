using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class MyTree
    {
        private class Node
        {
            // Хранимые данные
            public int data;
            // Родительский узел
            public Node parent;
            // Узел слева (меньше)
            public Node left = null;
            // Узел справа (больше)
            public Node right = null;
        }

        // Корневой элемент дерева.
        private Node root;

        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.data = value;

            if (root == null)
            {
                root = newNode;
                return;
            }

            AddRecursive(root, newNode);
        }

        private void AddRecursive(Node currentNode, Node newNode)
        {
            if (currentNode.data > newNode.data)
            {
                if (currentNode.left == null)
                {
                    currentNode.left = newNode;
                    newNode.parent = currentNode;
                    return;
                }

                AddRecursive(currentNode.left, newNode);
            }
            else
            {
                if (currentNode.right == null)
                {
                    currentNode.right = newNode;
                    newNode.parent = currentNode;
                    return;
                }

                AddRecursive(currentNode.right, newNode);
            }
        }
        
        public string Show()
        {
            string result = "";
            CLR(ref result);
            return result;
        }

        public void CLR(ref string s)
        {
            CLR(root, ref s);
        }

        /*
         * прямой обход (CLR - center, left, right)
         Аргументы метода:
         1. Node node - текущий "элемент дерева" (ref  передача по ссылке)       
         2. ref string s - строка, в которой накапливается результат (ref - передача по ссылке)
        */
        private void CLR(Node node, ref string s)
        {
            if (node != null)
            {
                s += node.data.ToString() + " "; // запомнить текущее значение
                CLR(node.left, ref s); // обойти левое поддерево
                CLR(node.right, ref s); // обойти правое поддерево
            }
        }

        // обратный обход (LCR - left, center, right)
        private void LCR(Node node, ref string s)
        {

        }

        // концевой обход (RCL -right, center, left)
        private void RCL(Node node, ref string s)
        {

        }

        // обход дерева в ширину (итерационно, используется очередь)
        private void Across(Node node, ref string s)
        {

        }

        bool Find(int value)
        {
            return false;
        }

        void Delete(int value)
        {

        }
    }
}
