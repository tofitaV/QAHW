using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public static class Program 
    {
        
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(new int[] {0,1,2,3,4,5,6,7,8,9 });

           object item = arrayList.LastElement();
           Console.WriteLine(item);
            object items = arrayList.FirstElement();
            Console.WriteLine(items);
        }
        
    }

    public static class Emploer
    {
        public static object FirstElement(this ArrayList array)
        {
            return array[0];
        }

        public static object LastElement(this ArrayList array)
        {
            return array[array.Count-1];
        }
    }
}