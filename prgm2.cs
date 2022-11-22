using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class prgm2
    {

        class Shape
        {
            public virtual void Draw()
            {

            }
        }

        class Ractangel : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle Drawn ");
            }

        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Drawn ");

            }

        }
        class Traingle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Triangle Drawn ");

            }


            static void Main(string[] args)
            {

                Shape[] s = new Shape[3];

                s[0] = new Circle();
                s[1] = new Ractangel();
                s[2] = new Traingle();

                Console.WriteLine("\n\nRuntime polymorphism Example\n\n");

                for (int i = 0; i < 3; i++)
                {
                    s[i].Draw();
                }

                Console.ReadKey();
            }
        }
    }
}
    
