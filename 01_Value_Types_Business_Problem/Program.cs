using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Business_Problem
{
    class Program
    {
        enum VehicleType
        {
            Car = 1, Motorcycle, Boat, Plane
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo!/n" +
                              "Please enter your name:");
            var userName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var ageResponse = Console.ReadLine();//why can't you Parse on this line?
            int userAge = int.Parse(ageResponse);

            Console.WriteLine($"Hello, {userName}./n" +
                              "What kind of vehicle will you be insuring?/n" +
                              "1: Car/n" +
                              "2: Motorcycle/n" +
                              "3: Boat/n" +
                              "4: Plane");
            var vehicleResponse = Console.ReadLine();
            int userVehicle = int.Parse(vehicleResponse);
            VehicleType vehicleType = (VehicleType)userVehicle;

            decimal insurancePrice = 0m;

            switch (vehicleType)
            {
                case VehicleType.Car:
                    if (18 <= userAge && userAge <= 27) insurancePrice = 150m;
                    if (28 <= userAge && userAge <= 65) insurancePrice = 50m;
                    if (userAge > 65) insurancePrice = 100m;
                    break;
                case VehicleType.Boat:
                    if (18 <= userAge && userAge <= 27) insurancePrice = 200m;
                    if (28 <= userAge && userAge <= 65) insurancePrice = 100m;
                    if (userAge > 65) insurancePrice = 150m;
                    break;
                case VehicleType.Motorcycle:
                    if (18 <= userAge && userAge <= 27) insurancePrice = 200m;
                    if (28 <= userAge && userAge <= 65) insurancePrice = 100m;
                    if (userAge > 65) insurancePrice = 250m;
                    break;
                case VehicleType.Plane:
                    if (18 <= userAge && userAge <= 27) insurancePrice = 1000m;
                    if (28 <= userAge && userAge <= 65) insurancePrice = 500m;
                    if (userAge > 65) insurancePrice = 1000m;
                    break;
            }

            Console.WriteLine($"Your insurance estimate is ${insurancePrice} per month.");
            Console.ReadLine();
        }
    }
}
