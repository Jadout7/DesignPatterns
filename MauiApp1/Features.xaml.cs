
namespace MauiApp1;

public partial class Features : ContentPage
{
    Car newCar;

    public Features(Car selectedCar)
	{
        newCar = selectedCar;
        InitializeComponent();
    }

    async void OnAddExhaustClicked(object sender, EventArgs e)
    {
        Car featureCar = new Exhaust(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Exhaust Added", "OK");
        Application.Current.MainPage = new ShoppingCart();
    }

    async void OnAddSportTiresClicked(object sender, EventArgs e)
    {
        Car featureCar = new SportsTires(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Sport Tires Added", "OK");
        Application.Current.MainPage = new ShoppingCart();
    }

    async void OnAddSpoilerClicked(object sender, EventArgs e)
    {
        Car featureCar = new Spoiler(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Spoiler Added", "OK");
        Application.Current.MainPage = new ShoppingCart();
    }

    async void OnAddUnderglowClicked(object sender, EventArgs e)
    {
        Car featureCar = new Underglow(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Underglow Added", "OK");
        Application.Current.MainPage = new ShoppingCart();
    }

    async void OnContinueClicked(object sender, EventArgs e)
    {
        Order.Instance.AddCar(newCar);

        await DisplayAlert("Car Adding", "Car Added", "OK");
        Application.Current.MainPage = new ShoppingCart();
    }

}