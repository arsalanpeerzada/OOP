using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_3
{
    public class ConstOverloading
    {
        private int rollNum;
       public ConstOverloading()
        {
            rollNum = 100;
        }
       public ConstOverloading(int rnum)
        {
            rollNum = rollNum + rnum;
        }
        public int getRollNum()
        {
            return rollNum;
        }
        public void setRollNum(int rollNum)
        {
            this.rollNum = rollNum;
        }
    }

}

