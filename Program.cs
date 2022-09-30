using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
       
       
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(5, 6);
            var square1 = new Square(7);
            var triangle1 = new Triangle(5, 6);

            var list = new List<figure> { rectangle1,square1};

            list.Add(triangle1);
            foreach (var f in list)
            {
                f.Write();
            }
        }
        
    }
   
}
