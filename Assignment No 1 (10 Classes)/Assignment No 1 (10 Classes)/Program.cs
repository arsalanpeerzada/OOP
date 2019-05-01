using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("FACTORIAL");
            Factorial factorial = new Factorial();//Factorial Class Work
            factorial.Fac(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("============================");
            Console.WriteLine("TABLE");
            Table table = new Table();//Table Class Work
            table.Tab(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("============================");
            Console.WriteLine("MATH FUNCTIONS");
            MathFunctions math = new MathFunctions();//MathFunctions Class Work

            Console.WriteLine("ADD");
            math.add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("SUB");
            math.sub(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("MUL");
            math.mul(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("DIV");
            math.div(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("============================");
            Console.WriteLine("BIO");//Bio Class Work
            Bio BI = new Bio();
            BI.Bi("JALAL","USMAN","PAFKIET",6626,"03072060961","HOUSE NO B373 SECTOR 35/A KORANGI NO 4 ZAMAN TOWN"+"\n");

            Console.WriteLine("============================");
            Console.WriteLine("EVEN ODD");//EvenOdd Class Work
            EvenOdd OD = new EvenOdd();
            OD.EVEN(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("============================");
            Console.WriteLine("MARKSHEET");//MarkSheet Class Work
            MarkSheet PER = new MarkSheet();
            PER.RES("JALAL","PAF KIET",6626);

            Console.WriteLine("============================");
            Console.WriteLine("SWAPING");//Swaping Class Work
            Swaping INT = new Swaping();
            INT.Interchange(6, 5);

            Console.WriteLine("============================");
            Console.WriteLine("BOX");//Box Class Work
            Box Ox = new Box();
            Ox.Bo(5, 6, 4);

            Console.WriteLine("============================");
            Console.WriteLine("VELOCITY");//Velocity Class Work
            Velocity VELO = new Velocity();
            VELO.VEL(6, 5, 4);

            Console.WriteLine("============================");
            Console.WriteLine("RIGHT TRIANGLE");//RightTriangle Class Work
            RightTriangle TRI = new RightTriangle();
            TRI.RIG(Convert.ToInt32(Console.ReadLine()));
        
        
        }
    }
}
