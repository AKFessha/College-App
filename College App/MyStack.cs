using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App
{
    //Implemntaing the interface IStackADT
    //Awet Fessha 24/10/18
    

    class MyStack : IStackADT
    {
        public MyStack()
        {
            IntArrayList list = new IntArrayList();
        }
        //adds value to list appropriately for a 
        public void push(int value)
        {
            throw new NotImplementedException();
        }

        //returns true if the stack is empty 
        public bool isEmpty()
        {
            return true;
        }

        // returns full if no more space
        public bool isFull()
        {
            return false;
        }

        //remove and return value from list 
        public int pop()
        {
            throw new NotImplementedException();
        }

        //returns number of items in stack 
        public int size()
        {
            return 3;
        }

        //override toString to display the stack
        public string toString()
        {
            return "Hello";
        }
    }
}
