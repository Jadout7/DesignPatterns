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
            ICar car = new PetrolCar(123456, "Tesla", "Model S", 2022, 100000);
            var featureGroups = new List<FeatureGroup>
            {
                new FeatureGroup("Spoilers", new List<FeatureWrapper>
                {
                    new SpoilerWrapper(car, 500),
                    new SpoilerWrapper(car, 600),
                    new SpoilerWrapper(car, 700),
                    new SpoilerWrapper(car, 800),
                }),
                new FeatureGroup("Hard Tires", new List<FeatureWrapper>
                {
                    new TireWrapper(car, 100),
                    new TireWrapper(car, 200),
                    new TireWrapper(car, 300),
                    new TireWrapper(car, 400),
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