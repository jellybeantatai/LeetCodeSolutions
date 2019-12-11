using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Solution1
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currentNode1 = l1;
            long multiplier1 = 1;
            long firstNumber = 0;
            while (currentNode1 != null)
            {
                firstNumber += (long)currentNode1.val * multiplier1;
                currentNode1 = currentNode1.next;
                multiplier1 *= 10;
            }

            ListNode currentNode2 = l2;
            long multiplier2 = 1;
            long secondNumber = 0;
            while (currentNode2 != null)
            {
                secondNumber += (long)currentNode2.val * multiplier2;
                currentNode2 = currentNode2.next;
                multiplier2 *= 10;
            }

            long sum = firstNumber + secondNumber;

            if (sum == 0)
            {
                return new ListNode(0);
            }

            long digitsInSum = NumberOfDigitsInANumber(sum);

            ListNode finalList = null;

            while (digitsInSum != 0)
            {
                long divisor = (long)(Math.Pow(10, (digitsInSum - 1)));
                finalList = AddToBeginningOfList(finalList, sum / divisor);
                sum = sum % divisor;
                digitsInSum--;
            }

            return finalList;
        }


        public static long NumberOfDigitsInANumber(long number)
        {
            long count = 0;
            long divisor = 1;
            while ((number / divisor) != 0)
            {
                count++;
                divisor *= 10;
            }

            return count;
        }

        public static ListNode AddToBeginningOfList(ListNode n, long val)
        {
            ListNode temp = n;
            ListNode HeadNode;
            if (n == null)
            {
                HeadNode = new ListNode((int)val);
            }
            else
            {
                HeadNode = new ListNode((int)val);
                HeadNode.next = temp;
            }
            return HeadNode;
        }
    }

}
