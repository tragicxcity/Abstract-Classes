using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles


            /*DONE - Create an abstract class called Vehicle
            

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var Honda = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2020 };

            var BMW = new Motorcycle() { HasSideCart = false, Make = "BMW", Model = "F", Year = 2020 };

            Vehicle Chev = new Car() { Make = "Chevy", Model = "Corvetter", Year = 1963 };
            Vehicle Mus = new Car() { Make = "Ford", Model = "Mustang", Year = 1969 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(Honda);
            vehicles.Add(BMW);
            vehicles.Add(Chev);
            vehicles.Add(Mus);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveVirtual();
                Console.WriteLine("--------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
