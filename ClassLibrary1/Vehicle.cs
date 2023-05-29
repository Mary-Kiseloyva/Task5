namespace task5
{
    public interface Vehicle
    {
        int Fare { get; set; }
        
        void LetPassengersIn(int numberOfPassengers);
        void ReleasePassengers(int numberOfPassengers);
    }
}