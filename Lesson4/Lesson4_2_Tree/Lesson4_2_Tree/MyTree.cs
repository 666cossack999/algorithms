using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4_2_Tree
{
    class MyTree : ITree
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
            throw new NotImplementedException();
        }

        public TreeNode GetRoot()
        {
            throw new NotImplementedException();
        }

        public void PrintTree()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int value)
        {
            throw new NotImplementedException();
        }

        public static TreeNode GetNode(int value, TreeNode parent)
        {
            var _node = new TreeNode
            {
                Value = value
            };
            return _node;
        }
    }
}
