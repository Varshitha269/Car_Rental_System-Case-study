using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Myexceptions
{
    //internal class CustomerNotFoundException
    //{
    //}

    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException()
        {
        }


        public CustomerNotFoundException(string msg) : base(msg)
        {
        }

    }
}
