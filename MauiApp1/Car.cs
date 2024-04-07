public abstract class Car : ICar
{
    public long Vin;
    public string Brand;
    public string Model;
    public int YearMade;
    public float Price;
    public float Tax;
    public string ImageSource;

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

    public virtual float GetTax()
    {
        return Tax;
    }

    public virtual string GetImageSource()
    {
        string sanitizedModel = Model.Replace(" ", "_").ToLower();
        return $"../{sanitizedModel.Replace("-", "_")}.jpg";
    }

    public abstract float GetTotalPrice();
}