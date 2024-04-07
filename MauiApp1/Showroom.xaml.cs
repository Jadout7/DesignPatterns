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

        Application.Current.MainPage = new Features(selectedCar);
    }
}
