public abstract class Car : ICar
{
    public long Vin;
    public string Brand;
    public string Model;
    public int YearMade;
    public float Price;

    public Car(long vin, string brand, string model, int yearMade, float price)
    {
        Vin = vin;
        Brand = brand;
        Model = model;
        YearMade = yearMade;
        Price = price;
    }

    public virtual long GetVin()
    {
        return Vin;
    }

    public virtual string GetBrand()
    {
        return Brand;
    }

    public virtual string GetModel()
    {
        return Model;
    }

    public virtual int GetYearMade()
    {
        return YearMade;
    }

    public virtual float GetPrice()
    {
        return Price;
    }

    public virtual string GetImageSource()
    {
        string sanitizedModel = Model.Replace(" ", "_").ToLower();
        return $"../{sanitizedModel.Replace("-", "_")}.jpg";
    }
}