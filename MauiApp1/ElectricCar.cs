using System;
public class ElectricCar : Car
{
    private double _batteryPercentage;
    public double BatteryPercentage { get; set; }
    public ElectricCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
        BatteryPercentage = 100.0;
        _batteryPercentage = BatteryPercentage;
        ImageSource = "../electric.jpeg";
    }

    //TODO: Add featureWrappers

    //public override float CalculateTax()
    //{
    //    // Implement tax calculation for electric cars
    //    return 0;
    //}
}
