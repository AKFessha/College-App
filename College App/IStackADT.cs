using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App
{
    //Implmenting the interface IStackADT
    //Awet Fessha 24/10/18

    interface IStackADT
    {

        //adds value to list appropriately for a 
        void push(int value);
        //remove and return value from list 
        int pop();
        //returns true if the stack is empty 
        Boolean isEmpty();
        // returns full if no more space
        Boolean isFull();
        //returns number of items in stack 
        int size();
        //override toString to display the stack
        void toString();
    }
}
