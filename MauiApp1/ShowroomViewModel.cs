using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1
{
     public class ShowroomViewModel : BindableObject
    {
        private ObservableCollection<Car> _cars;

        public ObservableCollection<Car> Cars
        {
            get => _cars;
            set
            {
                _cars = value;
                OnPropertyChanged(nameof(Cars));
            }
        }

        public ShowroomViewModel()
        {
            Cars = new ObservableCollection<Car>();
            Cars.Add(CarFactory.CreateCar("electric", "Tesla", "Model S", 1234567890, 2022, 10000));
            Cars.Add(CarFactory.CreateCar("electric", "NIO", "ES8", 9876543210, 2021, 35000));
            Cars.Add(CarFactory.CreateCar("electric", "Audi", "e-tron GT", 5678901234, 2020, 6000));

            Cars.Add(CarFactory.CreateCar("hybrid", "Toyota", "Prius", 1357924680, 2022, 20000));
            Cars.Add(CarFactory.CreateCar("hybrid", "Honda", "Insight", 2468013579, 2021, 20000));
            Cars.Add(CarFactory.CreateCar("hybrid", "Lexus", "RX 450h", 9876543210, 2020, 20000));

            Cars.Add(CarFactory.CreateCar("petrol", "Ford", "Mustang", 1234567890, 2022, 20000));
            Cars.Add(CarFactory.CreateCar("petrol", "Chevrolet", "Camaro", 2468013579, 2021, 20000));
            Cars.Add(CarFactory.CreateCar("petrol", "BMW", "M5", 1357924680, 2020, 20000));
        }
    }
}

