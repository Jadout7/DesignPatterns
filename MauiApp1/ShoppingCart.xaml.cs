using MauiApp1.ViewModel;
using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class ShoppingCart : ContentPage
{
    Order carOrder = new Order();
    List<Car> cars = new List<Car>();

    public ShoppingCart()
	{
        PetrolCar tempCar = new PetrolCar(541541511, "Mazda", "X9", 1999, 20000, "Octane 75");
        PetrolCar tempCar2 = new PetrolCar(541541511, "BMW", "X6", 1999, 80000, "Octane 75");
        PetrolCar tempCar3 = new PetrolCar(541541511, "Porsche", "911", 2009, 80000, "Octane 75");

        carOrder.AddItem(tempCar);
        carOrder.AddItem(tempCar2);
        carOrder.AddItem(tempCar3);
        cars.Add(tempCar);
        cars.Add(tempCar2);
        cars.Add(tempCar3);

        InitializeComponent();
        BindingContext = new ShoppingCartViewModel(); // Assuming you have a view model named MainPageViewModel
    }


    public void GetTotalCarBrands()
    {
        if (carOrder == null)
        {
            //No cars in cart
        }
        else
        {
            foreach (Car car in cars) {
                
            }
        }
    }
}