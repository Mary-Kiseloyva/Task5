namespace task5
{
    public class Bus : PublicTransport
    {
        private int passengerCapacity { get; set; }
        private string routeNumber { get; set; }
        
        public string GetRouteInfo()
        {
            return "Маршрут " + routeNumber + ": ...";
        }

        public bool Check(string place)
        {
            return true;
        }
    }
}