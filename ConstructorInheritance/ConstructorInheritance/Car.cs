using System;

namespace ConstructorInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
        :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised. {0}", registrationNumber);
            Console.ReadLine();


        }
        
    }
}