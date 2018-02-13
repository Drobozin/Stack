using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack: ");
            List<string> stringStack = new List<string>();
            for (int i = 0; i < 5; ++i)
            {
                stringStack.Push(Convert.ToString(i));
            }
            stringStack.Print();
            Console.WriteLine("\n");
            Console.WriteLine($"First value: {stringStack.Top()}");
            for (int i = stringStack.count; i > 0; --i)
            {
                stringStack.Pop();
            }

            Console.WriteLine("Stack after Pop: ");
            stringStack.Print();
        

            Console.ReadLine();
        }
    }
}
