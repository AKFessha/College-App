using System;
using System.Collections;
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
            Console.WriteLine("Testing Stack1");

            Console.WriteLine("Testing isEmpty method" + aStack.isEmpty());
            for(int i=0; i<6; i++)
            {
                aStack.push(i);
            }

            Console.WriteLine("Number of values in the Stack " + aStack.size());
            aStack.toString();

            Console.WriteLine("Remove an item from the Stack " + aStack.pop());
            aStack.toString(); 

            //linkedStack

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

            //Hashtable
            Hashtable ht = new Hashtable();
            ht.Add(07454941123, "Awet");
            ht.Add(07659452132, "Nahom");
            ht.Add(0141234574, "Clyde college");
            ht.Add(07654321543, "Ismaiel");
            ht.Add(999, "Emergency");

            foreach (DictionaryEntry x in ht)
            {
                Console.WriteLine(x.Value + " Phone number " + x.Key);

            }

            Dictionary <string, string> books = new Dictionary <string, string>();
            books.Add("Agata Christ", "The woman in the train");
            books.Add("Shieve Kira", "You can win");
            books.Add("Osho", "Try it my way");
            books.Add("Meles beyene", "Tsibit bahgu");

            foreach(KeyValuePair<string, string> i in books){
                Console.WriteLine(i.Value + " written by " + i.Key);
            }

            Console.ReadLine();

        }
    }
}
