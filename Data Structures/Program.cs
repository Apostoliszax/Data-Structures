using System;
using System.Text;
using System.Collections.Generic;

namespace Data_Structures
{
    class DataStructures
    {
        static void Main(string[] args)
        {
            MyLinkedList();
        }

        public static void MyLinkedList()
        {
            string[] cars =
                {"toyota" , "ford" , "tesla", "kia" };
            LinkedList<string> carsList = new LinkedList<string>(cars);

            Display(carsList, "The linked list values:");

            //add a value in the beginning of the linked list.
            carsList.AddFirst("ferrari");
            Display(carsList, "The new linked list is:");

            //First Node -> Last Node
            LinkedListNode<string> mark1 = carsList.First;
            carsList.RemoveFirst();
            carsList.AddLast(mark1);
            Display(carsList, "Move the first node to be the last node: ");

            
            carsList.RemoveLast();
            carsList.AddLast("Bmw");
            Display(carsList, "Now the last node is BMW:");

            mark1 = carsList.Last;
            carsList.RemoveLast();
            carsList.AddFirst(mark1);
            Display(carsList, "The last node is now the first node.");

            carsList.AddLast("ford");

            LinkedListNode<String> current = carsList.FindLast("ford");
            IndicateNode(current, "Indicate last occurance of 'ford' :");

            current = carsList.Find("tesla");

            carsList.AddBefore(current, "brand");
            carsList.AddBefore(current, "new");
            IndicateNode(current, "Add 'brand' and 'new' before 'tesla' :");



        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> previousNode = node.Previous;

            while (previousNode != null)
            {
                result.Insert(0, previousNode.Value + " ");
                previousNode = previousNode.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine(Environment.NewLine);            
        }
        
    }
}
