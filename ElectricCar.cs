using System;

public class ElectricCar : Car
{
    public double BatteryPercentage { get; set; }

    public ElectricCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
        this.BatteryPercentage = 100.0;
    }

    public double GetBatteryPercentage()
    {
        return this.BatteryPercentage;
    }

    public void SetBatteryPercentage(double batteryPercentage)
    {
        this.BatteryPercentage = batteryPercentage;
    }

    //TODO: Add featureWrappers

    public override float CalculateTax()
    {
        // Implement tax calculation for electric cars
        return 0;
    }
}
