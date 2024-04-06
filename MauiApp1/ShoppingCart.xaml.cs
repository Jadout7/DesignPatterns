using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class ShoppingCart : ContentPage
{
    public ShoppingCart()
    {
        InitializeComponent();

        // Create some sample data
        Order.Instance.Cars.Add(new PetrolCar(123456, "Toyota", "Camry", 2022, 25000));
        Order.Instance.Cars.Add(new PetrolCar(789012, "Honda", "Accord", 2023, 27000));
        Order.Instance.Cars.Add(new ElectricCar(545845, "Zeus", "Zap", 2022, 1));
        Order.Instance.Cars.Add(new HydrogenCar(12123, "Hydro", "Hyrdo2Epic", 2022, 1000000));

        var viewModel = new ShoppingCartViewModel { Order = Order.Instance };
        BindingContext = viewModel;
    }

    private async void ToPayment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaymentSelect());
    }

    private async void CancelCart_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}