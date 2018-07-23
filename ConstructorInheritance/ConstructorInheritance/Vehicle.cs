using System;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            Console.WriteLine("Vehicle being initialized.");
            
        }
        

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

        }
    }
}