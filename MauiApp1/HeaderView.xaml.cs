namespace MauiApp1;

public partial class HeaderView : ContentView
{
	public HeaderView()
	{
		InitializeComponent();
	}

    void OnVehiclesClicked(object sender, EventArgs e)
    {
        // Navigate to the vehicle selection page
        Application.Current.MainPage = new MainPage();
    }

    void OnFeaturesClicked(object sender, EventArgs e)
    {
        //Navigate to Feature Selection page
        Application.Current.MainPage = new Features();
    }

    void OnCartClicked(object sender, EventArgs e)
    {
        // Navigate to the cart page
        Application.Current.MainPage = new ShoppingCart();
    }
}