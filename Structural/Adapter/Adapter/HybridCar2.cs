using Structural.Adapter.Adaptee;
using Structural.Adapter.ITarget;

namespace Structural.Adapter.Adapter
{
    // Adapter - Object fitting example
    public class HybridCar2 : IElectricCar
    {
        private readonly Car _car;

        public HybridCar2(Car car)
        {
            _car = car;
        }

        public void Refuel()
        {
            Car.Refuel();
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
        }
    }
}
