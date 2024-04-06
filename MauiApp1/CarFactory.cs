namespace MauiApp1;
public class CarFactory
{
    public CarFactory()
    {
    }

    public Car CreateCar(string carType)
    {
        carType = carType.ToLower();
        switch (carType)
        {
            case "petrol":
                return new PetrolCar(12345, "vw", "beetle", 2013, 10000f);
            case "electric":
                return new ElectricCar(12345, "tesla", "Y", 2015, 20000f);
            case "hydrogen":
                return new HydrogenCar(09876, "toyota", "spaceCar", 2013, 30000f);
            default:
                return null;

        }
    }
}
