public class HydrogenCar extends Car {
    private double hydrogenTankPercentage;

    public HydrogenCar(long VIN, String brand, String model, int yearMade, float price) {
        super(VIN, brand, model, yearMade, price);
        this.hydrogenTankPercentage = 100.0;
    }

    public double getHydrogenTankPercentage() {
        return hydrogenTankPercentage;
    }

    public void setHydrogenTankPercentage(double hydrogenTankPercentage) {
        this.hydrogenTankPercentage = hydrogenTankPercentage;
    }


    @Override
    public float calculateTax() {
        // Implement tax calculation for hydrogen cars
        return 0;
    }
}