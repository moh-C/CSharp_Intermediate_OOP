namespace Constructors
{
    class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            System.Console.WriteLine("Car Constructor {0}", registrationNumber);
        }
    }
}