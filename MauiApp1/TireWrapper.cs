public class TireWrapper : FeatureWrapper
{
    private float TireFeaturePrice { get; set; }

    public TireWrapper(ICar wrappedCar, float tireFeaturePrice) : base(wrappedCar)
    {
        TireFeaturePrice = tireFeaturePrice;
    }

    public override float GetPrice()
    {
        return TireFeaturePrice;
    }

    public float GetTotalPrice()
    {
        return base.GetPrice() + GetPrice();
    }
}