using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Spoiler : CarDecorator
{
    public Spoiler(Car car) : base(car)
    {
        Price += 300; 
    }
}
