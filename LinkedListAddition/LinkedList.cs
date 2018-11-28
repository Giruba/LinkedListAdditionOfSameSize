using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAddition
{
    class LinkedList
    {
        LinkedListNode head;

        public LinkedList() { }
        public LinkedListNode GetHead() {
            return head;
        }

        public void SetHead(LinkedListNode linkedListNode) {
            head = linkedListNode;
        }

        public void InsertInList(int element) {
            _InsertElement(element);
        }

        private void _InsertElement(int element) {

            if (head == null) {
                head = new LinkedListNode();
                head.SetLinkedListData(element);
                return;
            }
            LinkedListNode linkedListNode = head;
            while (linkedListNode != null && linkedListNode.GetNextNode() != null) {
                linkedListNode = linkedListNode.GetNextNode();
            }
            LinkedListNode node = new LinkedListNode();
            node.SetLinkedListData(element);
            linkedListNode.SetLinkedListNext(node);
            
            return;
        }

        public void PrintLinkedList(LinkedListNode linkedListNode) {
            Console.WriteLine();
            Console.WriteLine("---Printing the List---");
            if (linkedListNode == null){
                Console.WriteLine("Linkedlist is null! Nothing to print!");
            }
            else {
                while (linkedListNode != null) {
                    Console.Write(linkedListNode.GetNodeData()+"->");
                    linkedListNode = linkedListNode.GetNextNode();
                }
            }
            Console.WriteLine();
        }

    }
}
