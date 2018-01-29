using EventServiceLibrary;
using System;

namespace EventService.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventServiceInstance = new EventServiceLibrary.EventService();
            eventServiceInstance.WriteMessage("My Application started");

            Console.ReadLine();
        }
    }
}
