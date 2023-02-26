using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Book
    {
        public string name;
        public string authorName;
        public string genre;
        public int pageCount;
        public double price;

        public void PrintInfo()
        {
            Console.WriteLine($"{name} , {authorName} , {genre} , {pageCount}  ,  {price}");
        }



    }
}
