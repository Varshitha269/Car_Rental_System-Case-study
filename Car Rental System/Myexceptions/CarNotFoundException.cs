using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Myexceptions
{
    //internal class CarNotFoundException
    //{
    //}

    public class CarNotFoundException : Exception
    {
        public CarNotFoundException()
        {
        }
        public CarNotFoundException(string msg) : base(msg)
        {
        }
        public CarNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
