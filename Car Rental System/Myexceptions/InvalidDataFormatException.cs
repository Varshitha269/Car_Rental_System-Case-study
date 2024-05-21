using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Myexceptions
{
    //internal class InvalidDataFormatException
    //{
    //}

    public class InvalidDataFormatException : Exception
    {
        public InvalidDataFormatException()
        {
        }
        public InvalidDataFormatException(string msg) : base(msg)
        {
        }
    }
}
