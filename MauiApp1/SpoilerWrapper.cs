public class SpoilerWrapper : FeatureWrapper
{
    private float SpoilerFeaturePrice { get; set; }

    public SpoilerWrapper(ICar wrappedCar, float spoilerFeaturePrice) : base(wrappedCar)
    {
        SpoilerFeaturePrice = spoilerFeaturePrice;
    }

    public override float GetPrice()
    {
        return SpoilerFeaturePrice;
    }

    public float GetTotalPrice()
    {
        return base.GetPrice() + GetPrice();
    }
}
