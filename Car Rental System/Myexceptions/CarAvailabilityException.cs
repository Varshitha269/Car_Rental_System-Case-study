using System;


namespace Car_Rental_System.Myexceptions
{
    //internal class CarAvailabilityException
    //{
    //}
    public class CarAvailibilityException : Exception
    {
        public CarAvailibilityException(string msg) : base(msg)
        {
        }
        public CarAvailibilityException()
        {
        }
    }
}
