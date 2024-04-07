
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1
{
    public class FeaturesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<FeatureGroup> _featureGroups;

        public ObservableCollection<FeatureGroup> FeatureGroups
        {
            get
            {
                return _featureGroups;
            }
            set
            {
                _featureGroups = value;
                OnPropertyChanged();
            }
        }

        public FeaturesViewModel()
        {
            InitializeFeatureGroups();
        }

        private void InitializeFeatureGroups()
        {
            ICar car = new PetrolCar(123456, "Tesla", "Model S", 2022, 100000, 2000, "E90");
            var featureGroups = new List<FeatureGroup>
            {
                new FeatureGroup("Spoilers", new List<FeatureWrapper>
                {
                    new SpoilerWrapper(car, 500, 50),
                    new SpoilerWrapper(car, 600, 60),
                    new SpoilerWrapper(car, 700, 70),
                    new SpoilerWrapper(car, 800, 80),
                }),
                new FeatureGroup("Hard Tires", new List<FeatureWrapper>
                {
                    new TireWrapper(car, 100, 10),
                    new TireWrapper(car, 200, 20),
                    new TireWrapper(car, 300, 30),
                    new TireWrapper(car, 400, 40),
                }),
            };

            FeatureGroups = new ObservableCollection<FeatureGroup>(featureGroups);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
