using System;

public class PetrolCar : Car
{
<<<<<<< HEAD
    public string FuelType { get; set; }

    public PetrolCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
=======
    private int _litresTank;
    public int LitresTank { get; set; }
    public PetrolCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
        LitresTank = 50;
        _litresTank = LitresTank;
>>>>>>> NathanDoingAndreiWork
    }
}