using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace MauiApp1.ViewModel;

public class ShoppingCartViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Car> _cars;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Car> Cars
    {
        get { return _cars; }
        set
        {
            _cars = value;
            OnPropertyChanged(nameof(Cars));
        }
    }

    public ShoppingCartViewModel()
    {
        Cars = new ObservableCollection<Car>(); // Initialize an empty collection
        LoadCars();
    }
    private void LoadCars()
    {
        // Load cars from data source, API, database, etc.
        // For example, you can simulate loading from a data source here:
        Cars.Add(new PetrolCar(978786483,"Bmw", "X6", 1999, 99990, "Octane95"));
        Cars.Add(new PetrolCar(978786483, "Bmw", "X6", 1999, 99990, "Octane95"));
        Cars.Add(new PetrolCar(978786483, "Bmw", "X6", 1999, 99990, "Octane95"));
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

