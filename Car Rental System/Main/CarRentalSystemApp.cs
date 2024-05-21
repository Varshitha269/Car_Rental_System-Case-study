using Car_Rental_System.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Main
{
    //internal class CarRentalSystemApp
    //{
    //}

    public class CarRentalSystemApplication
    {
        readonly ICarLeaseRepositoryService _ICarLeaseRepositoryService;
        public CarRentalSystemApplication()
        {
            _ICarLeaseRepositoryService = new ICarLeaseRepositoryServiceImpl();
        }

        public bool Run()
        {
            bool exit = false;  
            while (!exit)
            {
            The_Main_Menu:


                Console.WriteLine("     CAR RENTAL SYSTEM APPLICATION     ");
                Console.WriteLine("!--------------------------------------------------!");
                Console.WriteLine();
                Console.WriteLine("Please choose what kind of service you need :");
                Console.WriteLine();
                Console.WriteLine("  1. Customer Management");
                Console.WriteLine("  2. Car Management");
                Console.WriteLine("  3. Lease Management");
                Console.WriteLine("  4. Payment Handling");
                Console.WriteLine("  5. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                Console.WriteLine();

                int userInput;
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please provide a number.");
                    continue;
                }

                switch (userInput)
                {
                    case 1:


                        Console.WriteLine("           CUSTOMER MANAGEMENT             ");
                        Console.WriteLine("!--------------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an input:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Add New Customer");
                        Console.WriteLine("  2. Update Customer Details");
                        Console.WriteLine("  3. Remove Customer");
                        Console.WriteLine("  4. List All Customers");
                        Console.WriteLine("  5. Find Customer Details By Id");
                        Console.WriteLine("  6. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int a;
                        if (!int.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (a)
                        {
                            case 1:
                                _ICarLeaseRepositoryService.addCustomer();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _ICarLeaseRepositoryService.updateCustomerDetails();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _ICarLeaseRepositoryService.removeCustomer();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 4:
                                _ICarLeaseRepositoryService.listCustomers();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 5:
                                _ICarLeaseRepositoryService.findCustomerById();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                continue;
                            case 6:
                                goto The_Main_Menu;
                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                break;
                        }

                        break;

                    case 2:


                        Console.WriteLine("           CAR MANAGEMENT CONSOLE");
                        Console.WriteLine("!--------------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an input:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Add New Car");
                        Console.WriteLine("  2. Remove Car");
                        Console.WriteLine("  3. List Rented Cars");
                        Console.WriteLine("  4. List Available Cars");
                        Console.WriteLine("  5. Find Car Information By Id");
                        Console.WriteLine("  6. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int b;
                        if (!int.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (b)
                        {
                            case 1:

                                _ICarLeaseRepositoryService.addCar();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _ICarLeaseRepositoryService.removeCar();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _ICarLeaseRepositoryService.listRentedCars();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();

                                break;
                            case 4:
                                _ICarLeaseRepositoryService.listAvailableCars();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;

                            case 5:
                                _ICarLeaseRepositoryService.findCarById();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;

                            case 6:
                                goto The_Main_Menu;

                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 3:

                        Console.WriteLine("           LEASE MANAGEMENT CONSOLE");
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an input:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Create New Lease");
                        Console.WriteLine("  2. Return Car");
                        Console.WriteLine("  3. List Active Leases");
                        Console.WriteLine("  4. List Past Leases");
                        Console.WriteLine("  5. Calculate Lease Cost");
                        Console.WriteLine("  6. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");



                        int c;
                        if (!int.TryParse(Console.ReadLine(), out c))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (c)
                        {
                            case 1:
                                _ICarLeaseRepositoryService.createLease();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _ICarLeaseRepositoryService.returnCar();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;

                            case 3:
                                _ICarLeaseRepositoryService.listActiveLeases();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;

                            case 4:
                                _ICarLeaseRepositoryService.listLeaseHistory();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;

                            case 5:
                                _ICarLeaseRepositoryService.calculatetotalleaseCost();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 6:
                                goto The_Main_Menu;


                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                Console.ReadLine();
                                break;
                        }


                        break;

                    case 4:


                        Console.WriteLine("        PAYMENT HANDLING CONSOLE");
                        Console.WriteLine("!--------------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an input:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Record New Payment");
                        Console.WriteLine("  2. Retrieve Payment History For Customer");
                        Console.WriteLine("  3. Calculate Total Revenue");
                        Console.WriteLine("  4. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");




                        int d;
                        if (!int.TryParse(Console.ReadLine(), out d))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (d)
                        {
                            case 1:
                                _ICarLeaseRepositoryService.recordPayment();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _ICarLeaseRepositoryService.paymentHistory();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _ICarLeaseRepositoryService.totalRevenue();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 4:
                                goto The_Main_Menu;



                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                break;
                        }
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Exited from the application");
                        return false;

                    default:
                        Console.WriteLine("ENTER CORRECT INPUT ");
                        break;
                }







            }
            return true;
        }



    }
}
