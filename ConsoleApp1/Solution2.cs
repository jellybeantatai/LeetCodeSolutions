using Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode currentL1Node = l1;
            ListNode currentL2Node = l2;
            int carry = 0;

            int lengthOfL1 = LengthOfList(l1);
            int lengthOfL2 = LengthOfList(l2);

            if (lengthOfL1 > lengthOfL2)
            {
                for(int i = lengthOfL2+1; i<=lengthOfL1; i++)
                {
                    l2 = AddToEndOfList(l2, 0);
                }
            }
            else
            {
                for (int i = lengthOfL1 + 1; i <= lengthOfL2; i++)
                {
                    l1 = AddToEndOfList(l1, 0);
                }
            }

            while (currentL1Node != null && currentL2Node != null)
            {
                int sum = currentL1Node.val + currentL2Node.val + carry;
                if (sum > 9)
                {
                    carry = 1;
                    sum = sum % 10;
                }
                else
                {
                    carry = 0;
                }
                result = AddToEndOfList(result, sum);
                currentL1Node = currentL1Node.next;
                currentL2Node = currentL2Node.next;
            }


            if (currentL1Node == null && currentL2Node == null && carry != 0)
            {
                AddToEndOfList(result, carry);
            }
            return result;
        }

        public static ListNode AddToEndOfList(ListNode list,int val)
        {
            if(list == null)
            {
                ListNode newNode = new ListNode(val);
                newNode.next = null;
                list = newNode;
                return list;
            }
            if (list.next != null)
            {
                AddToEndOfList(list.next, val);
            }
            else
            {
                ListNode newNode = new ListNode(val);
                newNode.next = null;
                list.next = newNode;
            }
            return list;
        }

        public static int LengthOfList(ListNode l)
        {
            int counter=0;

            while (l != null)
            {
                l = l.next;
                counter++;
            }

            return counter;
        } 
    }
}
