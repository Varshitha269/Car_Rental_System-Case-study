using System;
using System.Diagnostics;

namespace Car_Rental_System.Models
{
    //internal class Customer
    //{
    //}

    public class Customer
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string email;
        public string phoneNumber;

        public int CustomerID   
        {
            get { return customerID; }   
            set { customerID = value; }  
        }

        public string FirstName   
        {
            get { return firstName; }   
            set { firstName = value; }  
        }

        public string LastName   
        {
            get { return lastName; }   
            set { lastName = value; }  
        }


        public string Email   
        {
            get { return email; }   
            set { email = value; }  
        }



        public string PhoneNumber   
        {
            get { return phoneNumber; }   
            set { phoneNumber = value; }  
        }


        public override string ToString()
        {
            return $"Id:: {CustomerID}\t FirstName:: {FirstName} \tLast Name:: {LastName} \tEmail:: {Email} \tPhoneNumber:: {PhoneNumber}";
        }


        public Customer()
        {
        }

        public Customer(int CustomerID, string FirstName, string LastName, string Email, string PhoneNumber)
        {
            this.CustomerID = CustomerID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
