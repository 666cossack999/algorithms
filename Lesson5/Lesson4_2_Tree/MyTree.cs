using System;
using System.Collections.Generic;

namespace Lesson4_2_Tree
{
    public class MyTree : ITree
    {
        private TreeNode parent;
        private TreeNode node;
        

        public void AddItem(int value)
        {
            TreeNode tempNode = null;

            if (node == null)
            {
                node = GetNode(value, null);
                return;
            }

            tempNode = node;

            while (tempNode != null)
            {
                if (value > tempNode.Value)
                {
                    if (tempNode.RightChild != null)
                    {
                        tempNode = tempNode.RightChild;
                        continue;
                    }
                    else
                    {
                        tempNode.RightChild = GetNode(value, tempNode);
                        return;
                    }
                }
                else if (value < tempNode.Value)
                {
                    if (tempNode.LeftChild != null)
                    {
                        tempNode = tempNode.LeftChild;
                        continue;
                    }
                    else
                    {
                        tempNode.LeftChild = GetNode(value, tempNode);
                        return;
                    }
                }
                else
                {
                    throw new Exception("Wrong tree state");                  // Дерево построено неправильно
                }

            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            TreeNode current = node;
            parent = null;
            while (current != null)
            {
                if (current.Value > value)
                {
                    // Если искомое значение меньше, идем налево.
                    parent = current;
                    current = current.LeftChild;
                }
                else if (current.Value < value)
                {
                    // Если искомое значение больше, идем направо.
                    parent = current;
                    current = current.RightChild;
                }
                else
                {
                    // Если равны, то останавливаемся
                    break;
                }
            }
            return current;
        }

        public TreeNode GetRoot()
        {
            return node;
        }

        public void PrintTree()
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            PrintTree(x + 10, y, node);
        }

        public void PrintTree(int x, int y, TreeNode root, int delta = 0)
        {
            if (root != null)
            {
                if (delta == 0) delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write(root.Value);
                PrintTree(x - delta, y + 3, root.LeftChild, delta / 2);
                PrintTree(x + delta, y + 3, root.RightChild, delta / 2);
            }
        }

        public void RemoveItem(int value)
        {
            var current = GetNodeByValue(value);

            if (current == null) return;

            if (current.RightChild == null && current.LeftChild == null)
            {
                parent.RightChild = null;
                parent.LeftChild = null;
            }
            else if (current.LeftChild == null)
            {
                parent.LeftChild = current.RightChild;
            }
            else if (current.RightChild == null)
            {
                parent.LeftChild = current.LeftChild;
            }
            else if (current.RightChild != null && current.LeftChild != null)
            {
                if (parent.Value > value)
                {
                    parent.LeftChild = current.RightChild;
                    current.RightChild.LeftChild = current.LeftChild;
                }
                else
                {
                    parent.RightChild = current.RightChild;
                    current.RightChild.LeftChild = current.LeftChild;
                }
            }
        }

        public static TreeNode GetNode(int value, TreeNode parent)
        {
            var _node = new TreeNode
            {
                Value = value
            };
            return _node;
        }

        public TreeNode BfsSearchTree(int number)
        {
            var bufer = new Queue<TreeNode>();
            Console.WriteLine($"Поиск элемента {number} в дереве");
            bufer.Enqueue(node);

            Console.WriteLine($"Добавляем корень {node.Value} в начало очереди");

            while (bufer.Count != 0)
            {
                var root = bufer.Dequeue();
                Console.WriteLine($"Достаём элемент {root.Value} из начала очереди");
                if (root != null)
                {
                    Console.WriteLine($"Сравниваем с {number}");
                    if (root.Value == number)
                    {
                        Console.WriteLine("Нашёл!!!");
                        return root;
                    }    
                        

                    Console.WriteLine($"Удаляем элемент {root.Value} из стэка");
                    if (root.LeftChild != null)
                    {
                        Console.WriteLine($"Добавляем в стек левый элемент {root.LeftChild.Value}");
                        bufer.Enqueue(root.LeftChild);
                    }
                    if (root.RightChild != null)
                    {
                        bufer.Enqueue(root.RightChild);
                        Console.WriteLine($"Добавляем в стек правый элемент {root.RightChild.Value}");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Элемент не найден, возвращаю null ");
            return null;
        }
    }
}
