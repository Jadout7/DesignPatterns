namespace MauiApp1;
public static class CarFactory
{
    public static ICar CreateCar(string carType, string brand, string model, long vin, int yearMade, float price)
    {
        switch (carType.ToLower())
        {
            case "electric":
                return new ElectricCar(vin, brand, model, yearMade, price);
            case "hybrid":
                return new HydrogenCar(vin, brand, model, yearMade, price);
            case "petrol":
                return new PetrolCar(vin, brand, model, yearMade, price);
            default:
                throw new ArgumentException("Invalid car type");
        }
    }
}
