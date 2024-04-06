namespace MauiApp1;


public class VehicleGroup
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }

    public VehicleGroup(string name, List<Car> cars)
    {
        Name = name;
        Cars = cars;
    }

}