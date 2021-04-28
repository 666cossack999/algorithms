using System;

namespace Lesson2_List
{
    class Program
    {
        public static void Main(string[] args)
        {
            NodeList MyList = new NodeList();
            ///Добавляем 3 значения в конец списка
            MyList.AddNode(8);
            MyList.AddNode(11);
            MyList.AddNode(15);
            //получаем ссылку на объект нужной ноды
            Node myNode = MyList.FindNode(11);
            //вставляем значение после нужной ноды
            MyList.AddNodeAfter(myNode, 5);
            //Удаляем по значению
            Node myNode1 = MyList.FindNode(8);
            MyList.RemoveNode(myNode1);
            //Удаляем по индексу
            MyList.RemoveNode(1);


        }
    }
}
