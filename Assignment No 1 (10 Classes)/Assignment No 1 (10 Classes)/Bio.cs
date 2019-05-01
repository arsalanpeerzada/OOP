using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Bio
    {
        string Name;
        string FatherName;
        string UniversityName;
        int SID;
        string Phonenumber;
        string Address;
        public void Bi(string a, string b, string c, int d, string f,string e)
        {
            Name = a;
            FatherName = b;
            UniversityName = c;
            SID = d;
            Phonenumber = f;
            Address = e;
            Console.Write("\n"+"NAME:" + Name + "\n"+"FATHER NAME:" + FatherName + "\n"+"UNIVERSITY NAME:" + UniversityName +"\n"+"SID:" + SID + "\n"+"PHONENUMBER:" + Phonenumber+"\n"+"ADDRESS:"+Address);
        }
    }
}
