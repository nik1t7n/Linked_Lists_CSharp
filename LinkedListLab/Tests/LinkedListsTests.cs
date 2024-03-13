
using LinkedListLab.Models;

namespace LinkedListLab.Tests
{
    public static class LinkedListsTests
    {
        public static void CheckCircleSingleLinkedList()
        {
            Node<int> firstNode = new(15);
            CircleSingleLinkedList<int> list = new(firstNode);

            Node<int> secondNode = new(16);
            list.AddAfterLastNode(secondNode);

            Node<int> zeroNode = new(14);
            list.AddBeforeFirstNode(zeroNode);

            Node<int> middleNode = new(777);
            list.AddAfterSpecifiedPosition(2, middleNode);

            list.Display();

            Console.WriteLine("\nDELETE LAST ELEMENT\n");

            list.RemoveLastNode();
            list.Display();

            Console.WriteLine("\nDELETE FIRST ELEMENT\n");

            list.RemoveFirstNode();
            list.Display();

            Console.WriteLine("\nADDING\n");

            list.AddAfterLastNode(new(17));
            list.AddAfterLastNode(new(18));
            list.Display();

            int pos = 2;
            Console.WriteLine($"\nDELETE AT SPECIFIC POSITION ({pos})\n");

            list.RemoveNodeAtSpecificPosition(pos);
            list.Display();

            Console.WriteLine("\nSEARCH BY VALUE\n");

            int value = 777;
            Console.WriteLine($"Position of {value}: {list.SearchByValue(777)}");
        }

        public static void CheckDoubleLinkedList()
        {
            Node<int> firstNode = new(15);
            DoubleLinkedList<int> list = new(firstNode);

            Node<int> secondNode = new(16);
            list.AddAfterLastNode(secondNode);

            Node<int> zeroNode = new(14);
            list.AddBeforeFirstNode(zeroNode);

            Node<int> middleNode = new(777);
            list.AddAfterSpecifiedPosition(2, middleNode);

            list.Display();

            Console.WriteLine("\nDELETE LAST ELEMENT\n");

            list.RemoveLastNode();
            list.Display();

            Console.WriteLine("\nDELETE FIRST ELEMENT\n");

            list.RemoveFirstNode();
            list.Display();

            Console.WriteLine("\nADDING\n");

            list.AddAfterLastNode(new(17));
            list.AddAfterLastNode(new(18));
            list.Display();

            int pos = 2;
            Console.WriteLine($"\nDELETE AT SPECIFIC POSITION ({pos})\n");

            list.RemoveNodeAtSpecificPosition(pos);
            list.Display();

            Console.WriteLine("\nSEARCH BY VALUE\n");

            int value = 777;
            Console.WriteLine($"Position of {value}: {list.SearchByValue(777)}");
        }

        public static void CheckSingleLinkedList()
        {
            Node<int> firstNode = new(15);
            SingleLinkedList<int> list = new(firstNode);

            Node<int> secondNode = new(16);
            list.AddAfterLastNode(secondNode);

            Node<int> zeroNode = new(14);
            list.AddBeforeFirstNode(zeroNode);

            Node<int> middleNode = new(777);
            list.AddAfterSpecifiedPosition(2, middleNode);

            list.Display();

            Console.WriteLine("\nDELETE LAST ELEMENT\n");

            list.RemoveLastNode();
            list.Display();

            Console.WriteLine("\nDELETE FIRST ELEMENT\n");

            list.RemoveFirstNode();
            list.Display();

            Console.WriteLine("\nADDING\n");

            list.AddAfterLastNode(new(17));
            list.AddAfterLastNode(new(18));
            list.Display();

            Console.WriteLine("\nDELETE AT SPECIFIC POSITION\n");

            list.RemoveNodeAtSpecificPosition(2);
            list.Display();

            Console.WriteLine("\nSEARCH BY VALUE\n");

            int value = 777;
            Console.WriteLine($"Position of {value}: {list.SearchByValue(777)}");
        }
    }
}
