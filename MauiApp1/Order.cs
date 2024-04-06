public class Order
{
    public List<Car> Cars { get; set; }

    public Order()
    {
        Cars = new List<Car>();
    }

    public void Pay()
    {
        Cars.Clear();
    }

    public float getTotalPrice()
    {
        float totalPrice = 0;
        foreach (Car car in Cars) {
            totalPrice += car.Price;
        }
        return totalPrice;
    }
}