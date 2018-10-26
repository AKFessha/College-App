using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App
{
    class DataStructure
    {
        // set up class node to used in the linked list
        class Node
        {
            // data members
            public Node nextnode;
            public int value;

            // constructor
            public Node(int val)
            {
                value = val;
                nextnode = null;
            }

            public void addNode(int val)
            {
                // recursive function - calls itself
                // check if nextnode is null - if it is null create new node
                // else add to nextnode

                if (nextnode == null)
                    nextnode = new Node(val);
                else
                    nextnode.addNode(val);
            }
        }// end Node class

        // start node to be determined

        private Node start;
        private int count;

        public DataStructure()
        {
            start = null;
            count = 0;
        }

        public Boolean isEmpty()
        {
            return (count == 0);
        }

        public int size()
        {
            return count;
        }

        public void addlast(int val)
        {
            // add value to end of list

            if (start == null)
                start = new Node(val);
            else
                start.addNode(val);

            count++;
        }

        public int removelast()
        {
            int rmval = 0;
            // attempt to remove from empty stack - generates an error

            if (isEmpty())
                throw new Exception("List is empty");

            else
            {
                if (count == 1)
                {
                    rmval = start.value;
                    start = null;
                }
                else
                {
                    Node tempNode = start.nextnode;
                    Node previous = start;

                    while (tempNode.nextnode != null)
                    {
                        previous = tempNode;
                        tempNode = tempNode.nextnode;
                    }
                    rmval = tempNode.value;
                    previous.nextnode = null;
                }
                count--;
            }

            return rmval;
        }

        public int removeFirst()
        {
            int rmval = 0;

            try
            {
                rmval = start.value;
                if (start.nextnode == null)
                    start = null;
                else
                {
                    start = start.nextnode;
                    count--;
                }
            }// end try

            catch (Exception)
            {
                if (isEmpty())
                    Console.WriteLine("List is empty - nothing to remove");
            }// end catch

            return rmval;
        }

        public void addFirst(int val)
        {
            if (isEmpty())
                addlast(val);
            else
            {
                Node tempnode = start;
                start = new Node(val);
                start.nextnode = tempnode;
                count++;
            }
        }

        // Functional prototype
        public void display()
        {
            if (count == 0)
                Console.WriteLine("Empty list - nothing to display");
            else
                Console.WriteLine("List has " + count + " items");

            // print using while loop assign varialbe current_node to start so that the loop operates

            Node current_node = start;

            while (current_node != null)
            {
                Console.WriteLine("value of node " + current_node.value);
                current_node = current_node.nextnode;
            }
        }
    }

}

