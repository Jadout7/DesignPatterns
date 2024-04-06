namespace MauiApp1;


public partial class Showroom : ContentPage
{
    private Order order = new Order();

    public Showroom()
    {
        InitializeComponent();
    }

    private void AddToList_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var selectedCar = (Car)button.CommandParameter;
        order.AddItem(selectedCar);

        // Display the total price of the order in a DisplayAlert
        string message = $"Car added to order!\nTotal Price: {order.GetTotalPrice():C}";
        DisplayAlert("Order Confirmation", message, "OK");
    }
}
