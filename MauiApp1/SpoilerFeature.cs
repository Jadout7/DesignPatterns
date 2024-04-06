using System;

public class SpoilerFeature : FeatureWrapper
{
    public SpoilerFeature()
    {
        Title = "Spoiler";
        ImageSource = "../spoiler.png";
        Price = 500;
        TaxAmount = 50;
    }

    public void IncreaseSpeed()
    {
        // TODO: Implement speed logic
    }
}
