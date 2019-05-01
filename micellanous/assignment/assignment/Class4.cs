using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment
{
    partial class Program
    {
        string gender;
        string bloodgrp;
        string remarks;

        public void details()
        {
            Console.WriteLine("\t \t" + "Enter Gender");
            Console.Write("\t \t");
            gender = Console.ReadLine();
            Console.WriteLine("\t \t" + "Enter BloodGroup");
            Console.Write("\t \t");
            bloodgrp = Console.ReadLine();
            Console.WriteLine("\t \t" + "Enter Remarks");
            Console.Write("\t \t");
            remarks = Console.ReadLine();
        }

        public void showdetails()
        {
            Console.WriteLine("\t \t" + "Gender" + "\t \t \t" + ":\t" + gender);
            Console.WriteLine("\t \t" + "Blood Group" + "\t \t \t" + ":\t" + bloodgrp);
            Console.WriteLine("\t \t" + "Remarks" + "\t \t \t" + ":\t" + remarks);
        }

    }
}
