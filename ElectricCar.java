public class ElectricCar extends Car {
    private double batteryPercentage;

    public ElectricCar(long vin, String brand, String model, int yearMade, float price) {
        super(vin, brand, model, yearMade, price);
        this.batteryPercentage = 100.0;
    }

    public double getBatteryPercentage() {
        return batteryPercentage;
    }

    public void setBatteryPercentage(double batteryPercentage) {
        this.batteryPercentage = batteryPercentage;
    }

    //TODO: Add featureWrappers

    @Override
    public float calculateTax() {
        // Implement tax calculation for electric cars
        return 0;
    }
}