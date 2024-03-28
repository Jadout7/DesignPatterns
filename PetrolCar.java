public class PetrolCar extends Car {
    private double fuelPercentage;

    public PetrolCar(long VIN, String brand, String model, int yearMade, float price) {
        super(VIN, brand, model, yearMade, price);
        this.fuelPercentage = 100.0;
    }

    public double getFuelPercentage() {
        return fuelPercentage;
    }

    public void setFuelPercentage(double fuelPercentage) {
        this.fuelPercentage = fuelPercentage;
    }

    @Override
    public float calculateTax() {
        // Implement tax calculation for petrol cars
        return 0;
    }
}