using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class ShoppingCart : ContentPage
{
    public ShoppingCart()
	{
        InitializeComponent();
        BindingContext = new ShoppingCartViewModel(); // Assuming you have a view model named MainPageViewModel
    }

    // Method to get the collection of PetrolCars
/*    private List<PetrolCar> GetPetrolCars()
    {
        // Implement logic to fetch PetrolCar instances, for example from a database
        // This is a dummy implementation
        return new List<PetrolCar>
        {
            new PetrolCar(123456, "Brand1", "Model1", 2022, 20000f, "Petrol"),
            new PetrolCar(789012, "Brand2", "Model2", 2023, 25000f, "Petrol")
        };
    }*/
}