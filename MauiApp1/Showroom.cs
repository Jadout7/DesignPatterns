using System.Collections.Generic;

public class Showroom
{
    private List<Car> cars;
    private List<Car> soldCars;

    public Showroom(List<Car> cars, List<Car> soldCars)
    {
        this.cars = cars;
        this.soldCars = soldCars;
    }

    //TODO: method to place order

    public List<Car> GetCars()
    {
        return cars;
    }

    public void AddCar(Car car)
    {
        this.cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        cars.Remove(car);
    }

    public List<Car> GetSoldCars()
    {
        return soldCars;
    }
}