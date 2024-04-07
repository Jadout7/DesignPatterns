
using System;

public abstract class Car : ICar
{
    public long Vin { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int YearMade { get; set; }

    public float Price { get; set; }
    private List<FeatureWrapper> featureWrappers;

    public Car(long vin, string brand, string model, int yearMade, float price)
    {
        this.Vin = vin;
        this.Brand = brand;
        this.Model = model;
        this.YearMade = yearMade;
        this.Price = price;
    }

    public float CalculateTax()
    {
        // Calculation logic for tax
        return 0;
    }

    public void RemoveFeature(FeatureWrapper feature)
    {
        featureWrappers.Remove(feature);
    }

    public float GetPriceWithTax()
    {
        return Price + CalculateTax();
    }

    public long GetVin()
    {
        throw new NotImplementedException();
    }

    public string GetBrand()
    {
        throw new NotImplementedException();
    }

    public string GetModel()
    {
        throw new NotImplementedException();
    }

    public int GetYearMade()
    {
        throw new NotImplementedException();
    }

    public float GetPrice()
    {
        throw new NotImplementedException();
    }

    public float GetTax()
    {
        throw new NotImplementedException();
    }

    public string GetImageSource()
    {
        throw new NotImplementedException();
    }

    public float GetTotalPrice()
    {
        throw new NotImplementedException();
    }

    public string ImageSource
    {
        get
        {
            string sanitizedModel = Model.Replace(" ", "_").ToLower();
            return $"../{sanitizedModel.Replace("-", "_")}.jpg";
        }
    }
}
