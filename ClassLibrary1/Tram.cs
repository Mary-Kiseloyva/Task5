using System;

namespace task5
{
    public class Tram : PublicTransport
    {
        public int Voltage { get; set; }
        
        public string RouteNumber { get; set; }

        private bool isRunning { get; set; }

        private bool isStopped { get; set; }
        
        public void Start()
        {
            if (isRunning)
            {
                Console.WriteLine("Трамвай уже в движении.");
            }
            else
            {
                Console.WriteLine("Трамвай начал движение.");
                isRunning = true;
                isStopped = false;
            }
        }

        public void Stop()
        {
            if (isStopped)
            {
                Console.WriteLine("Трамвай уже остановлен.");
            }
            else
            {
                Console.WriteLine("Трамвай остановился.");
                isRunning = false;
                isStopped = true;
            }
        }
    }
}