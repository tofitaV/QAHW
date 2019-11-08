using System;
using System.Collections;

namespace MyApp
{
    class Program : IEnumerator, IEnumerable
    {
        static void Main(string[] args)
        {
            Program test = new Program();

            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.WriteLine(test.Current());
                Console.WriteLine(test.MoveNext());
            }

        }

        public static int[] arr = { 1, 2,5555, 3,444, 4, 5, 6, 8 };
        int Counter;

        object IEnumerator.Current => throw new NotImplementedException();

        public object Current()
        {
            return arr[Counter];
        }

         public bool MoveNext()
        {
            if(Counter < arr.Length)
            {
                Counter++;
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
            
        }

        public void Reset()
        {
            Counter = -1;
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}