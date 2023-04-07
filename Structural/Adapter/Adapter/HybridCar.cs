using Structural.Adapter.Adaptee;
using Structural.Adapter.ITarget;

namespace Structural.Adapter.Adapter
{
    // Adapter - Class fitting example
    public class HybridCar : Car, IElectricCar
    {
        public void Charge()
        {
            Console.WriteLine("Charging...");
        }
    }
}
