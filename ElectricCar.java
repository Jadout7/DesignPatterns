public class ElectricCar extends Car {
    private int batteryPercentage;

    public ElectricCar(long VIN, String brand, String model, int yearMade, float price, int batteryPercentage) {
        super(VIN, brand, model, yearMade, price);
        this.batteryPercentage = batteryPercentage;
    }

    public int getBatteryPercentage() {
        return batteryPercentage;
    }

    public void setBatteryPercentage(int batteryPercentage) {
        this.batteryPercentage = batteryPercentage;
    }
}