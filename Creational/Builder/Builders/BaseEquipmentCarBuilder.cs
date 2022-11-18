﻿using Creational.Builder.Enums;
using Creational.Builder.Products;

namespace Creational.Builder.Builders
{
    public class BaseEquipmentCarBuilder : CarBuilderBase
    {
        public BaseEquipmentCarBuilder()
        {
            Car = new Car(EntertainmentSystemType.None, UpholsteryType.Fabric);
        }
    }
}
