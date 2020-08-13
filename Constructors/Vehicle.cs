namespace Constructors
{
    class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle(string registrationNumber)
        {
            System.Console.WriteLine("Vehicle Constructor {0}", registrationNumber);
            _registrationNumber = registrationNumber;
        }
    }
}