using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();
            
            Showroom.Add("Lincoln");
            Showroom.Add("Cadillac sts");
            Showroom.Add("Malibu");
            Showroom.Add("Thunderbird");
            
           // Console.WriteLine(Showroom.Count);
           
            Showroom.Add("Cadillac sts");

         
           // foreach (String model in Showroom)
           // {
           //     Console.WriteLine(model);
           // }
            
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Jeep");
            UsedLot.Add("pinto");
            Showroom.UnionWith(UsedLot);
           // foreach (String model in Showroom)
           // {
           //     Console.WriteLine(model);
           // }
            Showroom.Remove("Lincoln");
            foreach (String model in Showroom)
            {
                Console.WriteLine(model);
            }

           
            HashSet<string> Junkyard = new HashSet<string> { };
            Junkyard.Add("Impala");
            Junkyard.Add("Mustang");
            Junkyard.Add("Thunderbird");
            Junkyard.Add("GTO");
            HashSet<string> clone = new HashSet<string>(Showroom) { };
            clone.IntersectWith(Junkyard);
           // Console.WriteLine(clone.Count);
            Showroom.UnionWith(Junkyard);
           // Console.WriteLine("Combined");
            // foreach (String model in Showroom)
            // {
            //     Console.WriteLine(model);
            // }
           
            Junkyard.Remove("Mustang");
            Junkyard.Remove("GTO");

              foreach (String model in Junkyard)
            {
                Console.WriteLine(model);
            }
        }
    }
}
