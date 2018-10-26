using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_App
{
    //Implmenting the interface IStackADT
    //Awet Fessha 24/10/18
    class Program
    {
        static void Main(string[] args)
        {
           /* MyStack aStack = new MyStack();
            Console.WriteLine("Testing Stack1");

            Console.WriteLine("Testing isEmpty method" + aStack.isEmpty());
            for(int i=0; i<6; i++)
            {
                aStack.push(i);
            }

            Console.WriteLine("Number of values in the Stack " + aStack.size());
            aStack.toString();

            Console.WriteLine("Remove an item from the Stack " + aStack.pop());
            aStack.toString(); */

            MyLinkedStack list = new MyLinkedStack();
            Console.WriteLine("Testing Stack2");

            Console.WriteLine("Testing isEmpty method" + list.isEmpty());
            for(int i=0; i<6; i++)
            {
                list.push(i);
            }
            Console.WriteLine("Number of values in the Stack " + list.size());
            list.toString();

            Console.WriteLine("Remove an item from the Stack " + list.pop());
            Console.WriteLine("value 5 should have been removed ");
            list.toString();

            Console.ReadLine();

        }
    }
}
