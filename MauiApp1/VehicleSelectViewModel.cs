using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MauiApp1
{
    public class VehicleSelectViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private ObservableCollection<Car> _cars;
        public ObservableCollection<Car> Cars 
        {
            get { return _cars; }
            set { _cars = value; } 
        }

        public VehicleSelectViewModel()
        {
            InitializeVehicles();
        }

        private void InitializeVehicles()
        {
            CarFactory factory = new CarFactory();
            var vehicleGroups = new List<VehicleGroup>
            {

                new VehicleGroup("electric", new List<Car>
                {
                    factory.CreateCar("electric"),
                    factory.CreateCar("electric"),
                    factory.CreateCar("electric"),
                    factory.CreateCar("electric")
                }),
                new VehicleGroup("petrol", new List<Car>
                {
                    factory.CreateCar("petrol"),
                    factory.CreateCar("petrol"),
                    factory.CreateCar("petrol"),
                    factory.CreateCar("petrol")
                }),
                new VehicleGroup("hydrogen", new List<Car>
                {
                    factory.CreateCar("hydrogen"),
                    factory.CreateCar("hydrogen"),
                    factory.CreateCar("hydrogen"),
                    factory.CreateCar("hydrogen")
                }),

            };
        }
        

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
}
