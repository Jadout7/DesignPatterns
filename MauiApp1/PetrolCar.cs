using System;

public class PetrolCar : Car
{
    private int _litresTank;
    public int LitresTank { get; set; }
    public PetrolCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
        ImageSource = "../petrol.jpeg";
        LitresTank = 50;
        _litresTank = LitresTank;
    }

    //public override float CalculateTax()
    //{
    //    // Implement tax calculation for petrol cars
    //    return 0;
    //}
}