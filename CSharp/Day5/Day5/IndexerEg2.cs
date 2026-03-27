using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Flowers
    {
        string Name;
        string Color;

        public Flowers(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + " is in " + Color + " Color");
        }
    }

    class FlowerVase
    {
        Flowers [] fobj = new Flowers[5];  

        public Flowers this[int index]
        {
            get { return fobj[index]; }
            set { fobj[index] = value; }
        }
    }
    internal class IndexerEg2
    {
        static void Main()
        {
            FlowerVase fv = new FlowerVase();
            fv[0] = new Flowers("Roses", "Red");
            fv[1] = new Flowers("Lilies", "White");
            fv[2] = new Flowers("Marigolds", "Yellow");

            for(int i=0; i<3; i++)
            {
                fv[i].Display();
            }
            Console.Read();
        }
    }
}
