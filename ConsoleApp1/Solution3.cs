using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Solution3
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1.val + l2.val >= 10)
            { // Carry Condition
                if (l1.next == null)
                { // Create memory if needed
                    l1.next = new ListNode(1);
                }
                else
                {
                    l1.next.val++;
                }
                l1.val += l2.val - 10;
            }
            else
            {
                l1.val += l2.val;
            }
            if (l1.next != null || l2.next != null)
            { // If there is still adding to be done...
                if (l2.next == null)
                { // Create memory if needed
                    l2.next = new ListNode(0);
                }
                if (l1.next == null)
                {
                    l1.next = new ListNode(0);
                }
                l1.next = this.AddTwoNumbers(l1.next, l2.next);
            }
            return l1;
        }
    }
}
