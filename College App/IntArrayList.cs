using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App

{
    // Integer Array List Data Structure

    class IntArrayList
    {

        // number of values in the list
        private int count;

        // array used to store
        private int[] values;

        public IntArrayList()
        {
            //This constructor sets the capacity to 15
            values = new int[15];
            count = 0;
        }


        // This method returns true if the array is full.
        public bool isFull()
        {
            return values.Length == count;

        }
        // this method returns true if the array is empty, and returns false is the arry is not empty
        public bool isEmpty()
        {
            return count == 0;

        }


        // This method adds item to the list
        public void addItem(int value)
        {
            if (isFull())
            {
                throw new Exception("This list is full");
            }
            else
            {
                values[count++] = value;
            }
        }


        // Return and remove last item in the list
        public int Remove()
        {

            if (isEmpty())
            {
                throw new Exception("The list is empty");
            }
            else
            {
                return values[--count];
            }
        }

        // return number of items in the list
        public int size()
        {
            return count;
        }


        //iterate over a list to display all items
        public void display()
        {
            if (count == 0)
            {
                Console.WriteLine("The list is empty");
            }

            else
            {
                Console.WriteLine("The list has " + count + "  " + "items");
                for (int i = 0; i < count; i++)
                    Console.WriteLine("Value" + values[i]);
            }
        }



    }
}
