
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
                $"Brand: {featureWrapper.GetBrand()}\n" +
                $"Model: {featureWrapper.GetModel()}\n" +
                $"Year Made: {featureWrapper.GetYearMade()}\n" +
                $"Feature Price: {featureWrapper.GetPrice()}\n"
                , "OK");
        }
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        var featureWrapper = (sender as Button)?.BindingContext as FeatureWrapper;

        Order.Instance.AddFeature(featureWrapper);

        string message = $"Feature added to order!\nTotal Price: {Order.Instance.GetTotalPrice():C}";
        DisplayAlert("Order Confirmation", message, "OK");
    }

    void OnContinueClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new PaymentSelect();
    }


}
