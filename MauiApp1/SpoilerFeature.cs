public class SpoilerWrapper : FeatureWrapper
{
    private float SpoilerFeaturePrice { get; set; }
    private float SpoilerFeatureTax { get; set; }

    public SpoilerWrapper(ICar wrappedCar, float spoilerFeaturePrice, float spoilerFeatureTax) : base(wrappedCar)
    {
        SpoilerFeaturePrice = spoilerFeaturePrice;
        SpoilerFeatureTax = spoilerFeatureTax;
    }

    public override float GetPrice()
    {
        return SpoilerFeaturePrice;
    }

    public override float GetTax()
    {
        return SpoilerFeatureTax;
    }

    public override float GetTotalPrice()
    {
        return base.GetPrice() + GetPrice() + base.GetTax() + GetTax();
    }
}
