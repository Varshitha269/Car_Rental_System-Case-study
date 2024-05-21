using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Myexceptions
{
    //internal class LeaseNotFoundException
    //{
    //}

    public class LeaseNotFoundException : Exception
    {
        public LeaseNotFoundException()
        {
        }

        public LeaseNotFoundException(string msg) : base(msg)
        {
        }
    }
}
