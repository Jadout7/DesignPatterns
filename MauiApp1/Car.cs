using System;

public abstract class Car
{
    private long vin;
    private string brand;
    private string model;
    private int yearMade;
    private float price;
    private List<FeatureWrapper> featureWrappers;

    public Car(long vin, string brand, string model, int yearMade, float price)
    {
        this.vin = vin;
        this.brand = brand;
        this.model = model;
        this.yearMade = yearMade;
        this.price = price;
        this.featureWrappers = new List<FeatureWrapper>();
    }

    public long Vin
    {
        get { return vin; }
        set { vin = value; }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int YearMade
    {
        get { return yearMade; }
        set { yearMade = value; }
    }

    public float Price
    {
        get { return price; }
        set { price = value; }
    }

    public float CalculateTax()
    {
        // Calculation logic for tax
        return 0;
    }

    public void AddFeature(FeatureWrapper feature)
    {
        featureWrappers.Add(feature);
        feature.Car = this;
    }

    public void RemoveFeature(FeatureWrapper feature)
    {
        featureWrappers.Remove(feature);
    }

    public float GetPriceWithTax()
    {
        return Price + CalculateTax();
    }
}
