public class TireWrapper : FeatureWrapper
{
    private float TireFeaturePrice { get; set; }
    private float TireFeatureTax { get; set; }

    public TireWrapper(ICar wrappedCar, float tireFeaturePrice, float tireFeatureTax) : base(wrappedCar)
    {
        TireFeaturePrice = tireFeaturePrice;
        TireFeatureTax = tireFeatureTax;
    }

    public override float GetPrice()
    {
        return TireFeaturePrice;
    }
}