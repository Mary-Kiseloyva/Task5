using System.Collections.Generic;

namespace task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Bus());
            vehicles.Add(new Taxi());
            vehicles.Add(new Tram());
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.ReleasePassengers(5);
                vehicle.LetPassengersIn(5);
            }
            {
                
            }
        }
    }
}