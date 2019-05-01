using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Box
    {
        double Height;
        double Width;
        double Depth;
        public void Bo(double a, double b, double c)
        {
            Height = a;
            Width = b;
            Depth = c;

            double Volume;
            Volume = Height * Width * Depth;
            Console.WriteLine("\n" + "HEIGHT:" + Height + "\n" + "WIDTH:" + Width + "\n" + "DEPTH:" + Depth);
            Console.WriteLine("VOLUME IS: "+Volume);
        }
    }
}
