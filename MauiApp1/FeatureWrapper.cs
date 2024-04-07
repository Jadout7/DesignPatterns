﻿public class FeatureWrapper : ICar
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

    public string GetImageSource()
    {
        return Car.GetImageSource();
    }
}