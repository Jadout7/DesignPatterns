using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;

namespace MauiApp1;

public class ShoppingCartViewModel : INotifyPropertyChanged
{
    private Order _order;

    public Order Order
    {
        get => _order;
        set
        {
            _order = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public float TotalPrice => Order.Instance?.GetTotalPrice() ?? 0; 

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

