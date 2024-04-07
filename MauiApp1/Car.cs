using System;

public abstract class Car
{
    public long Vin { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int YearMade { get; set; }

    public float Price {  get; set; }

    public Car(long vin, string brand, string model, int yearMade, float price)
    {
        this.Vin = vin;
        this.Brand = brand;
        this.Model = model;
        this.YearMade = yearMade;
        this.Price = price;
    }

    public string ImageSource
    {
        get {
            string sanitizedModel = Model.Replace(" ", "_").ToLower();
            return $"../{sanitizedModel.Replace("-", "_")}.jpg";
        }
    }
}