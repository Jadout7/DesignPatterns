namespace MauiApp1;

public partial class VehicleSelect : ContentPage
{
	private readonly VehicleSelectViewModel _viewModel;
	VehicleSelectViewModel viewModel;

	public VehicleSelect()
	{
		InitializeComponent();

		var vm = new VehicleSelectViewModel();
        _viewModel = vm;
		BindingContext = vm;
	}

    private void OnViewClicked(object sender, EventArgs e)
	{
		var car = (sender as Button)?.BindingContext as Car;
		if (car != null)
		{
			DisplayAlert("Car Details: ", $"Vin: {car.Vin} \n Brand: {car.Brand} \n Model: {car.Model} \n Year made: {car.YearMade} \n Price: {car.Price:C}","OK");
		}
	}

    private void OnSelectClicked(object sender, EventArgs e)
    {
		var car = (sender as Button)?.BindingContext as Car;
		var addToCart = new Order();
		addToCart.AddItem(car);
    }
}