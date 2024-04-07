using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class CarDecorator : Car
{
    protected Car _car;

    public CarDecorator(Car car) : base(car.Vin, car.Brand, car.Model, car.YearMade, car.Price)
    {
        _car = car;
    }

    public float GetPriceWithTaxFromBase()
    {
        return _car.GetPriceWithTax();
    }

    public string ImageSourceFromBase
    {
        get { return _car.ImageSource; }
    }
}
