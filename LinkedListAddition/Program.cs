using System;

namespace LinkedListAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List addition of same size!");
            Console.WriteLine("---------------------");

            try
            {
                LinkedList firstLinkedList = GetLinkedListFromInput();
                LinkedList secondLinkedList = GetLinkedListFromInput();
                LinkedList result = new LinkedList();
                if (isSameSize(firstLinkedList.GetHead(), secondLinkedList.GetHead()))
                {
                    LinkedListNode returnResult = LinkedListSum.GetLinkedListSum(firstLinkedList.GetHead(),
                        secondLinkedList.GetHead(), 0);
                    if (returnResult != null)
                    {
                        result.SetHead(GetResult(returnResult));
                        Console.WriteLine("---------------The resultant sum list --------");
                        result.PrintLinkedList(result.GetHead());
                    }
                }
                else
                {
                    Console.WriteLine("Only linked lists of same size are permitted!");
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static LinkedListNode GetResult(LinkedListNode linkedListNode) {
            if (LinkedListSum.globalcarry != 0) {
                LinkedListNode newResult = new LinkedListNode();
                newResult.SetLinkedListData(LinkedListSum.globalcarry);
                newResult.SetLinkedListNext(linkedListNode);
                return newResult;
            }
            return linkedListNode;
        }

        public static LinkedList GetLinkedListFromInput() {
            LinkedList linkedList = null;

            Console.WriteLine("Enter the number of elements of the Linked list");
            try {
                int noOfElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                linkedList = new LinkedList();
                for (int i = 0; i < noOfElements; i++) {
                    linkedList.InsertInList(int.Parse(elements[i]));
                }
                linkedList.PrintLinkedList(linkedList.GetHead());
            }
            catch (Exception exception) {
                Console.WriteLine("Exception thrown is "+exception.Message);
            }
            Console.WriteLine();
            return linkedList;
        }

        private static bool isSameSize(LinkedListNode linkedListNode1, LinkedListNode linkedListNode2) {
            if (linkedListNode1 == null && linkedListNode2 == null) {
                return true;
            }
            if (linkedListNode1 == null || linkedListNode2 == null) {
                return false;
            }
            return isSameSize(linkedListNode1.GetNextNode(), linkedListNode2.GetNextNode());
        }
    }
}
