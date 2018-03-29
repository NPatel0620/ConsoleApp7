using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Vehicles
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }

        public bool IsNew()
        {
            /*
            if (Miles <= 25)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */
            return this.Miles <= 25;
        }

        public void IsDomestic()
        {
            string[] domestic = new string[] { "GM", "Ford", "Lincoln", "Chrysler",
                                               "Caddilac", "Jeep", "Tesla" };

            foreach (string domCar in domestic)
            {
                if (Make.Contains(domCar)) 
                {
                    Console.WriteLine("Domestic");
                }
            }

            string[] foreign = new string[] {"Nissan", "Mitsubishi", "Infiniti", "Honda", "Toyota",
                                             "Mercedes Benz", "Audi", "BMW", "Volkswagen"};

            foreach (string forCar in foreign)
            {
                if (Make.Contains(forCar))
                {
                    Console.WriteLine("Foreign");
                }
            }
        }
        public class Car
        {
            public int MyProperty { get; set; }
        }

        public class Truck
        {
            public int MyProperty { get; set; }
        }
    }   
}
