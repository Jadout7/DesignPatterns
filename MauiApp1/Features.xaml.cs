namespace MauiApp1;

public partial class Features : ContentPage
{
	public Features()
	{
		InitializeComponent();
	}

    private void OnViewClicked(object sender, EventArgs e)
    {
        var featureWrapper = (sender as Button)?.BindingContext as FeatureWrapper;
        if (featureWrapper != null)
        {
            DisplayAlert("Feature Details", $"Title: {featureWrapper.Title}\nTotal Price: {featureWrapper.TotalPrice:C}", "OK");
        }
    }

    void OnAddClicked(object sender, EventArgs e)
    {
        // Add the feature to the cart
        // This will depend on your implementation
    }

    void OnContinueClicked(object sender, EventArgs e)
    {
        // Navigate to the order page
        Application.Current.MainPage = new PaymentSelect();
    }
}