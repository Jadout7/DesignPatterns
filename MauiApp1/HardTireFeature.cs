using System;

public class HardTireFeature : FeatureWrapper
{
    public HardTireFeature(Car car, double price, double taxAmount) : base(car, price, taxAmount)
    {
    }

    public void IncreaseTraction()
    {
        // TODO: Implement traction logic
    }
}
