using System;

public class HardTireFeature : FeatureWrapper
{
    public HardTireFeature()
    {
        Title = "Hard Tires";
        ImageSource = "../hardtire.png";
        Price = 800;
        TaxAmount = 80;
    }

    public void IncreaseTraction()
    {
        // TODO: Implement traction logic
    }
}
