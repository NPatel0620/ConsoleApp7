using System;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicles c1 = new Vehicles
            {
                Make = "BMW",
                Model = "7 Series",
                Color = "White",
                Year = 2018,
                Miles = 10
            };
            
            Console.WriteLine("Is the {0} {1} Foreign or Domestic? {2}", c1.Make, c1.Model);
            c1.IsDomestic();
            /*
            Console.WriteLine("Is the car new?: ");
            c1.IsNew();
            */

            Console.WriteLine("Is the {0} {1} new? {2}", c1.Make, c1.Model, c1.IsNew());
            //Console.WriteLine("Is {0} domestic? {1}", c1.Model, c1.IsDomestic());
            Console.ReadLine();
            
        }
    }

}




