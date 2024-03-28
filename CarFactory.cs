using System;

public class CarFactory
{
    public Car CreateCar(Car carType)
    {
        if (carType == null)
        {
            return null;
        }

        // TODO: Ask about whether a simple factory, factory method, or abstract factory should be used.

        if (carType is ElectricCar)
        {
            return new ElectricCar(carType.Vin, carType.Brand, carType.Model, carType.YearMade, carType.Price);
        }
        else if (carType is PetrolCar)
        {
            return new PetrolCar(carType.Vin, carType.Brand, carType.Model, carType.YearMade, carType.Price);
        }
        else if (carType is HydrogenCar)
        {
            return new HydrogenCar(carType.Vin, carType.Brand, carType.Model, carType.YearMade, carType.Price);
        }
        else
        {
            return null;
        }
    }
}
