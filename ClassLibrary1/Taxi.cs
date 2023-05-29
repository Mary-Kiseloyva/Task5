namespace task5
{
    public class Taxi : PublicTransport
    {
        public int Fare { get; set; }

        public string DriverMan { get; set; }

        public string OrderTaxi(string pickupLocation, string destination)
        {
            return pickupLocation + destination;

        }

        public double CalculateFare(double distance, double ratePerKilometer)
        {
            double fare = distance * ratePerKilometer;

            return fare;
        }
    }
}