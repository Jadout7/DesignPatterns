using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1;

public partial class Features : ContentPage
{

    public Features()
	{
		InitializeComponent();
    }

    void OnAddExhaustClicked(object sender, EventArgs e)
    {
        // Add the feature to the cart
        // This will depend on your implementation
        DisplayAlert("Feature Adding", "Exhaust Added", "OK");
    }

    void OnAddSportTiresClicked(object sender, EventArgs e)
    {
        // Add the feature to the cart
        // This will depend on your implementation
        DisplayAlert("Feature Adding", "Sport Tires Added", "OK");
    }

    void OnAddSpoilerClicked(object sender, EventArgs e)
    {
        // Add the feature to the cart
        // This will depend on your implementation
        DisplayAlert("Feature Adding", "Spoiler Added", "OK");
    }

    void OnAddUnderglowClicked(object sender, EventArgs e)
    {
        // Add the feature to the cart
        // This will depend on your implementation
        DisplayAlert("Feature Adding", "Underglow Added", "OK");
    }

    void OnContinueClicked(object sender, EventArgs e)
    {
        // Navigate to the order page
        Application.Current.MainPage = new PaymentSelect();
    }
}