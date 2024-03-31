using System.Collections.Generic;

class Order
{
    private List<Car> cars;

    public Order()
    {
        cars = new List<Car>();
    }

    public void AddItem(Car car)
    {
        this.cars.Add(car);
    }

    public float GetTotalPrice()
    {
        float totalPrice = 0;
        foreach (Car car in cars)
        {
            totalPrice += car.Price;
        }
        return totalPrice;
    }

    public void Pay()
    {
        // Implement the payment process

    }
}