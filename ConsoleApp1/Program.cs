using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int i)
        {
            val = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + val + "| -> ");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int val)
        {
            if (next == null)
                next = new ListNode(val);
            else
                next.AddToEnd(val);
        }
    }

    public class MyList
    {
        public ListNode headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int val)
        {
            if(headNode == null)
            {
                headNode = new ListNode(val);
            }
            else
            {
                headNode.AddToEnd(val);
            }
        }

        public void AddToStart(int val)
        {
            if(headNode == null)
            {
                headNode = new ListNode(val);
            }
            else
            {
                var temp = headNode;
                headNode = new ListNode(val);
                headNode.next = temp;
            }
        }

        public void Print()
        {
            if(headNode!= null)
            {
                headNode.Print();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = new ListNode(1);
            //l1.AddToEnd(4);
            //l1.AddToEnd(3);

            ListNode l2 = new ListNode(9);
            l2.AddToEnd(9);
            //l2.AddToEnd(4);

            Solution2 sol = new Solution2();

            ListNode result = sol.AddTwoNumbers(l1, l2);

            result.Print();
        }
    }
}
