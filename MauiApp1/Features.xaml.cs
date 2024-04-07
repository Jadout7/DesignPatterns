
namespace MauiApp1;

public partial class Features : ContentPage
{
    private readonly FeaturesViewModel _viewModel;
    // private ICar Selectedcar;

    public Features()  // Put ICar SelecetedCar in the constructor
    {
        InitializeComponent();
        // SelectedCar = new ICar();
        _viewModel = new FeaturesViewModel();
        BindingContext = _viewModel;
    }

    private void OnViewClicked(object sender, EventArgs e)
    {
        var featureWrapper = (sender as Button)?.BindingContext as FeatureWrapper;
        if (featureWrapper != null)
        {
            DisplayAlert("Feature Details", $"VIN: {featureWrapper.GetVin()}\n" +
                $"Total Price: {featureWrapper.GetTotalPrice()}\n" +
                $"Brand: {featureWrapper.GetBrand()}\n" +
                $"Model: {featureWrapper.GetModel()}\n" +
                $"Year Made: {featureWrapper.GetYearMade()}\n" +
                $"Feature Price: {featureWrapper.GetPrice()}\n"
                //$"Feature Tax: {featureWrapper.GetTax()}\n"
                , "OK");
        }
    }

    void OnAddClicked(object sender, EventArgs e)
    {
        // Add the feature to the cart
        // This will depend on your implementation
    }

    void OnContinueClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new PaymentSelect();
        // Application.Current.MainPage = new Features(car);
    }


}
