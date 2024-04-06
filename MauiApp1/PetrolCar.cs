using System;

public class PetrolCar : Car
{
    public string FuelType { get; set; }

    public PetrolCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
    }
}