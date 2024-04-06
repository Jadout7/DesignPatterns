using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class ShoppingCart : ContentPage
{
    public ShoppingCart()
    {
        InitializeComponent();
        BindingContext = new ShoppingCartViewModel(); // Assuming you have a view model named MainPageViewModel
    }
}