using System;

namespace ConsoleApp1
{
    class Program
    { 
        
        static void Main()
        {
            //var obj = new MyStack();
            //obj.Push(1);
            //obj.Push(2);
            //obj.Push(3);
            //Console.WriteLine(obj.Pop());
            //Console.WriteLine(obj.Pop());
            //Console.WriteLine(obj.Pop());

            var obj = new MyStackT<string>();
            obj.Push("sdf");
            obj.Push("sd");
            obj.Push("qweqwe");
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
        }

        
    }
}
