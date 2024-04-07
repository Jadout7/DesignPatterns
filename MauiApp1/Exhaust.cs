using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exhaust : CarDecorator
{
    public Exhaust(Car car) : base(car)
    {
        Price = 500;
    }
}

