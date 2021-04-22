using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_List
{
    class NodeList : ILinkedList
    {
        List<Node> nodes = new List<Node>();
      
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

        /// <summary>
        /// Ищет первую ноду в списке
        /// </summary>
        /// <returns>first Node</returns>
        public Node GetFirstNode()
        {

            foreach (var node in nodes)
            {
                if (node.PrevNode == null)
                {
                    return node;
                }
            }
            return null;
        }

        /// <summary>
        /// Ищет нужную ноду в списке
        /// </summary>
        /// <param name="value">значение</param>
        /// <returns>Ноду с нужным значением</returns>
       

        public void AddNodeAfter(Node node, int value)
        {
            
            var newNode = new Node(node, value, node.NextNode);
            node.NextNode.PrevNode = newNode;
            node.NextNode = newNode;

            nodes.Add(newNode);

        }

        public Node FindNode(int searchValue)
        {
            foreach (var node in nodes)
            {
                if (node.Value == searchValue)
                {
                    return node;
                }
            }
            return null;
        }

        public int GetCount()
        {
            return nodes.Count;
        }

        public void RemoveNode(int index)
        {
            nodes.RemoveAt(index);
            nodes[index - 1].NextNode = nodes[index]?.NextNode;
            nodes[index].PrevNode = nodes[index]?.PrevNode;
        }

        public void RemoveNode(Node node)
        {
            nodes.Remove(node);
            var prevNode = node.PrevNode;
            var nextNode = node.NextNode;

            if (prevNode != null)
            {
                prevNode.NextNode = nextNode;
            }
            
            if (nextNode != null)
            {
                nextNode.PrevNode = prevNode;
            }
            

        }
    }
}
