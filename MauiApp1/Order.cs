using System.ComponentModel;

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

    private float _totalPrice;
    public float TotalPrice
    {
        get { return _totalPrice; }
        set
        {
            if (_totalPrice != value)
            {
                _totalPrice = value;
                OnPropertyChanged(nameof(TotalPrice));
            }
        }
    }

    public List<Car> Cars { get; set; }
    public List<FeatureWrapper> Features { get; set; }

    private Order()
    {
        Cars = new List<Car>();
        Features = new List<FeatureWrapper>();
    }

    public void AddFeature(FeatureWrapper feature)
    {
        Features.Add(feature);
        TotalPrice += feature.GetPrice(); // Add feature price to the total price
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
            totalPrice += car.Price;
        }
        foreach (FeatureWrapper feature in Features)
        {
            totalPrice += feature.GetPrice();
        }
        return totalPrice;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}