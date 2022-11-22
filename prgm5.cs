using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program5
    {
        class Book
        {
            private int bookNo;
            private string bookTitle;
            private float price;

            public void Input()
            {
                Console.Write("Enter Book No: ");
                bookNo = int.Parse(Console.ReadLine());
                Console.Write("Enter Book Title: ");
                bookTitle = Console.ReadLine();
                Console.Write("Enter Price: ");
                price = int.Parse(Console.ReadLine());
            }

            public float TotalCost(int n)
            {
                return price * n;
            }

            public void Purchase()
            {
                Console.Write("Enter the number of copies to be purchased: ");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Total cost to be paid: {0}", TotalCost(m));

            }

            public void Display()
            {
                Console.WriteLine("Book No: {0}", bookNo);
                Console.WriteLine("Book Title: {0}", bookTitle);
                Console.WriteLine("Price: {0}", price);
                Console.ReadLine();
            }

            static void Main(string[] args)
            {
                Book b = new Book();
                b.Input();
                b.Purchase();
                b.Display();
            }
        }
    }
}
