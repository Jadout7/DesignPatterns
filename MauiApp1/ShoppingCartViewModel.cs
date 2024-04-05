using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;

namespace MauiApp1;

public partial class ShoppingCartViewModel : ObservableObject
{
    public event PropertyChangedEventHandler PropertyChanged;

    [ObservableProperty]
    private ObservableCollection<Order> _orderGroups;

    public ShoppingCartViewModel()
    {
        var car = new ObservableCollection<Order>();
        {
            new Order(1, "Petrol", new List<Car>
            {
                new PetrolCar(1,"Brand","CarModel",2021,12000,"RocketFuel"),
                new PetrolCar(2, "Brand2", "CarModel2", 2021, 16000, "E90")
            });
        }

        OrderGroups = new ObservableCollection<Order>(car);
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

