using System;

public abstract class Car
{
    private long _vin;
    public long Vin { get; set; }
    private string _brand;
    public string Brand { get; set; }
    private string _model;
    public string Model { get; set; }
    private int yearMade;
    public int YearMade { get; set; }
    private float price;
    public float Price {  get; set; }
    public string ImageSource { get; set; }
    private List<FeatureWrapper> featureWrappers;

    public Car(long vin, string brand, string model, int yearMade, float price)
    {
        this.Vin = vin;
        this.Brand = brand;
        this.Model = model;
        this.YearMade = yearMade;
        this.Price = price;
        this.featureWrappers = new List<FeatureWrapper>();
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
