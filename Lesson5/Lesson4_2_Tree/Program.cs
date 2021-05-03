using System;

namespace Lesson4_2_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTree treeNode = new MyTree();

            treeNode.AddItem(8);
            treeNode.AddItem(25);
            treeNode.AddItem(4);
            treeNode.AddItem(15);

            var array = TreeHelper.GetTreeInLine(treeNode);

            treeNode.PrintTree();
        }
    }
}
