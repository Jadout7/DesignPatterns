public class PetrolCar : Car
{
    private long Vin;
    private string Brand;
    private string Model;
    private int YearMade;
    private float Price;

    public PetrolCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
        Vin = vin;
        Brand = brand;
        Model = model;
        YearMade = yearMade;
        Price = price;
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
}