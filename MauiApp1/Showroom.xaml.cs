namespace MauiApp1;


public partial class Showroom : ContentPage
{
    public Showroom()
    {
        InitializeComponent();
    }

    private void AddToList_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var selectedCar = (Car)button.CommandParameter;
        Order.Instance.Cars.Add(selectedCar);

        float totalPrice = Order.Instance.GetTotalPrice();

        string message = $"Car added to order!\nTotal Price: {totalPrice:C}";
        DisplayAlert("Order Confirmation", message, "OK");
    }
}
