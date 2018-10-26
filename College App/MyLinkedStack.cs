using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App
{
    class MyLinkedStack : IStackADT
    {
        private DataStructure list;
        // default constructor that sets head of list to null
        public MyLinkedStack()
        {
            list = new DataStructure();
        }
        //adds value to list appropriately for a 
        public void push(int value) {
            list.addFirst(value);
        }

        //remove and return value from list 

        public int pop() {
           return list.removeFirst();
        }
        //returns true if the stack is empty 
        public Boolean isEmpty()
        {
            return true;
        }
        //returns number of items in stack 
       public int size()
        {
            return 6;
        }

        //override toString to display the stack
       public void toString()
        {
            
        }

        public bool isFull()
        {
            return true;
        }

        
    }
}
