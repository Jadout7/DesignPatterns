public class ElectricCar : Car
{
    private long Vin;
    private string Brand;
    private string Model;
    private int YearMade;
    private float Price;
    private float Tax;
    public double BatteryPercentage { get; set; }

    public ElectricCar(long vin, string brand, string model, int yearMade, float price, float tax, double batteryPercentage)
    {
        Vin = vin;
        Brand = brand;
        Model = model;
        YearMade = yearMade;
        Price = price;
        Tax = tax;
        BatteryPercentage = batteryPercentage;
    }

    public override long GetVin()
    {
        return Vin;
    }

    public override string GetBrand()
    {
        return Brand;
    }

    public override string GetModel()
    {
        return Model;
    }

    public override int GetYearMade()
    {
        return YearMade;
    }

    public override float GetPrice()
    {
        return Price;
    }

    public override float GetTax()
    {
        return Tax;
    }

    public override float GetTotalPrice()
    {
        return Price + Tax;
    }
}