using Structural.Adapter.Adaptee;
using Structural.Adapter.ITarget;

namespace Structural.Adapter.Adapter
{
    /// <summary>
    /// Object fitting example
    /// </summary>
    public class HybridCar2 : IElectricCar
    {
        private readonly Car _car;

        public HybridCar2(Car car)
        {
            _car = car;
        }

        public void Refuel()
        {
            _car.Refuel();
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
        }
    }
}
