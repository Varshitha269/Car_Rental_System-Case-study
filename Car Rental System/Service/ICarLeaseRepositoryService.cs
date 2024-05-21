using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental_System.Models;

namespace Car_Rental_System.Service
{
    //internal interface ICarLeaseRepositoryService
    //{
    //}

    public interface ICarLeaseRepositoryService
    {

        //Car Management :
        void addCar();
        void removeCar();
        void listAvailableCars();
        void listRentedCars();
        void findCarById();

        // Customer Management :

        void addCustomer();
        void removeCustomer();
        void listCustomers(); //checked & working
        void findCustomerById();
        void updateCustomerDetails();

        //Lease Management :
        void createLease();
        void returnCar();
        void listActiveLeases();
        void listLeaseHistory();
        void totalLeaseCost();
        void calculatetotalleaseCost();


        //Payment Handling :
        void recordPayment();
        void paymentHistory();
        void totalRevenue();




    }
}
