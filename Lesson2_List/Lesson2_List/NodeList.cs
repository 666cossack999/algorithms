using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_List
{
    class NodeList : ILinkedList
    {
        List<Node> nodes = new List<Node>();
        int size = 0;
        public NodeList()
        {

        }
        
        /// <summary>
        /// добавляем элемент в конец списка
        /// </summary>
        /// <param name="value">элемент</param>
        public void AddNode(int value)
        {

            var node = GetLastNode();

            if (node == null)
            {
                var newNode = new Node(null, value, null);
                nodes.Add(newNode);
                size++;
            }
            else
            {
                var newNode = new Node(node, value, null);
                node.NextNode = newNode;
                nodes.Add(newNode);
            }             

            

        }
        /// <summary>
        /// Ищет последнюю ноду в списке
        /// </summary>
        /// <returns>Last Node</returns>
        public Node GetLastNode()
        {

            foreach (var node in nodes)
            {
                if (node.NextNode == null)
                {
                    return node;
                }                
            }
            return null;
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
