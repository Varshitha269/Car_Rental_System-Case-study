using System;
using System.Reflection.Emit;

namespace Car_Rental_System.Models
{
    //internal class Payment
    //{
    //}

    public class Payment
    {
        public int paymentID;
        private int leaseID;
        private DateTime paymentDate;
        private int amount;

        public int PaymentID   
        {
            get { return paymentID; }   
            set { paymentID = value; }  
        }

        public int LeaseID   
        {
            get { return leaseID; }   
            set { leaseID = value; }  
        }

        public DateTime PaymentDate   
        {
            get { return paymentDate; }   
            set { paymentDate = value; }  
        }

        public int Amount   
        {
            get { return amount; }   
            set { amount = value; }  
        }

        public override string ToString()
        {
            return $"Id:: {PaymentID}\t LeaseID:: {LeaseID} \t PaymentDate:: {PaymentDate} \t Amount:: {Amount} ";
        }


        public Payment()
        {
        }

        public Payment(int paymentID, int leaseID, DateTime paymentDate, int amount)
        {
            this.PaymentID = paymentID;
            this.LeaseID = leaseID;
            this.PaymentDate = paymentDate;
            this.Amount = amount;
        }




    }
}
