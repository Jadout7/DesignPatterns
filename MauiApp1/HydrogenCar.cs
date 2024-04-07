public class HydrogenCar : Car
{
    private long Vin;
    private string Brand;
    private string Model;
    private int YearMade;
    private float Price;
    private float Tax;
    public int TankPressure { get; set; }

    public HydrogenCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
    }
}