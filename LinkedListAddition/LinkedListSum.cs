using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAddition
{
    static class LinkedListSum
    {
        public static int globalcarry = 0;
        public static LinkedListNode GetLinkedListSum(LinkedListNode firstList, LinkedListNode secondList, int carry) {
            Console.WriteLine();
            LinkedListNode next = new LinkedListNode();

            if (firstList == null && secondList == null) {
                return firstList;
            }

            if (firstList == null) return secondList;
            if (secondList == null) return firstList;

            next = GetLinkedListSum(firstList.GetNextNode(), secondList.GetNextNode(), globalcarry);

            if (firstList != null && secondList != null) {
                if (firstList.GetNodeData() > 9 || secondList.GetNodeData() > 9) {
                    Console.WriteLine("Only single digits are permitted!");
                    return null;
                }
                int sum = firstList.GetNodeData() + secondList.GetNodeData() + globalcarry;
                if (sum > 9)
                {
                    sum = sum % 10;
                    carry = 1;
                    globalcarry = carry;
                }
                else {
                    globalcarry = 0;
                    carry = 0;
                }
                LinkedListNode result = new LinkedListNode();
                result.SetLinkedListData(sum);
                result.SetLinkedListNext(next);
                return result;
            }

            return null;
        }
    }
}
