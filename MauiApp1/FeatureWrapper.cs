public class FeatureWrapper : ICar
{
    private readonly ICar Car;

    public FeatureWrapper(ICar car)
    {
        Car = car;
    }

    public long GetVin()
    {
        return Car.GetVin();
    }

    public string GetBrand()
    {
        return Car.GetBrand();
    }

    public string GetModel()
    {
        return Car.GetModel();
    }

    public int GetYearMade()
    {
        return Car.GetYearMade();
    }

    public virtual float GetPrice()
    {
        return Car.GetPrice();
    }

    public virtual float GetTax()
    {
        return Car.GetTax();
    }

    public string GetImageSource()
    {
        return Car.GetImageSource();
    }
    public virtual float GetTotalPrice()
    {
        return Car.GetTotalPrice();
    }
}