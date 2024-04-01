using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1
{
    public class FeaturesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<FeatureWrapper> _featureWrappers;

        public ObservableCollection<FeatureWrapper> FeatureWrappers
        {
            get
            {
                return _featureWrappers;
            }
            set
            {
                _featureWrappers = value;
                OnPropertyChanged();
            }
        }

        public FeaturesViewModel()
        {
            InitializeFeatureWrappers();
        }

        private void InitializeFeatureWrappers()
        {
            FeatureWrappers = new ObservableCollection<FeatureWrapper>
            {
            new SpoilerFeature(),
            new HardTireFeature(),
            new SpoilerFeature(),
            new HardTireFeature(),
            new SpoilerFeature(),
            new HardTireFeature(),
            new SpoilerFeature(),
            new HardTireFeature(),
            };
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
