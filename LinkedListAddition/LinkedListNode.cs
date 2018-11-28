using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAddition
{
    class LinkedListNode
    {
        int data;
        LinkedListNode next;

        public LinkedListNode() { }

        public LinkedListNode GetNextNode() {
            return next;
        }

        public int GetNodeData() {
            return data;
        }

        public void SetLinkedListNext(LinkedListNode linkedListNode) {
            next = linkedListNode;
        }

        public void SetLinkedListData(int data) {
            this.data = data;
        }
    }
}
