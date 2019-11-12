using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            List<Emploer> emploers = new List<Emploer>();
            emploers.Add(new Emploer() { Id = 1, FirstName ="Vlad", LastName = "Kobrya", Price = 1234 });
            emploers.Add(new Emploer() { Id = 2, FirstName = "Oleg", LastName = "Kovalenko", Price = 2345 });
            emploers.Add(new Emploer() { Id = 3, FirstName = "Antya", LastName = "Petrov", Price = 3456 });
            emploers.Add(new Emploer() { Id = 4, FirstName = "Napoleon", LastName = "Da", Price = 523523 });

            var items =  emploers.Where(a=>a.Price < 10000);
            foreach(var item in items)
            {
                Console.WriteLine($"Id {item.Id} FirstName {item.FirstName} LastName {item.LastName} Price {item.Price}");
            }
        }
        
    }

    class Emploer
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public double Price;
    }
}