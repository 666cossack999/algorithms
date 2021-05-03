using Lesson4_2_Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace MyTreeTest
{
    [TestClass]
    public class MyTreeTest
    {
        static MyTree tree;
        static NodeInfo[] arrayTree;

        [ClassInitialize]
        public static void InitializeCurrentTest()
        {
            tree = new MyTree();

            tree.AddItem(8);
            tree.AddItem(25);
            tree.AddItem(4);
            tree.AddItem(15);

            arrayTree = TreeHelper.GetTreeInLine(tree);
        }

        [TestMethod]
        public void AllItemsAreNotNull()
        {
            
            //Проверка что все элементы коллекции созданы
            CollectionAssert.AllItemsAreNotNull(arrayTree, "Not null failed");
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            CollectionAssert.AllItemsAreUnique(arrayTree, "Uniqueness failed");
        }

        [TestMethod]
        public void AreEquivalent()
        {
            MyTree treeTest = new MyTree();

            treeTest.AddItem(8);
            treeTest.AddItem(25);
            treeTest.AddItem(4);
            treeTest.AddItem(15);

            var arrayTreeTest = TreeHelper.GetTreeInLine(tree);

            CollectionAssert.AreEquivalent(arrayTree, arrayTreeTest);
        }
    }
}
