using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class ShoppingCart : ContentPage
{
    Order order = new Order();
    public ShoppingCart()
    {
        InitializeComponent();

        // Create some sample data
        order.Cars.Add(new PetrolCar(123456, "Toyota", "Camry", 2022, 25000));
        order.Cars.Add(new PetrolCar(789012, "Honda", "Accord", 2023, 27000));
        order.Cars.Add(new ElectricCar(545845, "Zeus", "Zap", 2022, 1));
        order.Cars.Add(new HydrogenCar(12123, "Hydro", "Hyrdo2Epic", 2022, 1000000));

        var viewModel = new ShoppingCartViewModel { Order = order };
        BindingContext = viewModel;
    }

    private async void ToPayment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaymentSelect(order));
    }

    private async void CancelCart_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}