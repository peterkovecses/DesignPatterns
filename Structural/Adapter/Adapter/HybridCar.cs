using Structural.Adapter.Adaptee;
using Structural.Adapter.ITarget;

namespace Structural.Adapter.Adapter
{
    /// <summary>
    /// Class fitting example
    /// </summary>
    public class HybridCar : Car, IElectricCar
    {
        public void Charge()
        {
            Console.WriteLine("Charging...");
        }
    }
}
