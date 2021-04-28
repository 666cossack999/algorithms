using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_List
{
    public class Node
    {

        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }


        public Node(Node prev, int value, Node next)
        {
            Value = value;
            NextNode = next;
            PrevNode = prev;

        }

    }
}
