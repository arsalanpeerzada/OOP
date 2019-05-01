using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Velocity
    {
        double InitialVelocity;
        double acceleration;
        double Time;

        public void VEL(double Vi, double a, double t)
        {
            InitialVelocity = Vi;
            acceleration = a;
            Time = t;
            double FinalVelocity = InitialVelocity + (acceleration * Time);
            Console.WriteLine("\n" + "INITAL VELOCITY:" + InitialVelocity + "\n" + "ACCELERATION:" + acceleration + "\n" + "TIME:" + Time);
            Console.WriteLine("FINAL VELOCITY IS:" + FinalVelocity);
        }
    }
}
