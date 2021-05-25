using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor monitor = new TemperatureSensor();
            TemperatureReporter reporter = new TemperatureReporter();
            reporter.StartReporting(monitor);
            monitor.GetTemperature();
        }
    }
}