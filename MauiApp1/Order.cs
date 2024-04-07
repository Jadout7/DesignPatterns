public class Order
{
    private static Order instance;

    public static Order Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Order();
            }
            return instance;
        }
    }

    public List<Car> Cars { get; private set; }

    private Order()
    {
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void Pay()
    {
        Cars.Clear();
    }

    public float GetTotalPrice()
    {
        float totalPrice = 0;
        foreach (Car car in Cars)
        {
            totalPrice += car.GetPriceWithTax();
        }
        return totalPrice;
    }
}