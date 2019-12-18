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
            int multiplier1 = 1;
            int firstNumber = 0;
            while (currentNode1 != null)
            {
                firstNumber += (int)currentNode1.val * multiplier1;
                currentNode1 = currentNode1.next;
                multiplier1 *= 10;
            }

            ListNode currentNode2 = l2;
            int multiplier2 = 1;
            int secondNumber = 0;
            while (currentNode2 != null)
            {
                secondNumber += (int)currentNode2.val * multiplier2;
                currentNode2 = currentNode2.next;
                multiplier2 *= 10;
            }

            int sum = firstNumber + secondNumber;

            if (sum == 0)
            {
                return new ListNode(0);
            }

            int digitsInSum = NumberOfDigitsInANumber(sum);

            ListNode finalList = null;

            while (digitsInSum != 0)
            {
                int divisor = (int)(Math.Pow(10, (digitsInSum - 1)));
                finalList = AddToBeginningOfList(finalList, sum / divisor);
                sum = sum % divisor;
                digitsInSum--;
            }

            return finalList;
        }


        public static int NumberOfDigitsInANumber(int number)
        {
            int count = 0;
            int divisor = 1;
            while ((number / divisor) != 0)
            {
                count++;
                divisor *= 10;
            }

            return count;
        }

        public static ListNode AddToBeginningOfList(ListNode n, int val)
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
