using System;
using System.Xml.Linq;

namespace Car_Rental_System.Models
{
    //internal class Vehicle
    //{
    //}

    public class Vehicle
    {
        private int vehicleID;
        private string make;
        private string model;
        private int year;
        private double dailyRate;
        private string status;
        private int passengerCapacity;
        private int engineCapacity;

        public int VehicleID   
        {
            get { return vehicleID; }   
            set { vehicleID = value; }  
        }
        public string Make   
        {
            get { return make; }   
            set { make = value; }  
        }

        public string Model   
        {
            get { return model; }   
            set { model = value; }  
        }

        public int Year   
        {
            get { return year; }   
            set { year = value; }  
        }

        public double DailyRate   
        {
            get { return dailyRate; }   
            set { dailyRate = value; }  
        }

        public string Status   
        {
            get { return status; }   
            set { status = value; }  
        }

        public int PassengerCapacity   
        {
            get { return passengerCapacity; }   
            set { passengerCapacity = value; }  
        }

        public decimal EngineCapacity   
        {
            get { return engineCapacity; }   
            set { engineCapacity = (int)value; }  
        }

        public override string ToString()
        {
            return $"Id:: {VehicleID}\t Maker:: {Make} \t Model:: {Model} \tYear:: {Year} \nDailyRate:: {DailyRate} \t Status:: {Status}  \t PassengerCapacity:: {PassengerCapacity}\t EngineCapacity:: {EngineCapacity}";
        }



        public Vehicle()
        {
        }

        public Vehicle(int Vehicleid, string Make, string Model, int Year, int DailyRate, string Status, int PassengerCapacity, int EngineCapacity)
        {
            this.VehicleID = Vehicleid;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.DailyRate = DailyRate;
            this.Status = Status;
            this.PassengerCapacity = PassengerCapacity;
            this.EngineCapacity = EngineCapacity;
        }



    }


}
