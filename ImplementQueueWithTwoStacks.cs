using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ImplementQueueWithTwoStacks
    {
        int[] stack1  = new int[7];
        int[] stack2 = new int[7];
        int topInsert = -1;
        int topDelete = -1;

        public ImplementQueueWithTwoStacks()
        {
        }

        private void push(int a,string stackName)
        {
            if(stackName == "stack1")
            {
                stack1[++topInsert] = a;
            }
            else
            {
                stack2[++topDelete] = a;
            }
        }

        private int pop(string stackName)
        {
            int poppedElement = 0;

            if(stackName == "stack2")
            {
                poppedElement = stack2[topDelete];
                topDelete--;
            }
            else
            {
                poppedElement = stack1[topInsert];
                topInsert--;
            }

            return poppedElement;
        }

        private void CopyAllElementsFromStack()
        {
            if(stack1.Length == 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            foreach (var ele in stack1.Where(c => c > 0))
            {
                int poppedElement = pop("stack1");
                push(poppedElement, "stack2");
            }
        }

        public void Insert(int a)
        {
            push(a,"stack1");
        }

        public int Delete()
        {
            if (stack2[0] == 0)
            {
                CopyAllElementsFromStack();
            }
            return pop("stack2");
        }

    }
}
