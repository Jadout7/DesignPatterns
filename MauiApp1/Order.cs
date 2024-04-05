using System.Collections.Generic;

public class Order
{
    public int OrderNumber { get; set; }
    public string OrderCarType { get; set; }
    public List<Car> cars;

    public Order(int orderNumber, string orderCarType, List<Car> cars)
    {
        OrderNumber = orderNumber;
        OrderCarType = orderCarType;
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        this.cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        this.cars.Remove(car);
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