public class HardTireFeature extends FeatureWrapper {
    public HardTireFeature(Car car, double price, double taxAmount) {
        super(car, price, taxAmount);
    }

    public void increaseTraction() {
        // implementation to increase traction
    }

    @Override
    public void applyFeature(Car car) {
        // Implement adding a spoiler feature to a car
    }

    @Override
    public void removeFeature(Car car) {
        // Implement removing a spoiler feature from a car
    }
}