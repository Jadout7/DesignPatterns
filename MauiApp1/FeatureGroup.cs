
namespace MauiApp1
{
    public class FeatureGroup
    {
        public string Name { get; set; }
        public List<FeatureWrapper> Features { get; set; }

        public FeatureGroup(string name, List<FeatureWrapper> features)
        {
            Name = name;
            Features = features;
        }
    }
}
