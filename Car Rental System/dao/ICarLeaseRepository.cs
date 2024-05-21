using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental_System.Models;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Car_Rental_System.dao
{
    //internal interface ICarLeaseRepository
    //{
    //}
    public interface ICarLeaseRepository
    {
        //Car Management :
        int addCar(Vehicle car);
        int removeCar(int vid);
        List<Vehicle> listAvailableCars();
        List<Vehicle> listRentedCars();
        List<Vehicle> findCarById(int vid);
        bool IsCarIdExists(int carId);

        // Customer Management :

        int addCustomer(Customer customer);
        int removeCustomer(int vid);
        List<Customer> listCustomers();
        Customer findCustomerById(int customerID);
        int updateCustomerDetails(Customer updatec1);
        bool IsCustomerIdExists(int custid);
        //update customer functionality
        List<Vehicle> getallcars();

        //Lease Management :
        int createLease(int LeaseID,int vehicleID, int customerID, DateTime startDate, DateTime endDate, string type);
        int returnCar(int leaseid);
        List<Lease> listActiveLeases();
        List<Lease> listLeaseHistory();
        double totalLeaseCost(int lease_id);
        public double LeaseCost(int VehicleID, DateTime StartDate, DateTime EndDate);
        public bool isCaronLease(int activecarid);
        List<Lease> listallLease();
        bool IsLeaseIdExists(int lid);
        double CalculateLeaseCost(int VehicleID, int number, string type);

        //Payment Handling :
        int recordPayment(Lease lease);
        List<Payment> paymentHistory(Customer customer);
        double totalRevenue();
        bool findPaymentByLeaseId(int payment);


    }


}
