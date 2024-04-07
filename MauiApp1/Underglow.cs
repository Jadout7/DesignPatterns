using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Underglow : CarDecorator
{
    public Underglow(Car car) : base(car)
    {
        Price = 100;
    }
}

