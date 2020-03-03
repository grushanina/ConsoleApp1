using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyStack
    {
        public int Count;
        private int [] data;

        public MyStack()
        {
            data = new int[0];
        }

        public void Push(int x)
        {
            Array.Resize(ref data, Count + 1);
            data[Count] = x;
            ++Count;
        }

        public int Peek()
        {
            if (Count>0)
            {
                return (data[Count - 1]);
            }
            else
            {
                return(default(int));
            }
           
        }

        public int Pop()
        {
            if (Count>0)
            {
                var temp = Peek();
                Array.Resize(ref data, Count - 1);
                --Count;
                return temp;
            }
            else
            {
                throw new System.InvalidOperationException("a");
                
            }
        }

        public void Clear()
        {
            Array.Resize(ref data, 0);
            Count = 0;
        }

        public bool Empty()
        {
            return Count == 0;
    
        }
    }
}
