using System;

public class PetrolCar : Car
{
    private long Vin { get; set; }
    private string Brand { get; set; }
    private string Model { get; set; }
    private int YearMade { get; set; }
    private float Price { get; set; }
    private string FuelType { get; set; }

    public PetrolCar(long vIN, string brand, string model, int yearMade, float price, string fuelType) : base(vIN, brand, model, yearMade, price)
    {
    }

    
    //public override float CalculateTax()
    //{
    //    // Implement tax calculation for petrol cars
    //    return 0;
    //}
}