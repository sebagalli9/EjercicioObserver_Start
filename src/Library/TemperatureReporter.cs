using System;

namespace Observer
{
    /* La clase TemperatureReporter es del tipo IObserver, dado que esta clase depende
       de la clase TemperatureSensor para que la misma le notifique los cambios en su estado.
    */
    public class TemperatureReporter : IObserver
    {
        private bool first;
        private Temperature last;
        private TemperatureSensor provider;

        public void StartReporting(TemperatureSensor provider)
        {
            this.provider = provider;
            this.first = true;
            this.provider.Subscribe(this);
        }

        public void StopReporting()
        {
            this.provider.Unsubscribe(this);
        }

        public void Update()
        {
            Console.WriteLine($"The temperature is {this.provider.Current.Degrees}°C at {this.provider.Current.Date:g}");
            if (first)
            {
                last = this.provider.Current;
                first = false;
            }
            else
            {
                Console.WriteLine($"   Change: {this.provider.Current.Degrees - last.Degrees}° in " +
                    $"{this.provider.Current.Date.ToUniversalTime() - last.Date.ToUniversalTime():g}");
            }
        }

        
    }
}