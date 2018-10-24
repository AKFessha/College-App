using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App
{
    //Implementing the interface IStackADT
    //Awet Fessha 24/10/18
    

    class MyStack : IStackADT
    {
        IntArrayList list;
        //Constructor
        public MyStack()
        {
            IntArrayList list = new IntArrayList();
        }
        //adds value to list appropriately for a 
        public void push(int value)
        {
            list.addItem(value); 
        }

        //returns true if the stack is empty 
        public bool isEmpty()
        {
            return list.isEmpty();
        }

        // returns full if no more space
        public bool isFull()
        {
            return list.isFull();
        }

        //remove and return value from list 
        public int pop()
        {
           return list.Remove();
        }

        //returns number of items in stack 
        public int size()
        {
            return list.size();
        }

        //override toString to display the stack
        public void toString()
        {
            list.display();
        }
    }
}
