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
            MyStack aStack = new MyStack();
            Console.WriteLine("Testing Stack");

            Console.WriteLine("Testing isEmpty method" + aStack.isEmpty());
            for(int i=0; i<6; i++)
            {
                aStack.push(i);
            }

            Console.ReadLine();

        }
    }
}
