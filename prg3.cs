using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class prg3
    {
        
        public static int Countspaces(string str)
        {
            int spcctr = 0;
            string s;
            for (int i = 0; i < str.Length; i++)
            {
                s = str.Substring(i, 1);
                if (s == " ")
                    spcctr++;
            }
            return spcctr;
        }
        public static void Main()
        {
            string strtwo;
            Console.Write("Please Enter a string : ");
            strtwo = Console.ReadLine();
            Console.WriteLine("\"" + strtwo + "\"" + " contains {0} spaces", Countspaces(strtwo));

            Console.ReadLine();
        }
    }
}
    