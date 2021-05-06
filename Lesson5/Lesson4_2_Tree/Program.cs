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
            treeNode.AddItem(20);
            treeNode.AddItem(10);
            treeNode.AddItem(32);
            treeNode.AddItem(2);
            treeNode.AddItem(14);
            treeNode.AddItem(22);
            treeNode.AddItem(56);

            var array = TreeHelper.GetTreeInLine(treeNode);


            treeNode.PrintTree();
            Console.WriteLine("\n");


            treeNode.BfsSearchTree(10);
        }
    }
}
