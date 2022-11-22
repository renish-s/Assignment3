using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class student
    {
        public string name;
        public int roll_number;
        public void displaydetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll Number: " + roll_number);

        }
    
    static void Main(string[] args)
    {
        student a = new student();
        a.name = "Renish";
        a.roll_number = 101;
        student b = new student();
        b.name = "S";
        b.roll_number = 102;
        a.displaydetails();
        b.displaydetails();
        Console.ReadLine();

    }
}
}
