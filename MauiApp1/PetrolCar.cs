using System;

public class PetrolCar : Car
{
    public PetrolCar(long vIN, string brand, string model, int yearMade, float price, string fuelType) : base(vIN, brand, model, yearMade, price)
    {
    }

    
    //public override float CalculateTax()
    //{
    //    // Implement tax calculation for petrol cars
    //    return 0;
    //}
}