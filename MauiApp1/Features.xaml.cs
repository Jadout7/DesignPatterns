
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

        await DisplayAlert("Feature Adding", "Car with feature Exhaust added to cart", "OK");
        Application.Current.MainPage = new Showroom();
    }

    async void OnAddSportTiresClicked(object sender, EventArgs e)
    {
        Car featureCar = new SportsTires(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Car with feature Sports Tires added to cart", "OK");
        Application.Current.MainPage = new Showroom();
    }

    async void OnAddSpoilerClicked(object sender, EventArgs e)
    {
        Car featureCar = new Spoiler(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Car with feature Spoiler added to cart", "OK");
        Application.Current.MainPage = new Showroom();
    }

    async void OnAddUnderglowClicked(object sender, EventArgs e)
    {
        Car featureCar = new Underglow(newCar);
        Order.Instance.AddCar(featureCar);

        await DisplayAlert("Feature Adding", "Car with feature Underglow added to cart", "OK");
        Application.Current.MainPage = new Showroom();
    }

    async void OnContinueClicked(object sender, EventArgs e)
    {
        Order.Instance.AddCar(newCar);

        await DisplayAlert("Car Adding", "Car with no additional features added to cart", "OK");
        Application.Current.MainPage = new Showroom();
    }

}