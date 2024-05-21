using System;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;

namespace Car_Rental_System.Models
{
    //internal class Lease
    //{
    //}

    public class Lease
    {
        private int leaseID;
        private int vehicleID;
        private int customerID;
        private DateTime startDate;
        private DateTime endDate;
        private string type;


        public int LeaseID   
        {
            get { return leaseID; }   
            set { leaseID = value; }  
        }

        public int VehicleID   
        {
            get { return vehicleID; }   
            set { vehicleID = value; }  
        }

        public int CustomerID   
        {
            get { return customerID; }   
            set { customerID = value; }  
        }

        public DateTime StartDate   
        {
            get { return startDate; }   
            set { startDate = value; }  
        }

        public DateTime EndDate   
        {
            get { return endDate; }   
            set { endDate = value; }  
        }

        public string Type   
        {
            get { return type; }   
            set { type = value; }  
        }

        public static int leaseId { get; internal set; }

        public override string ToString()
        {
            return $"Id:: {LeaseID}\t VehicleID:: {VehicleID} \t CustomerID:: {CustomerID} \t StartDate:: {StartDate} \t EndDate:: {EndDate} \t Type:: {Type}";
        }

        public Lease()
        {
        }

        public Lease(int leaseID, int vehicleID, int customerID, DateTime startDate, DateTime endDate, string type)
        {
            this.LeaseID = leaseID;
            this.VehicleID = vehicleID;
            this.CustomerID = customerID;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Type = type;
        }



    }
}
