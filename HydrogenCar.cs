using System;

public class HydrogenCar : Car
{
    public double HydrogenTankPercentage { get; set; }

    public HydrogenCar(long vin, string brand, string model, int yearMade, float price)
        : base(vin, brand, model, yearMade, price)
    {
        HydrogenTankPercentage = 100.0;
    }

    public double GetHydrogenTankPercentage()
    {
        return HydrogenTankPercentage;
    }

    public void SetHydrogenTankPercentage(double hydrogenTankPercentage)
    {
        HydrogenTankPercentage = hydrogenTankPercentage;
    }

    //TODO: Add FeatureWrappers

    public override float CalculateTax()
    {
        // Implement tax calculation for hydrogen cars
        return 0;
    }
}