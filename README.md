Author: Giruba Beulah SE

# LinkedListAdditionOfSameSize
C# program to add two linked lists of same size where elements are inserted at the end of the lists

Logic
-----
1. If both the lists are null, return null
2. If both are non-null
   2.a Call the function recursively with the next nodes for both the first and second lists
       Let the result of this recursion be called 'Next'
   2.b When the recurison returns and that both the nodes are non-null,
       2.b.1 Compute sum as Sum = firstNodeData + SecondNodeData + carry (Carry should be intialized to zero initially)
       [Please note that the problem is for Single digits stored in every node]
       Store carry if Sum > 9
       2.b.2 Create a result node with this sum and set the Next as the next node of result
3. If there was any carry, create a node for it and append the sum list created thus far.
