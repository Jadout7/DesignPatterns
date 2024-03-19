public class ElectricCar extends Car {
    private int batteryPercentage;

    public ElectricCar(long vin, String brand, String model, int yearMade, float price, int batteryPercentage) {
        super(vin, brand, model, yearMade, price);
        this.batteryPercentage = batteryPercentage;
    }

    public int getBatteryPercentage() {
        return batteryPercentage;
    }

    public void setBatteryPercentage(int batteryPercentage) {
        this.batteryPercentage = batteryPercentage;
    }

    @Override
    public float calculateTax() {
        // Implement tax calculation for electric cars
        return 0;
    }
}