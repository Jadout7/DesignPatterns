public class HydrogenCar : Car
{
    private long Vin;
    private string Brand;
    private string Model;
    private int YearMade;
    private float Price;
    private float Tax;
    public int TankPressure { get; set; }

    public HydrogenCar(long vin, string brand, string model, int yearMade, float price, float tax, int tankPressure)
    {
        Vin = vin;
        Brand = brand;
        Model = model;
        YearMade = yearMade;
        Price = price;
        Tax = tax;
        TankPressure = tankPressure;
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