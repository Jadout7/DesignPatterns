using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class ShoppingCart : ContentPage
{
    public ShoppingCart()
    {
        InitializeComponent();

        var viewModel = new ShoppingCartViewModel { Order = Order.Instance };
        BindingContext = viewModel;
    }

    private void ToPayment_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new PaymentSelect();

    }

    private void CancelCart_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Showroom();
    }
}