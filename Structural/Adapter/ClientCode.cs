using Structural.Adapter.Adaptee;
using Structural.Adapter.Adapter;
using Structural.Adapter.ITarget;

namespace Structural.Adapter
{
    public class GasStation
    {
        public static void Refuel(Car car)
        {
            Car.Refuel();
        }
    }

    public class ElectricCharger
    {
        public static void Charge(IElectricCar electricCar)
        {
            electricCar.Charge();      
        }
    }

    public static class ClientCode
    {
        public static void ClassFittingExample()
        {
            var hybrydCar = new HybridCar();
            GasStation.Refuel(hybrydCar);
            ElectricCharger.Charge(hybrydCar);
        }

        public static void ObjectFittingExample()
        {
            var car = new Car();
            GasStation.Refuel(car);
            var hybrydCar = new HybridCar2(car);
            ElectricCharger.Charge(hybrydCar);
        }
    }
}
