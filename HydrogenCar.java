public class HydrogenCar extends Car {
    private int hydrogenTankPercentage;

    public HydrogenCar(long VIN, String brand, String model, int yearMade, float price, int hydrogenTankPercentage) {
        super(VIN, brand, model, yearMade, price);
        this.hydrogenTankPercentage = hydrogenTankPercentage;
    }

    public int getHydrogenTankPercentage() {
        return hydrogenTankPercentage;
    }

    public void setHydrogenTankPercentage(int hydrogenTankPercentage) {
        this.hydrogenTankPercentage = hydrogenTankPercentage;
    }
}