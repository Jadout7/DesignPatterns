using System;

public class FeatureWrapper
{
    public Car Car { get; set; }
    private double Price;
    private double TaxAmount;

    public FeatureWrapper(Car car, double price, double taxAmount)
    {
        this.Car = car;
        this.Price = price;
        this.TaxAmount = taxAmount;
    }

    public Car GetCar()
    {
        return Car;
    }

    public void SetCar(Car car)
    {
        Car = car;
    }

    public double GetPrice()
    {
        return Price;
    }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public double GetTaxAmount()
    {
        return TaxAmount;
    }

    public void SetTaxAmount(double taxAmount)
    {
        TaxAmount = taxAmount;
    }
}
