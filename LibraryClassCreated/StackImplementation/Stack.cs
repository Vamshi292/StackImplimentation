using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    [Serializable]
    public class Stack
    {
        private List <int> stack = new List<int>();
        private int top = -1;

        public int Top
        {
            get { return top; }
        }
            

        public Stack()
        {

        }

        public int ? Push(int item)
        { 
            int ? PushedItem = null;
            stack.Add(item);            
            top++;
            PushedItem = stack[top];
            return PushedItem;
        }

        public int ? Pop()
        {
            int ? PoppedItem =null;
            if (top != -1)
            {
                PoppedItem = stack[top];
                stack.RemoveAt(top);
                top--;                
            }
            return PoppedItem;
            
        }

        public int Peek()
        {
            return stack[top];
        }

        public List<int> GetAllElements()
        {
            return stack;
        }
    }
}
