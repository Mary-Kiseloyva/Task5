namespace task5
{
    public abstract class PublicTransport : Vehicle
    {
        public int Fare { get; set; }
        
        public int NumberOfPassengers { get; set; }
        
        public int DistanceTraveled { get; set; }
        
        public int GasolineCost { get; set; }
        
        public void LetPassengersIn(int numberOfPassengers)
        {
            NumberOfPassengers += numberOfPassengers;
        }

        public void ReleasePassengers(int numberOfPassengers)
        {
            NumberOfPassengers -= numberOfPassengers;
        }

        public void GasolineСosts(int gasolinePrise)
        {
            if (DistanceTraveled >= 0)
            {
                GasolineCost = DistanceTraveled*gasolinePrise;
            }
            else
            {
                GasolineCost = 0;
            }
        }

    }
}